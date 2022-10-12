namespace Terrasoft.Configuration.LrnAgreementExtract
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.ServiceModel.Activation;
    using Terrasoft.Core;
    using Terrasoft.Core.DB;
    using Terrasoft.Common;
    using Terrasoft.Web.Common;
    using Terrasoft.Core.Entities;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Terrasoft.Configuration.LrnAgreementExtractModel;
    using Terrasoft.File;
    using Terrasoft.File.Abstractions;
    using System.Text;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Threading.Tasks;

    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class AgreementExtract : BaseService
    {
        /// <summary>
        /// �������� ������� � ������ ���� ������������
        /// </summary>
        /// <param name="agreementId">������������� ��������</param>
        ///<returns>�������� ��������</returns>
        private AgreementExtractModel GetAgreementById(Guid agreementId)
        {
            var result = new AgreementExtractModel();
            try
            {
                var agreement = new LrnAgreement(UserConnection)
                {
                    Id = agreementId
                };

                if (agreement.FetchFromDB(agreementId))
                {
                    //�������� ������ �� ������� ����
                    var auto = new LrnAuto(UserConnection)
                    {
                        Id = agreement.LrnAutoId
                    };
                    auto.FetchFromDB(auto.Id);

                    //�������� ������ �� ������� ��������
                    var contact = new Contact(UserConnection)
                    {
                        Id = agreement.LrnContactId
                    };
                    contact.FetchFromDB(contact.Id);

                    //�������� ������ �� ������� �����
                    var brand = new LrnBrand(UserConnection)
                    {
                        Id = auto.LrnBrandId
                    };
                    brand.FetchFromDB(brand.Id);

                    //�������� ������ �� ������� ������
                    var model = new LrnModel(UserConnection)
                    {
                        Id = auto.LrnModelId
                    };
                    model.FetchFromDB(model.Id);

                    //��������� ������ ������ �� �������
                    var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "LrnInvoce");
                    esq.AddColumn("LrnName");
                    esq.AddColumn("LrnDate");
                    esq.AddColumn("LrnAmount");
                    esq.AddColumn("LrnFact");
                    var esqFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "LrnAgreement", agreementId);
                    var esqResult = esq.GetEntityCollection(UserConnection);

                    //������������ ������ �� ������� ������
                    result = new AgreementExtractModel
                    {

                        Number = agreement.LrnName,
                        Auto = new AutoModel
                        {
                            Brand = brand.Name,
                            Model = model.Name,
                            Details = auto.LrnDetails,
                            VIN = auto.LrnVin
                        },
                        Contact = new ContactModel
                        {
                            FullName = contact.Name
                        },
                        Summa = agreement.LrnSumma,
                        FactSumma = agreement.LrnFactSumma,
                        Fact = agreement.LrnFact,
                        Invoices = new List<InvoiceModel>()
                    };
                    foreach (var item in esqResult)
                    {
                        result.Invoices.Add(new InvoiceModel()
                        {
                            Number = item.GetTypedColumnValue<string>("LrnName"),
                            Date = item.GetTypedColumnValue<DateTime>("LrnDate"),
                            Amount = item.GetTypedColumnValue<decimal>("LrnAmount"),
                            Fact = item.GetTypedColumnValue<bool>("LrnFact")
                        });
                    }
                }
                return result;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// �������� ����� � ��������� ��������
        /// </summary>
        /// <param name="agreementExtract">������ ��������</param>
        /// <returns>������������� �����</returns>
        private Guid CreateFile(AgreementExtractModel agreementExtract, Guid agreementId)
        {
            Guid fileId = Guid.NewGuid();
            try
            {
                var fileLocator = new EntityFileLocator("LrnAgreementFile", fileId);
                IFile file = UserConnection.CreateFile(fileLocator);
                file.Name = $"AgreementExtract_{DateTime.Now}.json";
                file.SetAttribute("LrnAgreementId", agreementId);
                file.Save();
                //var content = ConvertObjectToByte(agreementExtract);
                var serialize = JsonConvert.SerializeObject(agreementExtract, Formatting.Indented);
                var content = Encoding.UTF8.GetBytes(serialize);
                using (Stream stream = new MemoryStream(content))
                {
                    file.Write(stream, FileWriteOptions.SinglePart);
                }
                return fileId;
            }
            catch
            {
                throw;
            }

        }

        /// <summary>
        /// ��������� ����� � ��������� ��������
        /// </summary>
        /// <param name="fileId">������������� �����</param>
        /// <returns>���������� �����</returns>
        private CustomFile GetFile(Guid fileId)
        {
            try
            {
                var fileLocator = new EntityFileLocator("LrnAgreementFile", fileId);
                IFile file = UserConnection.GetFile(fileLocator);
                var customFile = new CustomFile()
                {
                    FileName = file.Name,
                };
                //var st = file.Read();
                using (var stream = file.Read())
                {
                    using (var ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        customFile.FileContent = ms.ToArray();
                    }
                }
  
                return customFile;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// ������� ���� ��������
        /// </summary>
        /// <param name="agreementId">������������� ��������</param>
        /// <returns>���� ��������</returns>
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
        ResponseFormat = WebMessageFormat.Json)] 
        public CustomFile GetAgreementExtractFile(Guid agreementId)
        {
            try
            {
                //��������� ��������
                var agreement = GetAgreementById(agreementId);

                //���������� ����� � ���������
                var fileId = CreateFile(agreement, agreementId);

                //��������� ����� � ���������
                var customFile = GetFile(fileId);

                return customFile;
            }
            catch
            {
                throw;
            }
        }
    }

}