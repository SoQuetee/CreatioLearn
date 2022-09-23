﻿namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: OpportunityManagementSchema

	/// <exclude/>
	public class OpportunityManagementSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public OpportunityManagementSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public OpportunityManagementSchema(OpportunityManagementSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OpportunityManagement";
			UId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704");
			CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.15.2.501";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"Business Process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704");
			Version = 0;
			PackageUId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCurrentOpportunityParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("af8eea9e-0e11-426e-a870-2cff33d00f84"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePresentationParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0eae6fcc-65b6-433e-b4dc-e42323c488c1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"Presentation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMainContactParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b8d6c762-b63e-49b7-b651-c8d29f9c8d74"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAccountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("342aec56-8359-4c5b-826b-9e8489fd6a4b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsStageChangedByUserParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9786c0e4-cc5f-4c9f-b46d-090a297e2b74"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"IsStageChangedByUser",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateClientOpportunityCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("02b1469d-72ad-4909-a7cf-6b41b79d41a7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ClientOpportunityCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOpportunityTitleParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("738ceb61-832b-4b27-a973-9347e26e827e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"OpportunityTitle",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateContactParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b6534525-3848-4420-8930-e7bcc98a1756"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateClientNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b2b54e53-5309-4650-ac67-b8a4705d22b4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ClientName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCurrentOpportunityParameter());
			Parameters.Add(CreatePresentationParameter());
			Parameters.Add(CreateMainContactParameter());
			Parameters.Add(CreateAccountParameter());
			Parameters.Add(CreateIsStageChangedByUserParameter());
			Parameters.Add(CreateClientOpportunityCountParameter());
			Parameters.Add(CreateOpportunityTitleParameter());
			Parameters.Add(CreateContactParameter());
			Parameters.Add(CreateClientNameParameter());
		}

		protected virtual void InitializeProspectingParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("81432db0-f5f5-40d1-8f22-4d8c3bb4cf48"),
				ContainerUId = new Guid("0dbea59a-7031-4af4-a9b8-d96dea1c356c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eb29a402-5da5-4f9b-844c-e79f4e1f115a"),
				ContainerUId = new Guid("0dbea59a-7031-4af4-a9b8-d96dea1c356c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("fdc628cc-1da4-4b5d-b397-d6c93e1e9517"),
				ContainerUId = new Guid("0dbea59a-7031-4af4-a9b8-d96dea1c356c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeNeedsAnalysisParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("5b443132-caa7-4f82-80dd-cc84a5380caa"),
				ContainerUId = new Guid("c6385211-3b10-447a-8d34-e3f3605c4793"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6a80392b-c787-4788-a532-fca2370b3840"),
				ContainerUId = new Guid("c6385211-3b10-447a-8d34-e3f3605c4793"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("5e47a6d3-f9bb-404f-87e2-aed31c62acc3"),
				ContainerUId = new Guid("c6385211-3b10-447a-8d34-e3f3605c4793"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{b8d6c762-b63e-49b7-b651-c8d29f9c8d74}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeOppManagementValuePpropositionParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("4274528b-203f-43bc-87d3-abf86b9a792e"),
				ContainerUId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b20705a6-a8bc-460d-8389-aaaa9b58be16"),
				ContainerUId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var presentationParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("f7d5c580-2ff1-4209-a013-2bef80d7f3a9"),
				ContainerUId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Name = @"Presentation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			presentationParameter.SourceValue = new ProcessSchemaParameterValue(presentationParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{0eae6fcc-65b6-433e-b4dc-e42323c488c1}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(presentationParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("2a0e89a7-92f6-4cf6-a9f2-a0140105ba95"),
				ContainerUId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{b8d6c762-b63e-49b7-b651-c8d29f9c8d74}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeIdDecisionMakersParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("76602486-f8b8-47cb-8b9f-d00841250f90"),
				ContainerUId = new Guid("d58ab1aa-6acb-4539-9b28-cda203b74ced"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e6028b5e-002d-4bc7-bc34-8affd537f00c"),
				ContainerUId = new Guid("d58ab1aa-6acb-4539-9b28-cda203b74ced"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("5dc6ce94-0fc5-4ffa-8e00-83c67ce5da35"),
				ContainerUId = new Guid("d58ab1aa-6acb-4539-9b28-cda203b74ced"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{b8d6c762-b63e-49b7-b651-c8d29f9c8d74}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeOppManagementPerceptionAnalysisParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("c647b290-fae9-4f2f-b291-b94262f923dc"),
				ContainerUId = new Guid("da8227c5-5602-4a29-b848-1fb1e6b57440"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2d34fbe8-274b-4c6e-88d8-7307f538cfee"),
				ContainerUId = new Guid("da8227c5-5602-4a29-b848-1fb1e6b57440"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("36230419-640f-4176-ad85-8beca7d791ca"),
				ContainerUId = new Guid("da8227c5-5602-4a29-b848-1fb1e6b57440"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{b8d6c762-b63e-49b7-b651-c8d29f9c8d74}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeOppManagementProposalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("0a768934-39e6-4d8e-9fd4-4859b59f0779"),
				ContainerUId = new Guid("e3b6949a-0754-40f7-a369-1f69dae8bc2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2902276d-abfd-4fd2-b6f9-b5bda02f0222"),
				ContainerUId = new Guid("e3b6949a-0754-40f7-a369-1f69dae8bc2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("dc02a11c-a24c-4451-897b-9dce3a6a7178"),
				ContainerUId = new Guid("e3b6949a-0754-40f7-a369-1f69dae8bc2d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{b8d6c762-b63e-49b7-b651-c8d29f9c8d74}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeOppManagementNegotiationsParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("f58812eb-a5a3-43ef-84a7-454b69c3aaed"),
				ContainerUId = new Guid("2bd13ebc-d0be-488e-9dff-abea5ba029d2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("33eb9e90-615e-412b-86bf-8d9f6c8831a8"),
				ContainerUId = new Guid("2bd13ebc-d0be-488e-9dff-abea5ba029d2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("47d1669f-a6cc-48ac-85b8-94795d69938e"),
				ContainerUId = new Guid("2bd13ebc-d0be-488e-9dff-abea5ba029d2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeOppManagementContractationParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("a2600d6c-144b-4c75-acb3-f04cb1577884"),
				ContainerUId = new Guid("8cd60286-ecaa-4f5c-aa25-62e4f4b7ee26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var opportunityStageChangedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("16815d2d-6357-4be4-9265-46e9a99e093b"),
				ContainerUId = new Guid("8cd60286-ecaa-4f5c-aa25-62e4f4b7ee26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			opportunityStageChangedParameter.SourceValue = new ProcessSchemaParameterValue(opportunityStageChangedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368")
			};
			parametrizedElement.Parameters.Add(opportunityStageChangedParameter);
			var mainContactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("b812d4a7-16f1-4a13-b2e9-f0b2c48a8532"),
				ContainerUId = new Guid("8cd60286-ecaa-4f5c-aa25-62e4f4b7ee26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			mainContactParameter.SourceValue = new ProcessSchemaParameterValue(mainContactParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368")
			};
			parametrizedElement.Parameters.Add(mainContactParameter);
		}

		protected virtual void InitializeOppManagementEndStageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var currentOpportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("1494d351-8b28-4d15-a088-912b8872f732"),
				ContainerUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentOpportunityParameter.SourceValue = new ProcessSchemaParameterValue(currentOpportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(currentOpportunityParameter);
			var nextOpportunityStageNumberParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0fa7431c-1004-411e-ae2e-b485fc040737"),
				ContainerUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"NextOpportunityStageNumber",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			nextOpportunityStageNumberParameter.SourceValue = new ProcessSchemaParameterValue(nextOpportunityStageNumberParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(nextOpportunityStageNumberParameter);
			var currentStageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dcb46392-5cd0-43ba-9004-211ef9690ca5"),
				ContainerUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"CurrentStage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			currentStageParameter.SourceValue = new ProcessSchemaParameterValue(currentStageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(currentStageParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9c2d0712-831e-499c-a94b-562db3eaed86"),
				ContainerUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"""You have completed all steps of the \"""" + [#[IsOwnerSchema:false].[IsSchema:false].[Element:{456fe102-f895-4fd8-8351-a77859dd709e}].[Parameter:{e11d0fd9-aca0-4ee9-b9cf-f8d97c1fc2ba}].[EntityColumn:{736c30a7-c0ec-4fa9-b034-2552b319b633}]#] + ""\"". Select the next action:""",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var isStageChangedByUserParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2f2941be-b24c-4797-8b31-addbd6057927"),
				ContainerUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"IsStageChangedByUser",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isStageChangedByUserParameter.SourceValue = new ProcessSchemaParameterValue(isStageChangedByUserParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{9786c0e4-cc5f-4c9f-b46d-090a297e2b74}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(isStageChangedByUserParameter);
			var dontShowPageEndOfStageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ef2201a2-720c-453d-8a5b-62d5077c6041"),
				ContainerUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"DontShowPageEndOfStage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			dontShowPageEndOfStageParameter.SourceValue = new ProcessSchemaParameterValue(dontShowPageEndOfStageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(dontShowPageEndOfStageParameter);
			var nextStageParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				UId = new Guid("a8f664f6-40f1-4b7e-9602-25265d8962b3"),
				ContainerUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"NextStage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			nextStageParameter.SourceValue = new ProcessSchemaParameterValue(nextStageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(nextStageParameter);
		}

		protected virtual void InitializeReadOppDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("378a7c4d-c2ae-4dc0-8450-7d00de21889a"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,164,98,75,254,146,115,92,182,101,47,105,160,105,41,36,75,120,146,158,178,2,127,197,150,104,22,179,255,189,242,58,155,66,14,165,208,83,64,7,233,61,205,188,153,65,154,31,220,244,217,53,30,199,218,66,51,33,13,59,83,147,156,131,72,4,71,150,164,34,99,153,130,130,201,210,38,172,72,173,52,40,19,45,42,36,180,131,22,107,178,162,183,198,121,66,157,199,118,170,239,230,63,164,126,12,72,31,236,249,240,77,31,176,133,239,203,0,192,172,176,170,42,153,78,184,102,25,96,197,192,136,148,129,228,66,27,35,101,166,45,89,181,84,152,139,66,101,130,161,82,57,203,100,197,153,42,160,100,138,151,42,23,74,129,176,57,161,13,90,191,125,30,70,156,38,215,119,245,140,175,251,219,227,16,85,174,179,55,125,19,218,142,208,22,61,220,128,63,44,66,18,204,114,13,76,103,50,178,91,44,25,8,105,152,0,85,242,178,194,180,72,75,66,53,12,126,161,37,59,67,168,1,15,63,160,9,120,102,158,93,212,200,69,146,86,121,17,177,169,136,118,4,79,88,85,68,119,214,20,86,162,40,164,84,230,146,215,151,224,226,222,77,215,161,197,209,233,151,216,49,230,215,143,245,172,251,206,143,125,179,80,95,159,175,223,226,179,95,195,125,105,253,92,13,249,88,95,64,228,68,195,132,155,198,97,231,183,157,238,141,235,30,87,206,211,41,66,218,1,70,55,93,82,216,62,5,104,8,29,221,227,225,175,105,109,194,228,251,246,29,89,165,209,102,228,136,143,236,44,119,121,131,198,77,67,3,199,243,185,38,31,159,66,239,175,54,97,28,35,248,67,63,12,253,232,67,231,252,113,109,144,55,4,53,185,39,96,43,68,144,241,19,96,154,178,140,23,200,160,42,19,198,181,181,66,152,36,177,85,118,79,162,168,255,31,117,183,155,190,254,234,46,63,100,245,180,255,20,171,111,10,55,23,100,61,255,139,186,211,126,209,183,63,197,245,27,208,129,205,245,232,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("09ca5d94-4475-494b-bb1d-1711734825d0"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("809504a0-92ba-4c37-9223-2bd86178ceeb"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("47e4b981-ae34-43d6-80d1-541eb76f8886"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("093cfd0d-3919-4594-bdbd-243b89c2421c"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("99a55b65-320e-4a00-a443-906ccbd17195"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ea0a8aa9-15cc-4e7b-b857-0fde66046c9d"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,201,44,201,73,181,50,180,50,212,241,76,177,50,176,50,0,0,169,240,29,88,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("61d6f451-48d9-4c96-917b-f6c5ce85df83"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("10ddcd85-ccf7-42e5-8390-78074cc70ded"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c1248569-3f8c-43f3-9cb3-48975e8f84ef"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3feedf55-86a5-4ac5-bb7d-a85d1a84eb9d"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("734b2f72-a22c-41d7-900f-06d5bb7faf75"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d60364bd-0961-431f-8a33-c5f616c3de09"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5fc444a5-9b7a-422c-8693-86213fa317e7"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("e4513fe5-860a-4300-889d-38b3328e8894"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("adee94c3-29c5-4b7a-960c-20c6b71d3afb"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("454dc5b0-a0d3-4a3d-b852-62380501a11c"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b8a4d7c8-f486-4ff4-8d57-c646ef576c20"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1642233f-c291-40c4-83ec-5184121f5590"),
				ContainerUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeFindPresentationParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("590098f3-05ec-4bc7-ac56-18d861124c44"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,150,91,107,27,71,20,199,191,138,217,135,62,237,148,185,156,185,169,143,198,5,67,235,4,146,150,66,48,225,204,204,25,123,137,164,85,118,103,105,141,208,119,239,172,100,37,34,56,174,235,150,22,67,222,246,118,238,255,223,156,221,190,239,198,31,187,101,161,97,145,113,57,82,59,93,166,69,67,90,123,155,2,48,138,206,49,136,100,153,11,153,179,132,92,56,145,188,78,33,52,237,26,87,180,104,14,214,23,169,43,77,219,21,90,141,139,119,219,207,78,203,48,81,251,62,239,111,222,196,91,90,225,47,115,128,8,224,147,83,146,33,196,200,32,112,193,130,79,154,57,20,50,130,68,159,157,111,14,185,72,97,162,228,200,153,204,222,51,72,193,50,31,92,100,58,129,163,168,29,96,112,77,187,164,92,46,254,216,12,52,142,93,191,94,108,233,211,245,219,187,77,205,242,16,251,188,95,78,171,117,211,174,168,224,107,44,183,53,17,151,28,100,31,89,0,23,24,88,31,152,199,104,24,128,144,89,129,50,17,101,211,70,220,148,217,109,243,166,96,153,198,166,29,40,211,64,235,72,39,53,57,174,17,35,1,115,134,3,3,94,155,134,158,2,227,89,131,176,160,189,138,188,105,19,22,252,21,151,19,237,243,218,118,213,48,72,175,185,21,153,89,194,90,33,25,201,92,18,200,188,240,33,43,171,100,206,242,216,237,159,250,254,195,180,169,157,30,175,166,21,13,93,188,31,27,213,254,247,195,98,27,251,117,25,250,229,236,252,234,196,224,48,158,251,151,191,29,90,178,220,191,153,13,155,93,59,141,116,190,236,104,93,46,214,177,79,221,250,102,63,185,221,174,218,172,54,56,116,227,177,145,23,31,39,92,214,6,116,55,183,143,54,252,53,14,53,126,157,250,75,43,185,221,28,51,223,231,60,203,57,117,227,102,137,119,251,251,69,243,221,199,169,47,63,92,174,207,54,67,127,51,215,124,120,208,124,97,120,252,80,121,72,16,28,48,237,200,176,148,133,96,222,138,42,11,46,146,225,228,149,139,230,222,195,174,125,48,212,85,95,206,170,240,134,66,233,47,66,185,167,135,186,174,179,253,87,57,85,65,101,97,156,103,201,217,122,102,240,96,152,231,150,87,88,5,130,204,73,57,238,159,207,169,6,47,162,82,153,145,151,182,158,72,232,24,106,91,131,129,19,156,80,67,212,230,132,211,217,217,195,148,90,29,32,169,138,185,214,105,174,40,153,89,121,156,169,12,30,181,75,222,68,251,210,36,251,141,210,175,81,250,22,199,15,143,51,147,3,113,140,85,10,49,71,126,96,38,112,158,255,27,102,16,149,140,152,171,170,73,11,6,18,76,53,226,188,126,31,129,156,161,228,140,248,39,187,77,64,70,43,24,241,122,8,128,146,154,97,221,119,117,134,128,210,43,74,66,185,19,102,206,177,208,77,63,220,61,204,141,55,130,36,119,53,65,33,171,179,84,41,12,220,235,25,116,65,6,146,137,223,182,219,11,40,249,137,220,252,76,84,170,205,227,232,128,140,22,34,248,255,101,221,132,168,181,179,220,176,108,98,93,55,214,26,22,172,79,76,10,72,100,73,24,46,229,243,209,1,179,95,165,88,115,48,179,218,231,225,169,28,152,229,20,37,102,74,218,230,19,116,94,109,54,253,80,166,117,87,190,66,15,18,152,28,156,101,145,203,90,24,82,93,95,73,137,250,131,40,85,76,201,123,136,249,165,73,233,249,244,156,79,99,233,87,47,173,222,39,162,115,62,13,117,250,229,172,255,172,137,199,49,194,236,168,22,75,140,147,152,151,128,33,134,85,217,76,198,156,149,74,117,25,57,120,252,7,241,111,135,124,119,57,190,250,125,125,68,239,208,182,235,239,235,211,47,30,124,58,230,22,219,167,100,185,187,62,193,253,122,247,39,24,125,65,165,92,14,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d7349ecf-3808-499e-94e5-a6af0b6c8059"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3ddba6f3-67f9-46a5-bda4-c9be1d38263b"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7711d045-dde7-4665-b251-2b6cda4ba16c"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("14ac52bb-d8de-4e93-ba14-2092314ad9ec"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("44ef2079-3350-48f5-8417-a062c43f2a0e"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f79b49c3-44b7-458a-af53-ffc25ba8de44"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("bcd38317-a882-4317-8881-b21b8f0ca57b"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9371b699-8ba0-411a-be54-7912877edf8f"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ca81fffe-20a5-46bf-ab20-5fa6f0638a5f"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6c987b70-a95f-48b9-bcfb-8ddc2192e44a"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e64f2c49-b461-45e7-bb8f-1f660acca3cc"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b598adf2-e516-42e9-9f34-f99fb251a690"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5b343947-0aa5-4776-9b18-096d905e7603"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("6f8cde56-f764-4ad1-b528-0d9031cd1e8e"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6351aab6-3117-48e1-afe4-c9ad827a53d7"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1fbf3104-1357-48ca-926e-2f85305a4602"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4b31518f-f475-452a-8aba-9cda085b4492"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("58a36797-420b-4f2a-a864-3829561982fe"),
				ContainerUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeLinkOppToProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entityIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("41befda8-dd24-45a3-8e91-5fa9d9e03fa0"),
				ContainerUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Name = @"EntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entityIdParameter.SourceValue = new ProcessSchemaParameterValue(entityIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("773490bc-4ab0-4078-9f03-a0ead61c8e69"),
				ContainerUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
		}

		protected virtual void InitializeReadOppMainContactParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6ec44add-c3cb-4c83-aa2a-21116fe737ce"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,203,106,220,48,20,253,149,224,69,87,86,145,37,217,146,220,93,134,41,4,74,18,232,131,66,24,194,149,116,149,49,241,99,98,203,52,97,152,127,175,236,201,36,97,8,165,165,217,100,167,135,239,209,185,231,158,227,237,117,53,124,174,234,128,125,233,161,30,48,29,207,92,153,168,76,107,170,20,37,90,74,65,4,102,142,232,130,229,4,140,144,76,231,40,152,214,73,218,66,131,101,178,175,94,186,42,36,105,21,176,25,202,171,237,51,104,232,71,76,175,253,188,249,106,215,216,192,247,233,1,15,76,10,207,29,201,37,112,34,4,34,49,133,16,196,105,46,68,6,60,115,200,146,61,23,83,24,235,169,245,68,50,231,137,96,185,38,144,83,30,43,51,42,12,230,76,170,248,105,141,62,44,239,55,61,14,67,213,181,229,22,159,214,223,30,54,145,229,254,237,69,87,143,77,155,164,13,6,184,132,176,46,147,92,228,38,19,14,136,5,85,16,1,146,69,116,229,73,238,192,115,160,198,120,71,147,212,194,38,76,176,201,197,102,211,245,97,108,171,240,144,164,61,122,236,177,181,248,162,49,64,81,120,163,36,177,148,217,136,135,138,128,227,25,1,205,184,117,78,107,97,125,146,58,8,240,3,234,17,103,114,219,106,106,51,234,74,101,22,219,68,208,81,242,130,17,229,50,32,58,211,198,115,201,153,247,236,32,249,151,174,187,29,55,81,238,225,124,108,176,175,236,227,236,48,14,161,235,203,173,237,218,208,119,245,4,126,254,162,96,63,163,199,203,159,123,93,234,249,102,42,76,118,233,56,224,162,174,176,13,203,214,118,174,106,111,230,241,237,118,177,166,217,64,95,13,7,53,151,119,35,212,81,128,234,102,253,71,213,23,227,16,186,230,189,245,155,198,94,35,76,116,236,204,121,50,180,171,134,77,13,15,243,190,76,62,220,141,93,248,180,24,251,56,253,112,210,61,123,98,127,145,28,1,28,10,192,43,140,205,34,161,152,101,209,201,5,18,80,146,18,102,189,231,220,81,234,149,120,68,216,165,111,243,228,213,217,112,241,171,61,68,111,47,219,234,99,60,61,58,184,60,84,151,219,191,97,185,91,29,120,174,162,59,222,52,238,17,223,107,149,115,226,164,87,68,56,147,17,69,181,38,86,3,231,168,105,94,228,254,63,226,110,105,97,24,32,145,118,250,177,249,24,124,165,115,70,140,228,90,105,206,114,86,168,23,113,191,236,171,6,250,135,147,201,67,96,195,171,70,214,212,20,185,137,92,35,241,152,248,76,68,194,82,106,194,4,163,113,1,94,83,121,48,242,105,215,213,8,237,63,56,121,177,70,123,123,218,221,31,251,216,78,231,38,158,191,230,226,25,243,63,98,251,228,134,247,213,240,43,185,61,78,197,228,207,217,180,171,221,111,167,91,127,183,250,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d00d1284-6858-4e40-8c5e-a0f9533fcf07"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b0d4d59f-c216-40cc-ae96-8a3781c09399"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e0d7bbe7-f11e-455f-b2e5-ea58c2f931f5"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c886b18d-6796-4aed-9bbf-b5cf5d06a8fb"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("57ed4753-40aa-4155-9040-01d05641a1f9"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5f7ffe6c-b419-41a7-92a7-41c7106f2edd"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,205,79,201,76,203,76,77,241,207,179,50,178,50,212,241,76,177,50,176,50,0,0,136,48,240,252,21,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				UId = new Guid("7e1be2d8-91ed-49a9-b295-80136f24d052"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("57df5b20-4163-4583-a743-b3bd41e7476c"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("36a1459d-8951-4d2d-83c0-ce1785ad17d6"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5227d4a1-7e1a-488c-b08f-249e8af25b4f"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("26f8e2e7-d0a5-4cce-a1c4-005d27eac4ef"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a91ced74-aa15-4fc9-ad90-beb2c4848a91"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0597c0d4-7fe9-438b-996d-a1cec2485907"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				UId = new Guid("24109401-bfc2-4470-b36d-6264dd15b451"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("213f4da0-dbd4-4801-9f20-61ad02c52c1a"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,5,193,65,1,0,32,8,3,192,68,123,224,112,64,28,132,254,25,188,107,157,92,118,35,74,6,47,39,50,245,96,212,149,237,206,148,62,148,174,20,226,36,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("14eb509a-8789-4d60-a6db-802311455631"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d0767765-3046-4ca8-9f14-831752bcf2cb"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cc9eac64-33dd-45a4-b215-5fd338d82349"),
				ContainerUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeStartSignalLeadStageChangeParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("db9eb8c4-a431-4aa1-9ee4-580f6ffe1896"),
				ContainerUId = new Guid("a3374f46-5620-4706-95ae-1144c8bbbf48"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a3374f46-5620-4706-95ae-1144c8bbbf48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e33c0cfe-adc7-4b51-8f8f-370d3a2a3f3d"),
				ContainerUId = new Guid("a3374f46-5620-4706-95ae-1144c8bbbf48"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a3374f46-5620-4706-95ae-1144c8bbbf48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeOpenEditPageUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var objectSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("89651dda-ab13-4a9a-8a6c-4c658eb62d6b"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ObjectSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			objectSchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(objectSchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(objectSchemaIdParameter);
			var pageSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("26dd7e96-d79a-4c1d-a31a-e8388a3d205d"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"PageSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			pageSchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(pageSchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"df249c13-df7a-48d2-b128-85183c4a0e10",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(pageSchemaIdParameter);
			var editModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("816e7c8a-2c10-4a6f-9be0-35eb9c4ddff5"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"EditMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			editModeParameter.SourceValue = new ProcessSchemaParameterValue(editModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(editModeParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("97a322a9-f1ca-49d6-ab97-756349dc65dc"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,171,86,82,41,169,44,72,85,178,82,10,73,45,42,74,44,206,79,43,209,115,206,47,74,213,11,40,202,79,78,45,46,214,243,201,79,78,204,201,172,74,76,202,73,13,72,44,74,204,77,45,73,45,10,75,204,41,77,45,246,201,44,46,209,81,64,213,166,164,163,164,82,6,150,85,178,138,142,173,5,0,199,127,71,237,94,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("c5f0d6a4-d18b-446e-8335-18fb080f660a"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var executedModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dc433afb-dfc9-4098-97f6-caf21a16f74e"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ExecutedMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			executedModeParameter.SourceValue = new ProcessSchemaParameterValue(executedModeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executedModeParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1c82493a-8e96-4e42-8e59-0050ff57ccc6"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsMatchConditions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("933618d4-76fc-43ac-ac72-94ef456a3325"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var generateDecisionsFromColumnParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0e24948f-5ffc-48eb-8cd6-6290a4458b50"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"GenerateDecisionsFromColumn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			generateDecisionsFromColumnParameter.SourceValue = new ProcessSchemaParameterValue(generateDecisionsFromColumnParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(generateDecisionsFromColumnParameter);
			var decisionalColumnMetaPathParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("41355bca-971c-4003-990e-8da96ce29d27"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"DecisionalColumnMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			decisionalColumnMetaPathParameter.SourceValue = new ProcessSchemaParameterValue(decisionalColumnMetaPathParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(decisionalColumnMetaPathParameter);
			var resultParameterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b8971ff1-f4b5-4bd1-ad83-92a56940fda8"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ResultParameter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			resultParameterParameter.SourceValue = new ProcessSchemaParameterValue(resultParameterParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultParameterParameter);
			var isReexecutionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6399efc5-9d36-4c8d-84c5-3e5851db8ea2"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsReexecution",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isReexecutionParameter.SourceValue = new ProcessSchemaParameterValue(isReexecutionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isReexecutionParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c482b777-a1a7-41d8-86f3-3deb50dd0ff8"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Enter the opportunity details",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("8a4540f5-5964-49f6-9dd1-077938701455"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ActivityCategory",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			activityCategoryParameter.SourceValue = new ProcessSchemaParameterValue(activityCategoryParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"f51c4643-58e6-df11-971b-001d60e938c6",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(activityCategoryParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("4960bd57-b2f9-45a4-9184-feb6f57d727b"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dbe4def5-6971-4b97-a463-8f91e0d395d8"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Duration",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationParameter.SourceValue = new ProcessSchemaParameterValue(durationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("865a5fc7-ff9d-42c1-b37f-e7d02f2ef7aa"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"DurationPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationPeriodParameter.SourceValue = new ProcessSchemaParameterValue(durationPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f513407c-014f-4acb-a526-b212d7445f91"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"StartIn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInParameter.SourceValue = new ProcessSchemaParameterValue(startInParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8dabbbff-449b-468b-a494-80ad1cb1636d"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"StartInPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInPeriodParameter.SourceValue = new ProcessSchemaParameterValue(startInPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("502e4584-f30e-4b9b-bc80-da8f5149d287"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RemindBefore",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforeParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("514f3679-fd23-41d3-ac6e-b13355c6b716"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RemindBeforePeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforePeriodParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforePeriodParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ea067875-15ce-466a-b805-9fd42938fa32"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ShowInScheduler",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showInSchedulerParameter.SourceValue = new ProcessSchemaParameterValue(showInSchedulerParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ab3aea55-ee61-4a61-8d37-c77f890582a6"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ShowExecutionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"True",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("e98d7ab1-5b31-4dfd-bd8a-01a99df1c13e"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Lead",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadParameter.SourceValue = new ProcessSchemaParameterValue(leadParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("4fbdcb67-4e39-4e84-b5d0-e4916df0cc20"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("92150aaf-bd20-4b0b-aae5-802a6ddacaaf"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactParameter.SourceValue = new ProcessSchemaParameterValue(contactParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("b9c197e7-4fda-443b-af5d-04703f2512af"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Opportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityParameter.SourceValue = new ProcessSchemaParameterValue(opportunityParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(opportunityParameter);
			var invoiceParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				UId = new Guid("500c6c82-6637-4f8b-bb30-9fb30e6c5c7a"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Invoice",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			invoiceParameter.SourceValue = new ProcessSchemaParameterValue(invoiceParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(invoiceParameter);
			var documentParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				UId = new Guid("4450ed80-79a2-4253-bf53-f4c99757acd0"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Document",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			documentParameter.SourceValue = new ProcessSchemaParameterValue(documentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(documentParameter);
			var incidentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ad403374-d787-48cb-8401-24d5938fecff"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Incident",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			incidentParameter.SourceValue = new ProcessSchemaParameterValue(incidentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(incidentParameter);
			var caseParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("29b687ca-aff7-43a8-8cf5-918beb75a406"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Case",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			caseParameter.SourceValue = new ProcessSchemaParameterValue(caseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(caseParameter);
			var activityResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("12c7bcea-bbb6-467e-8b86-c73d6c2327ac"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Out,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ActivityResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activityResultParameter.SourceValue = new ProcessSchemaParameterValue(activityResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activityResultParameter);
			var currentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0b1c3a54-c7df-40ad-9016-020646d1af0f"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"CurrentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			currentActivityIdParameter.SourceValue = new ProcessSchemaParameterValue(currentActivityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(currentActivityIdParameter);
			var isActivityCompletedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f71b0056-5161-4704-b6e6-57433d6cec8d"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Out,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsActivityCompleted",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isActivityCompletedParameter.SourceValue = new ProcessSchemaParameterValue(isActivityCompletedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isActivityCompletedParameter);
			var executionContextParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8a103d16-ba6b-4bd1-8ddc-3e9254763dc8"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ExecutionContext",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			executionContextParameter.SourceValue = new ProcessSchemaParameterValue(executionContextParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executionContextParameter);
			var pageTypeUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ef2d226f-d2f6-44b9-8885-f2dc3c38e962"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"PageTypeUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			pageTypeUIdParameter.SourceValue = new ProcessSchemaParameterValue(pageTypeUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(pageTypeUIdParameter);
			var activitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("41c2a0db-39ad-4b1a-9e9b-392fb44871ef"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ActivitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(activitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activitySchemaUIdParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b75c6907-0060-42e9-a1b2-3ef95bc2be78"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"InformationOnStep",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			informationOnStepParameter.SourceValue = new ProcessSchemaParameterValue(informationOnStepParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var orderParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("66c1e2c8-d668-462c-8641-cc41b2cb6ee7"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Order",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			orderParameter.SourceValue = new ProcessSchemaParameterValue(orderParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(orderParameter);
			var requestsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aef3f8a1-0813-481c-8557-882ce62c0029"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Requests",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			requestsParameter.SourceValue = new ProcessSchemaParameterValue(requestsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(requestsParameter);
			var listingParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("002eea98-0f7a-4a3f-843b-636f63d8cf6e"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Listing",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			listingParameter.SourceValue = new ProcessSchemaParameterValue(listingParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(listingParameter);
			var propertyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bc19d651-dabb-46b9-9f3b-b8da6581c36d"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Property",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			propertyParameter.SourceValue = new ProcessSchemaParameterValue(propertyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(propertyParameter);
			var contractParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				UId = new Guid("f650edfc-44d9-4d70-bb68-14bd3c9ad3d1"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Contract",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contractParameter.SourceValue = new ProcessSchemaParameterValue(contractParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contractParameter);
			var problemParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230"),
				UId = new Guid("ca76ab70-8cff-4f21-81c9-b9e679c8ddff"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Problem",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			problemParameter.SourceValue = new ProcessSchemaParameterValue(problemParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(problemParameter);
			var changeParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("de5c8d59-d372-407d-8c09-f0523e057e40"),
				UId = new Guid("b40747ec-b53b-4474-ba15-384d04322c33"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Change",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			changeParameter.SourceValue = new ProcessSchemaParameterValue(changeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(changeParameter);
			var releaseParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				UId = new Guid("35d9c012-2263-46ec-952f-e92631c411de"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Release",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			releaseParameter.SourceValue = new ProcessSchemaParameterValue(releaseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(releaseParameter);
			var projectParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				UId = new Guid("cd406c52-f5b6-4f47-9117-6e510888a57e"),
				ContainerUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Project",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			projectParameter.SourceValue = new ProcessSchemaParameterValue(projectParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(projectParameter);
		}

		protected virtual void InitializeReadDataLeadParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9d21b7c3-5ea8-4f73-a5bf-f266ecb2b022"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,43,139,14,61,89,193,31,178,44,185,167,18,182,101,161,164,161,77,75,33,187,132,145,52,202,10,252,177,177,100,146,96,246,191,87,94,103,91,200,161,228,210,67,193,7,205,72,239,205,123,143,241,116,231,252,71,215,4,28,106,11,141,199,100,220,152,154,100,210,90,142,105,74,139,74,48,202,84,165,169,50,105,78,83,166,75,101,109,145,231,138,145,164,131,22,107,178,160,215,198,5,146,184,128,173,175,111,167,63,164,97,24,49,185,179,167,226,155,222,99,11,223,231,1,44,3,43,36,74,90,149,169,162,12,149,162,66,131,166,145,91,42,206,4,203,80,147,69,11,151,69,202,115,163,169,182,149,165,76,8,67,21,207,128,102,25,67,109,173,180,188,200,73,210,160,13,235,167,195,128,222,187,190,171,39,252,125,190,121,62,68,149,203,236,203,190,25,219,142,36,45,6,184,134,176,175,9,96,138,172,212,64,53,147,37,101,22,43,10,133,52,180,0,85,229,149,192,140,103,21,73,52,28,194,76,75,54,134,36,6,2,252,128,102,196,19,243,228,162,198,188,72,51,81,242,136,205,10,77,89,145,167,84,112,81,81,107,184,149,88,112,41,149,57,231,245,105,116,241,236,252,213,216,226,224,244,75,236,24,243,235,135,122,210,125,23,134,190,153,169,175,78,207,111,240,41,44,225,190,92,253,92,12,133,216,159,65,228,152,140,30,47,27,135,93,88,119,186,55,174,187,95,56,143,199,8,105,15,48,56,127,78,97,253,48,66,67,146,193,221,239,255,154,214,229,232,67,223,254,71,86,147,104,51,114,196,37,59,201,157,119,208,56,127,104,224,249,84,215,228,221,195,216,135,247,159,17,204,202,7,184,199,122,181,221,46,189,15,143,224,66,100,90,121,104,240,220,188,248,138,186,31,204,106,99,150,154,188,26,80,147,45,129,162,168,152,101,156,150,60,134,192,170,148,83,89,2,206,139,201,180,80,74,89,38,46,140,146,168,132,102,20,88,145,81,6,144,81,137,200,104,41,82,203,173,197,76,72,190,37,209,217,191,215,123,187,241,95,30,187,243,111,184,4,183,187,136,221,87,141,117,131,109,76,184,158,222,98,240,24,1,215,231,81,245,244,22,187,199,221,108,120,119,140,223,47,96,108,124,62,126,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ddb8f352-0211-44fc-8b93-f3abbd023649"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("65843b8b-f9d2-41cc-8170-734e51b1a5ca"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b341955e-cf2a-400b-907c-a8557f3c93c1"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1409c0d5-2885-44c0-8161-47a69431903e"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bf8e626b-4175-4de4-99ed-f96ac7a26c1d"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5b1ea493-ed30-4d02-bdbb-0efcafe849f9"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,241,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,197,68,70,233,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("d4413fda-e205-481c-828d-b4e67061712f"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("95dce4e4-ff66-4664-b6f7-dacd9bf91bca"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9a35a728-e367-4047-bda3-0b7be164f5ae"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7090f5b0-1f18-467e-9a40-60d3d177b9c4"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("11af421d-b60c-4cf9-a2f6-5d599eaa340c"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2c5d37d8-5236-42a7-b93f-6d4732c94385"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("83955bee-426f-4831-9715-4eda69412fb7"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("2d0ef092-481e-4e72-920c-caa204e62d66"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e72ba4ac-d6aa-4c7c-8d86-2be667ba6622"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cc0389f7-a908-4db4-b2f9-dc8c55c3a68c"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51f4ccd8-a3bb-4d1e-b73c-052fe071da49"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b4764d2c-5f48-499c-866c-b435787d5c35"),
				ContainerUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeChangeDataLeadParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("f161763e-878f-4674-8e4e-3fc88a6a58b3"),
				ContainerUId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("092165e2-051d-4f89-92cf-c710ba91ab13"),
				ContainerUId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"IsMatchConditions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6c0d30ee-7c93-4ea8-9ca4-918c3d232658"),
				ContainerUId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,93,107,219,48,20,253,43,65,15,123,178,130,63,100,125,120,143,193,29,121,233,202,214,141,65,27,138,62,174,26,129,108,167,182,204,90,76,254,251,228,56,217,160,15,35,79,131,129,49,146,236,115,238,61,71,231,78,79,110,184,113,62,64,95,89,233,7,72,198,173,169,16,0,147,52,215,6,231,196,8,76,88,193,176,96,165,198,5,213,25,37,37,48,81,50,148,180,178,129,10,45,232,218,184,128,18,23,160,25,170,135,233,15,105,232,71,72,158,236,105,243,85,239,161,145,223,230,2,36,147,150,11,16,152,149,169,194,4,148,194,92,75,141,173,45,132,162,132,147,12,52,58,247,66,129,105,158,26,204,152,178,152,112,41,176,52,156,97,150,131,42,121,206,210,82,151,40,241,96,67,253,122,232,97,24,92,215,86,19,252,94,223,191,29,98,151,75,237,77,231,199,166,69,73,3,65,222,201,176,175,144,132,20,72,169,37,214,68,148,152,88,96,88,22,194,224,66,42,150,51,14,25,205,162,82,45,15,97,166,69,91,131,18,35,131,252,46,253,8,39,230,201,197,30,243,34,205,120,73,35,54,43,52,38,69,158,98,78,99,143,214,80,43,160,160,66,40,115,241,235,211,232,226,218,13,183,99,3,189,211,103,219,33,250,215,245,213,164,187,54,244,157,159,169,111,79,191,223,195,107,88,204,61,127,250,177,8,10,241,124,6,161,99,50,14,176,241,14,218,80,183,186,51,174,125,94,56,143,199,8,105,14,178,119,195,197,133,250,101,148,30,37,189,123,222,255,213,173,205,56,132,174,249,143,164,38,81,102,228,136,33,59,181,59,103,208,184,225,224,229,219,105,95,161,15,47,99,23,62,126,1,105,86,126,126,205,202,214,55,174,31,194,106,14,237,170,179,171,232,192,232,67,228,92,233,206,123,208,243,141,175,183,102,65,162,119,21,42,244,136,44,16,195,57,164,152,208,56,27,132,43,137,69,166,52,6,97,192,144,82,21,186,76,215,134,144,172,176,70,98,200,211,24,48,158,105,204,115,110,176,34,64,89,26,211,149,229,118,125,77,10,31,81,212,255,15,84,61,108,135,207,63,219,203,180,46,254,238,214,241,244,221,65,237,161,137,23,81,77,215,216,112,140,128,187,75,169,106,186,198,148,25,82,183,193,133,183,101,106,171,233,26,151,142,187,217,167,221,49,62,191,0,138,129,16,15,219,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55a55d6a-8498-40c0-bdfe-95136f257586"),
				ContainerUId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,207,111,218,48,20,254,87,144,219,35,70,137,109,236,56,183,169,221,1,169,221,208,218,245,82,56,60,219,207,107,164,144,32,39,108,98,40,255,251,140,129,1,221,118,153,15,137,242,156,239,199,243,251,188,35,183,253,118,141,164,36,207,24,2,116,173,239,39,119,109,192,201,60,180,22,187,110,242,208,90,168,171,159,96,106,156,67,128,21,246,24,94,160,222,96,247,80,117,253,120,116,13,35,99,114,251,61,237,146,242,117,71,102,61,174,190,206,92,100,183,44,183,86,154,156,50,212,72,133,68,70,11,239,21,85,210,89,159,123,141,140,155,8,182,109,189,89,53,143,216,195,28,250,55,82,238,72,98,139,4,202,122,239,5,47,168,70,44,168,96,42,18,228,210,209,169,67,163,92,102,181,227,146,12,99,210,217,55,92,65,18,61,131,69,14,190,208,168,169,154,102,134,10,52,134,22,22,44,245,158,107,35,69,33,114,180,123,240,241,255,51,240,245,230,117,214,125,254,209,96,120,74,188,165,135,186,195,229,36,86,223,21,62,214,184,194,166,47,119,66,76,189,44,98,127,198,101,156,10,37,36,5,169,20,229,76,25,131,74,49,47,237,16,1,191,79,179,220,57,105,57,184,34,218,227,90,81,225,92,132,48,166,169,159,50,244,96,184,19,220,12,203,155,229,222,162,171,186,117,13,219,151,63,157,126,112,110,212,174,215,109,232,55,77,213,111,39,119,1,161,71,55,10,104,219,224,70,51,119,32,88,95,77,241,146,98,183,56,132,97,65,202,197,191,226,112,124,31,154,191,14,196,251,44,44,200,120,65,158,218,77,176,123,70,190,255,56,205,38,41,100,199,69,255,242,56,173,3,71,130,61,66,3,223,48,124,138,138,9,158,182,238,161,135,36,254,28,125,159,136,13,211,211,76,229,158,42,4,29,167,45,99,84,92,14,84,231,218,120,174,56,243,158,37,244,23,244,24,176,177,120,109,12,80,72,111,10,69,109,198,44,21,16,243,6,142,231,20,52,227,214,57,173,133,245,9,159,148,207,102,78,177,141,149,102,83,215,73,160,75,253,239,239,193,209,248,113,231,254,98,140,23,12,173,171,124,133,110,214,252,207,81,13,100,24,150,195,47,156,153,101,0,210,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeAddDataContactToOpportunityParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("77b402b4-36ef-4afe-85ca-fbbfe0540b9f"),
				ContainerUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"fa274f3d-57a3-44ee-b644-d93441a31de2",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("611d2131-f988-40c6-a266-7ac3720e4624"),
				ContainerUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f87e7355-4618-4675-ac15-23509e6ffedd"),
				ContainerUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordAddMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			recordAddModeParameter.SourceValue = new ProcessSchemaParameterValue(recordAddModeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("20e936ce-6092-493c-b50c-aaf70285c26b"),
				ContainerUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"FilterEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ccc51ea5-dba9-4d02-9514-ddb4ac2fa55c"),
				ContainerUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordDefValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,86,77,111,219,70,16,253,43,2,147,163,70,32,247,123,117,43,156,20,48,144,180,110,146,230,98,251,48,187,51,155,8,160,73,131,164,90,184,130,254,123,71,180,85,127,180,117,131,162,135,180,40,15,164,184,171,247,102,118,231,189,89,238,170,151,211,205,53,87,235,234,3,15,3,142,125,153,86,39,253,192,171,179,161,207,60,142,171,55,125,198,118,243,11,166,150,207,112,192,43,158,120,248,136,237,150,199,55,155,113,90,46,30,195,170,101,245,242,167,121,182,90,159,239,170,211,137,175,126,60,37,97,71,23,84,200,193,65,180,81,131,193,18,33,56,42,192,218,103,195,38,50,251,34,224,220,183,219,171,238,45,79,120,134,211,231,106,189,171,102,54,33,176,198,166,198,16,66,70,97,49,232,21,160,13,5,44,97,209,88,167,84,168,174,246,203,106,204,159,249,10,231,160,247,224,130,202,155,162,9,172,71,137,110,152,33,57,99,128,162,54,166,65,221,16,171,3,248,238,255,247,192,243,23,231,167,227,247,63,119,60,188,159,121,215,5,219,145,47,87,50,250,100,224,117,203,87,220,77,235,157,49,182,184,192,10,18,213,18,203,27,7,232,188,7,173,124,74,236,189,42,46,239,5,240,219,110,174,119,228,178,70,10,17,188,142,30,12,145,64,148,138,80,172,226,130,73,147,209,105,127,249,226,242,144,34,109,198,235,22,111,62,254,62,211,111,136,22,253,245,117,63,76,219,110,51,221,172,78,6,198,137,105,49,112,238,7,90,156,210,45,193,245,163,42,62,164,216,93,220,138,225,162,90,95,252,153,28,238,158,183,139,127,44,136,167,90,184,168,150,23,213,251,126,59,228,3,163,62,188,28,107,51,71,168,239,46,248,131,219,241,186,229,152,97,111,177,195,79,60,124,39,17,103,248,60,245,10,39,156,131,127,144,188,143,196,73,69,91,251,166,128,103,140,96,216,41,8,212,32,196,38,166,162,189,86,165,168,25,253,142,11,15,220,101,126,156,24,178,113,37,5,15,185,86,89,164,198,1,144,116,3,24,149,206,68,49,154,92,102,252,28,249,62,153,163,108,101,164,219,182,237,28,96,156,215,127,240,193,93,226,119,51,175,30,148,241,1,67,79,155,178,97,58,237,254,206,86,237,171,253,126,249,208,116,77,96,155,88,103,32,173,18,24,237,29,164,130,65,100,143,162,196,220,136,232,210,179,166,67,167,2,105,68,240,209,53,96,162,209,16,130,75,208,104,103,93,67,148,115,116,95,133,233,10,27,10,129,107,48,206,74,201,66,58,84,59,101,224,72,76,210,57,116,182,245,83,211,73,18,186,72,67,97,85,91,129,52,25,164,69,17,36,17,140,175,93,227,27,85,14,144,215,221,36,110,58,153,247,104,189,67,50,177,38,27,160,182,6,197,170,193,66,84,98,113,162,96,156,227,164,99,208,127,109,213,119,140,180,104,15,55,18,1,175,190,221,12,227,180,216,72,221,22,125,17,191,142,219,118,218,116,159,22,82,152,150,243,180,233,187,213,15,91,233,194,7,105,44,112,148,241,110,194,60,253,239,231,47,243,115,227,196,4,206,54,16,138,180,101,211,88,57,123,136,106,192,80,75,107,117,65,19,233,127,133,159,165,9,149,44,203,5,170,141,216,49,39,130,88,55,6,116,99,115,225,108,92,46,244,252,33,154,107,151,20,50,248,236,13,152,131,250,67,180,114,84,201,193,19,162,86,86,185,240,207,251,121,26,228,241,140,31,142,243,255,125,37,199,58,57,155,138,116,143,82,164,77,53,82,197,224,125,4,101,84,45,63,228,171,168,246,207,41,249,139,19,251,10,149,124,185,255,21,202,193,77,110,108,10,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("77fca69f-0da0-430c-a3da-c7ed23ab5394"),
				ContainerUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeAddDataOpportunityParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("36768833-e793-4cd5-8c7c-6fa9657737df"),
				ContainerUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1aa11035-b136-470f-8cb3-1f4060a6f342"),
				ContainerUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("05d8eeec-d375-46f9-ae98-2ee983ccb91d"),
				ContainerUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordAddMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			recordAddModeParameter.SourceValue = new ProcessSchemaParameterValue(recordAddModeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("8513b4b5-7a5d-4bac-b336-7ffa764d5510"),
				ContainerUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"FilterEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("488491cb-2475-44b0-9985-39cc11395c42"),
				ContainerUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordDefValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,153,91,111,91,71,14,128,255,138,112,218,135,22,53,189,115,225,220,12,244,97,55,233,2,1,122,9,154,108,95,226,60,112,134,156,84,128,44,25,210,113,23,89,195,255,125,57,178,211,196,233,86,45,82,4,77,170,213,195,145,117,206,225,112,134,228,55,36,199,215,211,167,243,203,75,153,206,166,167,178,221,210,110,211,231,211,7,155,173,156,62,222,110,154,236,118,167,95,111,26,173,150,255,161,186,146,199,180,165,11,153,101,251,3,173,174,100,247,245,114,55,159,44,238,139,77,39,211,167,63,237,159,78,103,207,174,167,71,179,92,252,235,17,235,232,84,197,9,101,132,230,67,0,204,45,64,118,214,128,23,177,25,209,35,178,83,225,182,89,93,93,172,191,145,153,30,211,252,227,116,118,61,237,71,211,1,176,150,32,190,119,232,28,28,32,137,133,106,40,128,107,193,26,189,111,3,165,233,230,100,218,181,31,229,130,246,74,95,11,147,96,236,53,39,104,198,181,33,156,129,216,91,160,226,124,99,46,5,91,31,194,119,239,191,22,124,246,201,179,71,187,239,254,189,150,237,147,253,184,103,157,86,59,121,126,170,119,223,186,241,179,113,206,174,61,58,146,22,34,100,31,10,96,11,85,215,26,43,20,201,152,75,231,72,88,111,158,127,242,124,104,228,229,238,114,69,47,127,248,165,226,191,183,182,185,90,207,183,175,93,222,51,253,155,47,94,159,223,122,240,124,58,59,255,53,31,222,125,223,206,248,190,23,223,118,224,249,116,114,62,61,217,92,109,219,24,209,143,31,175,12,186,215,96,238,62,240,63,46,175,62,183,99,236,197,190,161,53,189,144,237,183,170,113,47,190,127,244,144,102,218,43,127,170,243,126,53,112,117,37,152,100,59,36,33,53,154,68,7,153,45,65,177,165,118,159,188,235,221,237,165,191,151,46,91,89,55,185,63,49,23,56,53,75,21,44,139,1,12,70,227,3,141,3,227,196,136,198,134,227,120,187,184,189,230,215,147,121,21,107,122,103,125,181,90,237,21,236,246,235,31,193,123,55,241,187,39,15,223,112,214,27,35,108,120,217,151,194,143,214,239,98,170,155,233,230,230,228,77,82,48,86,79,6,51,232,106,72,99,85,153,161,24,25,10,181,110,123,202,197,115,59,72,74,42,38,68,223,6,41,22,1,57,48,80,232,12,53,10,115,181,134,35,251,15,132,148,234,106,64,9,30,130,55,234,244,24,12,80,139,9,106,38,76,38,176,115,21,7,41,139,197,23,139,243,233,111,231,147,126,127,246,78,154,140,171,22,99,97,72,142,24,176,168,58,74,106,163,88,209,214,84,24,45,165,161,233,11,251,249,233,211,205,147,121,187,92,191,248,236,243,195,132,142,224,88,108,250,162,173,150,50,64,125,107,150,15,246,183,191,187,188,220,108,231,171,245,114,126,249,224,150,231,95,170,248,235,211,29,26,249,208,117,191,39,171,96,226,240,49,149,72,224,179,103,138,212,53,182,219,33,186,127,247,196,62,116,186,67,77,13,185,84,224,193,52,146,238,117,57,91,253,89,76,115,26,251,213,97,62,156,7,61,230,108,138,64,236,70,19,169,139,77,7,208,125,174,132,220,187,20,83,109,138,127,38,221,95,173,228,66,195,254,236,186,11,114,206,99,47,142,65,117,229,58,246,242,218,64,10,11,99,168,190,5,115,115,31,82,70,180,190,51,129,184,177,182,108,117,109,46,235,206,165,233,32,153,104,147,117,125,136,124,181,158,247,56,13,27,157,93,231,236,106,183,156,192,179,166,15,116,38,67,54,141,160,246,98,125,203,140,125,72,253,86,186,253,94,136,23,171,113,97,13,224,211,127,46,183,187,121,177,84,191,13,194,183,178,187,90,205,202,235,66,29,179,146,54,47,55,235,211,127,92,241,11,57,154,252,28,90,203,38,26,134,200,138,49,166,228,65,107,25,117,80,179,154,90,123,12,133,226,81,16,92,130,13,209,186,65,112,213,156,85,141,135,18,145,161,199,106,52,12,75,242,233,112,37,235,137,52,195,59,7,202,65,4,77,60,17,74,174,85,135,106,169,145,51,181,154,63,149,224,119,200,154,139,47,191,92,152,195,124,253,90,54,252,89,244,175,143,144,110,206,49,212,158,193,116,5,7,45,90,200,41,21,112,99,207,74,137,122,49,233,56,16,242,6,123,65,4,215,171,86,3,133,43,140,238,14,108,119,85,11,132,18,52,174,14,34,20,51,134,224,73,139,136,160,193,169,68,16,80,199,10,189,165,40,165,139,143,5,143,43,9,134,102,58,165,18,181,41,206,94,99,203,69,173,164,165,64,235,204,205,169,177,10,153,247,145,4,159,208,74,118,139,205,48,202,177,100,194,63,218,169,218,88,53,64,131,194,223,197,169,171,130,150,128,204,90,26,103,227,25,163,86,196,236,63,10,140,131,235,154,174,74,209,42,126,116,170,174,120,32,223,12,68,205,10,88,123,115,76,230,48,198,213,112,203,218,159,250,84,179,90,162,141,202,173,16,68,241,134,153,180,221,245,238,216,48,142,69,31,35,68,167,235,193,160,197,69,142,181,131,86,10,177,105,96,68,207,225,125,96,252,173,8,47,6,156,255,135,248,247,65,44,134,171,84,45,226,176,120,189,136,136,242,219,29,144,195,68,161,55,201,57,127,20,16,247,68,88,179,98,84,155,130,136,77,183,164,236,21,40,150,110,197,70,12,142,211,65,136,91,238,129,163,182,95,218,203,150,177,11,4,229,112,160,210,123,148,140,38,134,208,143,11,98,108,158,98,215,166,190,20,214,92,92,169,107,171,20,16,76,138,46,33,155,152,66,123,31,16,63,148,182,220,233,31,139,121,121,33,171,229,250,104,96,102,103,165,72,71,141,162,136,128,198,58,168,46,71,232,100,41,171,147,152,16,143,162,176,214,157,167,183,90,16,58,202,56,59,142,13,138,233,2,5,173,165,98,25,179,233,7,97,182,161,155,110,138,5,137,113,156,165,104,101,158,77,210,194,26,155,118,128,209,107,162,62,178,211,37,66,67,17,71,131,97,134,73,141,104,183,142,41,142,206,163,89,238,181,22,255,94,78,151,110,11,107,94,254,180,71,250,88,72,254,163,105,57,176,118,134,177,34,216,48,98,131,37,104,67,164,23,210,70,211,244,152,138,246,73,31,5,201,106,134,42,186,24,232,156,180,190,96,70,168,209,49,164,156,162,205,62,116,169,135,255,11,20,145,76,168,26,183,62,24,205,235,172,69,100,237,156,161,215,144,138,214,231,221,23,249,64,78,153,106,12,94,235,140,160,125,4,106,209,139,206,104,190,244,6,36,213,214,74,38,155,66,252,109,196,30,108,214,51,181,163,57,143,61,230,46,244,249,205,127,1,0,73,221,101,183,32,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6c3ad89-7397-4dd6-a229-f52efab3d43b"),
				ContainerUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeReadDataCountOpportunityByAccountParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("95d638cd-1142-40c7-b944-f9e7fdc8b952"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,203,106,221,48,16,253,23,45,186,178,138,172,135,109,185,171,114,185,133,64,73,3,125,80,8,151,48,150,70,137,168,95,177,101,218,96,252,239,149,175,175,219,144,69,41,221,21,188,176,70,62,103,206,57,51,158,239,252,248,206,215,1,135,210,65,61,98,50,93,217,146,228,40,152,171,148,162,185,213,5,149,70,56,90,9,204,104,206,192,72,147,170,194,106,32,73,11,13,150,100,67,31,173,15,36,241,1,155,177,188,157,127,147,134,97,194,228,206,157,15,31,205,3,54,240,121,109,0,40,51,87,21,57,53,140,27,42,1,11,10,86,164,20,52,23,198,90,173,165,113,100,211,82,137,194,10,6,21,205,114,107,169,204,101,69,11,192,156,102,90,88,6,232,42,233,10,146,212,232,194,241,71,63,224,56,250,174,45,103,252,245,254,233,169,143,42,183,222,135,174,158,154,150,36,13,6,184,129,240,80,18,89,105,133,194,57,234,172,226,171,144,148,86,12,20,229,70,165,44,214,83,5,57,73,12,244,97,165,37,111,141,233,166,54,58,29,208,225,128,173,193,103,166,184,178,185,73,163,210,212,34,163,82,177,200,37,25,167,140,35,195,200,195,109,134,36,177,16,224,11,212,19,158,133,205,126,181,200,181,98,121,234,104,142,160,169,196,140,211,194,166,64,117,170,43,39,114,193,157,227,123,220,239,187,238,219,212,199,168,199,235,169,193,193,155,203,220,48,14,160,27,202,217,116,109,24,186,122,37,191,126,6,216,230,115,185,252,186,101,82,159,111,86,32,89,146,105,196,67,237,177,13,199,214,116,214,183,247,231,209,45,75,196,52,61,12,126,220,147,60,62,78,80,199,0,252,253,195,31,19,63,76,99,232,154,255,205,111,18,189,70,154,184,173,103,205,235,50,91,63,246,53,60,157,207,37,121,245,56,117,225,205,101,15,182,3,121,1,218,63,18,146,3,26,149,209,66,168,104,211,168,184,185,60,171,168,198,66,22,218,217,12,100,117,97,88,146,127,111,115,123,53,126,248,222,238,191,215,22,207,233,117,172,190,40,220,236,232,114,254,27,101,203,105,215,118,90,226,243,19,99,190,182,24,41,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("baccf23b-370e-4e0b-b657-7bfa21cdd970"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("daf54a7f-8a62-4589-9c9c-c261921a13fd"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cf300c28-9b38-48ff-a8d5-ecb1fba12e64"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc3b5658-a8e6-4cab-b27b-819a3025ed71"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("693953ab-8637-4183-87d1-ee4988a862f8"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,1,0,242,67,189,42,2,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5e608114-da8f-4197-a7c1-9abde0e48dca"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("a81f55d7-8bc9-4327-b691-9ede33487823"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a83ce913-3e58-4db8-b563-712f4f1f1d4f"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f23fe366-df2c-4531-b2ed-ebdf444d985e"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("236f9f63-489b-4485-b92a-f5a499fe453e"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5a384c94-4c0e-46d6-ab9c-2f2f6cf1de5a"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("199f3817-15db-4ed6-b57f-350fc7b100b3"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d3ab4b8a-b637-47a5-bc47-da539d6683f1"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("156fda51-7aad-4289-bdf5-909adb3f882f"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("84c58779-0b9a-4c9a-92d9-5ba3900861f5"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d2b28272-8058-40a5-b869-30703026b4b7"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("86bf89f7-55de-4505-b0fc-9974a9da0381"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("92537119-d563-41e8-905c-09def63277af"),
				ContainerUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadDataAccountParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("760c8144-4547-4f2e-9058-d28c8497d3e6"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,235,211,146,123,42,203,182,236,37,13,52,45,133,100,9,99,105,156,21,248,99,99,203,52,193,236,127,175,188,206,182,16,72,233,181,224,131,102,164,247,230,189,199,120,190,15,227,167,208,68,28,202,26,154,17,179,105,231,75,98,149,84,166,146,72,121,141,53,149,133,112,20,184,179,148,41,47,152,226,76,213,26,72,214,65,139,37,89,209,91,31,34,201,66,196,118,44,111,231,63,164,113,152,48,187,175,207,197,87,119,192,22,190,45,3,184,242,133,99,80,81,230,49,167,82,229,140,86,50,231,52,231,152,163,130,130,123,141,100,213,34,180,17,58,207,145,74,105,44,149,73,2,181,53,247,84,231,90,87,22,173,169,61,35,89,131,117,220,62,29,7,28,199,208,119,229,140,191,207,55,207,199,164,114,157,189,233,155,169,237,72,214,98,132,107,136,135,146,64,154,39,149,3,234,164,85,84,214,88,80,16,214,83,1,85,193,11,131,76,179,130,100,14,142,113,161,37,59,79,50,15,17,190,67,51,225,153,121,14,139,29,145,51,163,116,194,178,20,149,20,60,167,70,155,130,214,94,215,22,133,182,182,242,151,188,62,79,33,157,195,120,53,181,56,4,247,18,59,166,252,250,161,156,93,223,197,161,111,22,234,171,243,243,27,124,138,107,184,47,87,63,86,67,49,245,23,16,57,101,211,136,155,38,96,23,183,157,235,125,232,30,86,206,211,41,65,218,35,12,97,188,164,176,125,156,160,33,217,16,30,14,127,77,107,51,141,177,111,255,35,171,89,178,153,56,210,146,157,229,46,59,232,195,120,108,224,249,92,151,228,221,227,212,199,15,31,157,235,167,216,173,5,121,5,42,201,29,17,146,3,58,165,169,17,42,45,155,83,21,53,92,87,212,162,73,219,151,60,130,172,238,72,18,242,54,125,23,223,166,191,221,141,95,126,118,151,63,97,213,190,127,159,186,175,26,215,23,100,57,255,139,162,211,126,209,180,63,165,239,23,77,248,193,226,208,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("29d241ea-e7c1-468b-93dd-4fabc9692e05"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("99fe1d4f-11a3-4a99-a403-3f8329c46387"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("23c9ab4d-c03e-4823-a89d-b8157e04f637"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0481537e-1347-4a84-bc95-3f25b63bd2aa"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("98fe3323-90ae-4f77-9698-90cb6049bb21"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ab5fefa4-6698-4258-940b-0a2c6dd14a31"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,248,134,94,83,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("d3b28169-5be2-4f9c-97c0-eef28ed4f516"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3bc1a643-8bc8-4d8c-96c9-19e0df86a151"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("801aa1e5-b4cb-4d94-abad-0dfa07dffec6"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f75452e6-8240-4d69-825e-90cd8847e099"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("36ec811c-adc6-4e15-a536-d4bbcf966b71"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("affd0b02-dbe8-4101-aeb3-b62e33160dd3"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("591a5668-a8e2-41dc-a509-888da5a63e1a"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("9cc3666e-b170-44af-a775-f6810f7e7250"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("87a74108-882e-4315-a51f-706bae061c72"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e5436907-184b-4bae-b060-99c5407f2a22"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b8a1a3ac-537b-4e86-b7e6-dbbd319022a6"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1fad9e13-e56a-4fef-963e-9a2d69037ec1"),
				ContainerUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadDataContactParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f3d16d53-5568-4d10-85f2-ecee93297c69"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,202,162,67,79,214,34,89,178,44,185,199,176,41,185,164,233,39,133,36,4,89,51,74,4,254,216,216,50,77,48,251,223,43,175,179,45,228,80,114,43,5,99,36,217,243,206,188,143,102,230,187,48,158,135,38,226,80,121,219,140,152,77,23,80,17,174,153,118,166,246,20,77,201,168,100,165,162,218,114,160,194,91,93,26,155,3,175,57,201,58,219,98,69,214,232,29,132,72,178,16,177,29,171,235,249,143,104,28,38,204,238,252,113,243,197,61,96,107,191,29,19,168,26,133,42,56,213,30,115,42,121,97,168,6,96,212,106,38,64,42,45,0,4,89,107,241,162,102,69,109,12,181,202,104,42,85,13,84,171,92,80,86,50,239,185,145,76,25,70,178,6,125,220,61,237,7,28,199,208,119,213,140,191,215,95,159,247,169,202,53,247,89,223,76,109,71,178,22,163,189,178,241,161,34,22,25,202,194,89,234,164,41,168,244,88,82,43,76,114,106,235,50,47,53,114,197,75,146,57,187,143,139,44,185,0,146,129,141,246,187,109,38,60,42,207,33,213,152,11,198,117,161,82,44,23,142,74,145,179,84,163,46,169,7,229,77,50,106,76,13,39,94,31,166,144,214,97,188,156,90,28,130,123,193,142,137,95,63,84,179,235,187,56,244,205,34,125,121,252,253,43,62,197,21,238,203,167,31,171,161,152,206,151,32,114,200,166,17,207,154,128,93,220,117,174,135,208,221,175,154,135,67,10,105,247,118,8,227,137,194,238,113,178,13,201,134,112,255,240,87,90,103,211,24,251,246,63,178,154,37,155,73,35,53,217,177,220,165,7,33,140,251,198,62,31,247,21,121,247,56,245,241,253,103,180,176,105,150,215,226,108,123,30,134,49,110,150,166,221,244,126,147,8,76,77,76,154,27,215,55,13,186,229,198,183,159,18,176,224,3,194,198,142,155,165,44,235,226,170,69,94,229,172,200,13,241,40,65,107,76,35,163,138,4,71,215,150,26,94,187,52,70,128,32,139,90,184,130,109,65,74,46,60,88,138,57,75,45,167,185,163,58,215,64,107,137,170,100,169,223,120,238,183,22,164,97,80,104,202,10,105,105,82,45,168,201,165,162,0,90,42,133,181,48,90,220,144,68,228,159,248,188,190,24,63,254,236,78,19,189,222,193,237,54,157,190,58,216,53,216,166,203,170,230,183,128,57,164,128,171,83,170,106,126,11,166,37,100,215,197,16,159,215,201,174,230,183,112,59,220,46,228,110,15,233,249,5,19,114,238,11,255,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6d0e3dc9-842e-46e7-8ec6-d71896474631"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("01b2e31d-1d81-4b50-bc28-b8d8b4b60976"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2fc79c56-2808-4e39-a3da-7b92d8218134"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4d312b88-dd01-43fa-a2cf-92d118789fc2"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("705dbcc7-95ff-47ba-a0de-e637092435f6"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0dfc2b7f-d9f0-4923-87e3-ce36e9fb5442"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("daa09ed7-2a7d-4450-a30a-dd8ac16c0a06"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1c0aed0e-7343-442c-970e-e1e5c5a4ede4"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("957d85e9-6cea-4ba9-b671-6ff1d0faecee"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("96aba7e1-c060-491b-a648-67b8fed13557"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0afa84c8-ac3e-4b20-8ff2-a08e0f96f627"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("13f4af03-0d2b-4788-9a8d-f585fb5cfd13"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2c12c50b-6308-45df-becd-68952bb8177e"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("adb4ba05-85d5-4736-a24e-94b25bcf8904"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("04d717aa-6962-480f-b56d-1be4aba03d1c"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("67a25d02-1e6e-46fc-bb0a-c9e2f19819ab"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("492f15c3-b34b-405e-8203-5e3baad4a84b"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("df1ebb1b-b68f-49a6-b9cd-88c2611a9fc6"),
				ContainerUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializePresentationTaskCreationParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("a81724cd-f82e-401e-bdc4-1f4968318e58"),
				ContainerUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"c449d832-a4cc-4b01-b9d5-8a12c42a9f89",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dafab651-4b04-4a39-9ffa-a14a50789205"),
				ContainerUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ff84282e-f6d0-4910-a414-28117fa48082"),
				ContainerUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordAddMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			recordAddModeParameter.SourceValue = new ProcessSchemaParameterValue(recordAddModeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("5ad22c54-905a-451d-b9fd-76ff73069b58"),
				ContainerUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"FilterEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5cd8ef8c-6a8f-48a6-8cbb-13e448e5e606"),
				ContainerUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordDefValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,90,93,111,27,199,21,253,43,4,157,135,22,208,16,243,253,161,55,195,73,81,1,118,235,58,110,94,44,63,220,153,123,199,33,66,145,2,185,74,225,10,250,239,61,187,146,106,89,77,25,53,137,10,43,18,31,72,106,151,119,102,247,222,115,230,156,59,171,243,249,87,195,199,83,153,31,206,223,202,118,75,187,77,31,22,47,54,91,89,188,222,110,154,236,118,139,151,155,70,171,229,63,169,174,228,53,109,233,68,6,217,126,71,171,51,217,189,92,238,134,131,217,231,97,243,131,249,87,63,78,103,231,135,239,206,231,71,131,156,252,253,136,49,186,79,153,170,207,65,113,102,175,188,45,90,101,210,248,214,181,171,201,91,9,28,16,220,54,171,179,147,245,43,25,232,53,13,223,207,15,207,231,211,104,227,0,220,186,38,103,84,234,156,148,231,74,138,52,6,16,111,92,53,41,56,239,204,252,226,96,190,107,223,203,9,77,147,126,10,110,222,23,206,206,42,242,173,41,95,181,81,181,112,192,37,24,219,188,165,210,115,25,131,175,126,255,41,240,120,254,98,179,230,179,54,204,78,183,178,147,245,64,195,114,179,62,158,143,63,230,229,238,116,69,31,191,251,95,98,78,63,75,225,205,168,243,227,203,74,28,207,15,143,255,91,45,174,62,191,157,110,241,243,106,220,46,196,241,252,224,120,254,237,230,108,219,198,17,221,248,199,117,98,166,25,244,213,75,253,196,219,245,235,114,140,41,236,21,173,233,131,108,255,130,25,167,240,233,212,215,52,208,52,249,91,92,247,245,192,161,145,11,221,104,69,6,89,246,45,38,69,37,146,114,217,49,69,234,212,122,155,162,223,72,151,173,172,155,252,194,11,155,102,254,116,49,215,152,193,145,245,217,106,53,77,176,155,238,127,4,225,213,133,95,157,249,250,70,229,110,140,176,225,101,95,10,31,173,127,201,21,93,204,47,46,14,110,34,190,122,171,133,98,87,209,48,33,17,129,85,77,186,40,171,35,55,202,41,38,83,246,35,62,102,207,30,56,247,53,86,32,222,144,42,174,87,149,180,52,75,93,56,164,254,219,35,254,221,179,119,71,187,191,254,99,45,219,203,44,28,118,90,237,228,253,2,71,111,29,248,102,37,39,64,247,225,185,247,161,199,44,86,85,214,78,249,228,163,162,152,146,114,54,213,42,41,217,30,219,5,2,254,141,216,195,115,142,205,17,231,162,146,43,35,155,25,33,214,22,213,131,149,78,213,177,119,245,226,253,179,247,251,120,246,238,217,115,230,217,230,244,116,179,29,206,214,203,225,227,226,141,180,205,150,103,71,124,25,248,251,39,91,181,37,232,100,186,74,66,69,121,137,86,229,9,39,166,212,238,146,179,189,219,125,100,35,241,177,215,156,84,211,22,40,33,201,138,24,107,44,21,235,26,115,41,190,245,7,65,54,93,156,182,218,26,101,98,176,202,235,92,85,73,46,43,83,186,113,197,102,118,178,159,108,193,23,211,156,235,74,138,5,32,65,80,69,33,21,197,62,27,208,56,128,191,241,62,200,246,114,179,249,225,236,116,145,66,245,236,74,85,33,240,56,2,248,128,66,106,229,186,47,20,50,151,216,210,162,87,209,212,112,30,75,168,86,220,13,166,209,186,35,55,134,163,150,226,114,139,63,71,153,171,249,158,183,97,249,35,40,51,27,89,176,120,75,187,31,158,40,115,55,202,220,165,82,15,130,50,214,37,27,1,123,5,174,51,18,81,139,162,74,94,89,118,49,183,210,56,148,180,151,50,45,27,223,41,25,37,218,64,159,156,13,138,90,102,164,195,147,45,78,216,184,124,143,148,41,209,136,213,25,194,97,236,40,143,160,109,213,37,128,252,213,72,244,80,152,166,23,222,182,228,27,110,50,100,137,151,148,41,9,87,251,107,40,243,130,6,249,176,217,126,92,188,18,25,150,235,15,79,204,185,27,115,238,82,176,7,193,156,108,113,31,169,144,178,217,137,242,209,67,108,96,89,84,55,176,62,5,82,81,184,239,101,14,18,197,210,130,81,57,7,128,223,102,82,128,39,222,116,211,205,248,106,188,243,191,61,115,134,45,62,246,32,253,250,252,239,31,201,69,215,24,106,207,74,247,142,20,26,143,74,36,136,189,133,101,199,23,234,69,167,71,209,163,36,71,186,90,114,202,5,241,163,13,23,56,119,88,159,234,200,230,88,165,117,110,123,145,60,98,142,2,140,86,52,21,221,30,242,166,74,103,88,18,83,98,49,17,62,158,249,139,232,81,186,120,206,89,52,232,58,82,46,215,113,221,170,13,118,143,133,125,168,174,5,125,187,71,241,222,184,142,222,13,108,199,42,149,77,83,25,78,82,85,44,125,73,71,147,140,237,99,200,55,235,1,178,240,98,202,209,225,185,244,6,37,156,90,95,135,214,45,160,8,185,67,86,13,39,221,98,237,54,246,242,243,157,205,27,33,158,173,198,55,6,128,23,127,90,110,119,195,108,137,186,205,54,125,182,149,221,217,106,84,158,25,10,179,146,54,110,47,92,139,209,248,123,153,209,154,103,195,242,68,30,139,52,177,53,82,164,123,244,49,17,56,214,6,189,40,0,172,58,25,202,40,20,147,247,143,130,208,197,91,147,99,198,202,70,4,141,45,104,237,114,41,78,89,27,140,19,232,174,196,186,127,211,65,195,18,9,68,222,132,138,70,42,58,13,87,88,163,210,45,57,172,140,21,226,86,159,8,253,83,132,94,60,103,254,51,106,191,251,131,249,227,255,137,220,183,167,124,34,250,163,33,186,131,9,239,102,76,132,245,73,249,4,24,19,184,167,98,64,31,106,122,242,189,237,223,79,239,58,185,216,33,253,169,48,176,157,34,136,46,17,221,96,132,51,141,88,51,48,204,23,65,244,228,92,135,19,49,138,67,159,218,204,162,106,71,51,87,163,35,113,186,104,9,245,54,209,59,161,139,29,183,19,219,232,239,252,136,146,30,88,161,49,45,149,169,56,38,249,79,162,199,236,67,112,148,20,133,130,134,24,201,81,212,225,237,123,75,81,74,23,23,139,191,163,114,223,216,148,188,51,199,167,172,60,22,193,254,181,189,164,129,57,117,113,236,160,186,64,166,76,40,136,103,64,56,107,120,206,152,29,179,123,16,60,174,172,13,181,10,153,6,252,0,85,231,33,216,186,168,208,116,213,58,80,175,86,239,229,113,237,68,165,165,174,154,139,25,3,104,100,210,77,143,95,82,140,186,99,145,240,247,178,11,243,229,10,54,49,250,16,14,240,64,193,67,176,57,7,85,172,143,138,57,251,24,165,186,146,221,125,56,240,191,157,209,106,130,198,140,118,56,190,30,168,13,79,124,126,100,124,118,197,21,157,51,252,115,173,16,17,55,110,56,22,174,42,89,207,181,64,179,188,219,191,55,196,208,26,111,144,63,239,2,22,4,3,207,89,27,150,6,49,38,115,15,146,131,149,71,198,103,209,226,67,35,213,252,184,91,216,5,10,237,160,208,142,106,178,41,139,65,224,125,240,249,233,49,226,93,217,235,13,1,88,82,84,10,186,142,143,18,170,202,141,154,234,221,1,242,62,123,35,237,65,176,87,72,68,58,40,23,11,58,60,223,70,233,200,22,198,81,114,182,132,150,56,217,253,143,17,123,213,28,59,12,181,73,4,87,61,254,135,11,194,2,248,136,60,184,22,89,63,54,53,134,13,247,133,196,3,12,198,33,170,35,165,163,23,247,129,18,252,118,22,10,225,222,213,152,90,219,156,173,159,212,248,142,124,182,129,83,51,84,149,225,17,33,227,230,71,29,141,165,182,88,138,81,55,11,145,250,82,249,252,254,226,95,221,42,32,238,211,38,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3b349266-cabe-4ac9-9bab-90e5a99b9312"),
				ContainerUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeReadOppoortunityData2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e113eec9-67b0-4d53-8bd1-162890643787"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,172,98,89,178,108,57,199,101,91,246,146,6,154,150,66,178,132,103,233,41,43,240,87,108,137,102,49,251,223,43,175,179,41,228,80,10,61,5,116,144,158,52,243,102,134,167,249,193,77,159,93,227,113,172,44,52,19,38,97,103,42,130,185,54,117,102,129,178,186,6,42,148,204,105,201,184,160,220,0,178,90,151,92,88,65,146,14,90,172,200,138,222,26,231,73,226,60,182,83,117,55,255,33,245,99,192,228,193,158,15,223,244,1,91,248,190,52,0,20,210,214,101,65,117,154,105,42,0,75,10,134,51,10,42,227,218,24,165,132,182,100,213,34,139,210,160,205,82,106,133,42,168,176,82,82,197,153,162,170,72,115,89,34,22,41,211,36,105,208,250,237,243,48,226,52,185,190,171,102,124,221,223,30,135,168,114,237,189,233,155,208,118,36,105,209,195,13,248,195,34,36,69,145,107,160,90,168,60,178,99,65,129,43,67,57,212,69,86,148,200,36,43,72,162,97,240,11,45,217,25,146,24,240,240,3,154,128,103,230,217,69,141,25,79,89,153,203,136,101,60,218,225,81,109,41,163,59,107,164,85,200,165,82,181,185,228,245,37,184,184,119,211,117,104,113,116,250,37,118,140,249,245,99,53,235,190,243,99,223,44,212,215,231,231,183,248,236,215,112,95,174,126,174,134,124,172,47,32,114,74,194,132,155,198,97,231,183,157,238,141,235,30,87,206,211,41,66,218,1,70,55,93,82,216,62,5,104,72,50,186,199,195,95,211,218,132,201,247,237,59,178,154,68,155,145,35,14,217,89,238,50,131,198,77,67,3,199,243,185,34,31,159,66,239,175,54,97,28,35,248,67,63,12,253,232,67,231,252,113,189,32,111,8,42,114,79,192,198,233,2,133,52,69,198,168,200,36,82,40,139,148,102,218,90,206,77,154,218,82,220,147,40,234,255,91,221,237,166,175,191,186,203,15,89,61,237,63,197,234,155,194,205,5,89,205,255,162,238,180,95,244,237,79,113,253,6,219,198,33,213,232,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("da79942f-8a30-4c0f-855d-60c2d9a24472"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("314efddf-5361-477a-9ff8-a9cb5fab8b62"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("06b753c1-0d8b-436b-8acc-ddf113106da6"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ad17e1dd-e357-4be2-be8e-37597e384cc1"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9cb37f59-15e3-4146-8d7f-c8726fcb37d4"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6f41753d-91d4-4093-8fba-b44d89023e4c"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("dfa2d329-fcfc-4412-bf5d-d4a9bda93dae"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("820e9918-37b0-4611-aaf2-8d870ec7da7d"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cb9c1fe1-8c58-4f12-89f1-7aae2156df27"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("813a52d4-0e07-46b4-a63f-229d35aa56c6"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a3dabfcb-04f6-4cea-92b9-d9ea7aee59b1"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fcd7d381-1523-402c-b1b8-ed682284f793"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e2a2ccd2-d26f-4f42-ae98-edf3516e1ea8"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("b5926df2-7c95-4492-a867-2d430924a35b"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("701045a2-ff5b-4e90-ae4f-035211803404"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5402bebd-14b9-42b0-8196-579eb5bbe71e"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2d408867-c6e3-49e6-9b4f-4c5bcd0f5cb9"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1af5caff-1f48-4b94-b09b-14be7e354915"),
				ContainerUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6fbea50a-fcc9-45a8-9318-18aaea6960f4"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,75,107,220,48,16,254,43,139,14,61,89,139,100,203,178,228,158,202,178,45,11,37,13,109,90,10,217,16,198,210,40,17,248,177,177,101,146,96,246,191,87,94,103,91,200,161,228,210,67,193,7,205,72,51,223,99,198,211,173,31,62,250,58,96,95,58,168,7,76,198,157,45,9,164,186,200,211,20,168,202,4,163,34,70,84,131,146,84,105,147,217,84,48,131,182,32,73,11,13,150,100,169,222,90,31,72,226,3,54,67,121,61,253,105,26,250,17,147,91,119,10,190,153,123,108,224,251,12,192,157,148,60,79,145,10,206,20,21,218,42,170,117,158,81,169,153,200,29,147,214,41,69,22,46,182,226,178,208,204,82,83,104,65,5,200,130,66,6,154,170,74,74,229,128,177,212,197,167,53,186,176,125,58,244,56,12,190,107,203,9,127,159,175,158,15,145,229,130,189,233,234,177,105,73,210,96,128,75,8,247,37,73,141,168,176,18,57,181,58,215,84,100,140,209,170,170,144,58,20,70,59,168,164,227,106,13,200,80,228,6,168,17,58,167,194,225,76,65,91,154,65,85,164,133,66,46,121,180,195,192,33,204,216,228,51,130,93,239,44,73,44,4,248,1,245,136,39,14,147,143,106,210,140,113,149,207,26,120,102,34,94,202,168,146,170,160,206,74,167,49,147,90,87,246,236,236,167,209,199,179,31,46,198,6,123,111,94,6,132,209,233,174,47,39,211,181,161,239,234,185,245,197,233,249,21,62,133,101,12,47,87,63,23,233,33,230,231,34,114,76,198,1,55,181,199,54,108,91,211,89,223,222,45,61,143,199,88,210,28,160,247,195,217,175,237,195,8,53,73,122,127,119,255,87,95,55,227,16,186,230,63,146,154,68,153,177,71,92,199,19,221,121,91,173,31,14,53,60,159,226,146,188,123,24,187,240,126,158,225,106,8,112,135,229,106,191,95,114,31,30,193,135,216,105,53,64,141,231,228,250,43,154,174,183,171,157,93,98,242,10,160,36,123,2,89,86,8,39,36,205,101,52,65,20,76,82,157,3,82,206,133,48,42,238,155,19,106,109,43,141,149,50,130,130,200,120,220,115,224,84,35,10,154,43,230,164,115,200,149,150,123,18,149,253,123,190,215,187,225,203,99,123,254,97,23,227,110,214,49,251,42,177,173,177,137,14,151,211,91,4,30,99,193,229,25,170,156,222,34,247,120,51,11,190,57,198,239,23,104,109,241,196,168,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("054c4df5-87b5-404f-85c8-f5bb3e7c2694"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("85e3b80e-36f9-4932-88fd-521181901c0a"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("335d8956-0dcb-469d-90e9-ceef1f2c5ecf"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d9f755be-cee7-464d-9e1b-b41958012cd7"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ea0c6605-f519-48fc-a673-083c99411a6a"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,1,0,242,67,189,42,2,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("04c4106d-1c1b-4e36-adfa-2bde0c00cacb"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,177,50,180,50,212,241,76,177,50,176,50,0,0,230,77,107,227,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("1f66152e-4108-49d8-9953-69045f06df88"),
				UId = new Guid("ee89e1ce-8692-4233-94c8-45e2768973be"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a73fd6bc-7349-44c8-9897-4cbf76d42e92"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("83effc4d-ad92-4d9f-8f5d-a8a8a9476b51"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5877a9b3-2232-413f-bca4-841e0c74fcaf"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e49f79ee-5843-4cf5-8054-c5513d2f9295"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2bb22b1b-8777-4e67-bd6f-76818c3e0d4b"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("10b071ad-0944-459a-90cb-7bd9819ae222"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("1f66152e-4108-49d8-9953-69045f06df88"),
				UId = new Guid("35106250-8b54-4cad-8a40-45adb5f3cd75"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c1ba2a29-f542-4078-94a5-6af41945ce12"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9077d7fd-aab0-4d45-9d7d-e410dd871d90"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6f483bcc-4e72-4895-8fb5-0758dffaddf9"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c55ccbf1-80ac-4a05-a88e-1a3e7a779df4"),
				ContainerUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeAddDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("07e87dc6-266d-4544-87cb-bfd58618dbfc"),
				ContainerUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"a5657e6b-342d-4104-8ab8-aab37ef29860",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8e34ab8a-aae1-49fa-a036-0f0b0ae39983"),
				ContainerUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,43,139,14,61,89,139,101,75,178,228,158,202,178,45,11,37,13,109,90,10,217,16,198,210,40,17,248,99,99,203,36,193,236,127,175,188,206,182,144,67,201,165,135,130,15,154,145,231,189,121,111,70,211,173,31,62,250,58,96,95,58,168,7,76,198,157,45,9,10,231,164,202,37,213,5,230,148,179,52,163,26,10,75,193,113,33,152,200,140,192,130,36,45,52,88,146,165,122,107,125,32,137,15,216,12,229,245,244,7,52,244,35,38,183,238,20,124,51,247,216,192,247,153,128,57,41,35,14,206,216,138,114,109,21,213,90,228,84,234,148,11,151,74,235,148,34,75,47,66,229,105,94,160,162,153,208,150,114,99,20,173,138,74,82,22,99,100,21,51,92,75,146,212,232,194,246,233,208,227,48,248,174,45,39,252,125,190,122,62,196,46,23,238,77,87,143,77,75,146,6,3,92,66,184,47,73,102,120,133,21,23,212,106,161,41,207,211,148,86,85,133,212,33,55,218,65,37,29,83,107,192,20,185,48,64,35,151,160,220,97,65,33,143,205,228,80,21,89,161,144,73,22,237,48,112,8,51,55,249,140,96,215,59,75,18,11,1,126,64,61,226,169,135,201,71,53,89,158,50,37,100,4,96,185,137,124,89,74,149,84,5,117,86,58,141,185,212,186,178,103,103,63,141,62,158,253,112,49,54,216,123,243,50,32,140,78,119,125,57,153,174,13,125,87,207,208,23,167,223,175,240,41,44,99,120,185,250,185,72,15,49,63,23,145,99,50,14,184,169,61,182,97,219,154,206,250,246,110,193,60,30,99,73,115,128,222,15,103,191,182,15,35,212,36,233,253,221,253,95,125,221,140,67,232,154,255,72,106,18,101,70,140,184,142,167,118,231,109,181,126,56,212,240,124,138,75,242,238,97,236,194,251,121,134,171,33,192,29,150,171,253,126,201,125,120,4,31,34,210,106,128,26,207,201,245,87,52,93,111,87,59,187,196,228,21,65,73,246,4,242,188,224,142,75,42,100,52,129,23,105,124,88,2,144,50,198,185,81,113,223,28,87,107,91,105,172,148,225,20,120,206,40,7,96,84,35,114,42,84,234,164,115,200,148,150,123,18,149,253,251,126,175,119,195,151,199,246,252,96,23,227,110,214,49,251,42,177,173,177,137,14,151,211,91,4,30,99,193,229,153,170,156,222,34,247,120,51,11,190,57,198,239,23,225,253,223,116,168,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b4c062c1-d149-4854-b95d-7d3101c49ba8"),
				ContainerUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordAddMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			recordAddModeParameter.SourceValue = new ProcessSchemaParameterValue(recordAddModeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("9b1e2c37-1ca0-4018-820c-534743d29771"),
				ContainerUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"FilterEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1f66152e-4108-49d8-9953-69045f06df88",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3f57e619-c84a-40cd-a0f1-b5c0fad5c3c5"),
				ContainerUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordDefValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,197,84,193,110,219,48,12,253,149,66,237,49,12,100,73,150,172,92,183,29,2,180,93,177,118,189,36,57,80,18,181,6,112,236,192,118,86,116,65,254,125,138,147,172,105,177,117,88,81,116,62,216,144,196,71,62,63,242,105,205,206,186,135,37,177,17,187,161,166,193,182,142,221,240,67,221,208,240,170,169,61,181,237,240,188,246,88,206,127,160,43,233,10,27,92,80,71,205,45,150,43,106,207,231,109,55,56,121,10,99,3,118,246,189,63,101,163,201,154,141,59,90,124,29,135,148,93,69,149,147,10,5,160,11,6,84,20,25,20,58,16,20,89,84,194,21,30,101,16,9,236,235,114,181,168,46,168,195,43,236,238,216,104,205,250,108,41,129,204,162,43,164,242,192,131,214,160,132,17,128,156,11,176,34,26,34,107,131,247,138,109,6,172,245,119,180,192,190,232,35,24,115,157,27,210,14,164,18,1,84,198,21,20,232,18,25,116,210,80,20,182,208,124,11,222,199,63,2,141,180,60,74,111,129,83,180,137,118,226,142,156,36,112,71,54,88,18,58,242,108,136,196,73,229,30,193,43,155,167,32,74,65,210,6,144,232,140,48,5,101,58,51,219,236,97,222,46,75,124,184,125,94,36,73,29,86,190,27,38,206,41,106,249,68,229,227,184,245,116,215,172,41,27,77,255,212,174,253,247,186,87,225,105,195,158,247,106,202,6,83,118,93,175,26,191,205,168,183,139,131,118,125,5,190,127,224,55,175,195,179,203,209,195,46,176,194,111,212,92,166,138,61,188,63,250,136,29,246,197,111,18,239,127,78,252,133,34,53,84,121,122,37,177,190,242,35,153,195,88,245,59,111,214,217,61,211,182,23,114,59,240,123,5,170,85,89,110,21,56,106,250,17,149,58,204,227,156,194,184,122,205,175,109,216,102,51,56,118,87,180,82,59,133,28,50,21,11,80,193,56,64,107,8,164,228,58,11,130,59,195,253,139,238,66,155,163,34,85,128,41,108,6,74,90,5,142,156,7,171,48,23,65,248,66,6,247,246,238,154,156,78,198,237,231,251,138,154,157,10,163,136,101,75,179,97,218,125,182,241,169,164,5,85,221,104,173,84,30,117,65,2,92,224,18,148,81,26,80,27,3,82,24,231,200,24,17,181,223,36,192,175,209,31,173,131,246,18,67,97,33,181,60,93,61,33,36,136,16,22,98,46,40,38,138,65,73,183,153,157,206,94,178,232,228,244,146,238,79,234,229,178,110,186,85,53,239,30,134,219,117,67,190,110,194,201,56,236,192,255,201,185,242,253,156,235,132,205,185,201,34,24,194,100,26,210,2,138,144,33,216,204,186,40,141,20,49,138,151,156,139,164,116,186,198,13,120,46,60,40,164,52,36,65,102,105,88,133,244,33,88,171,124,252,139,115,247,182,122,127,195,205,54,63,1,86,222,91,182,44,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("916d8dad-7673-427b-a065-b9d623107663"),
				ContainerUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeReadDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("06208806-e8cf-4d1b-b140-1bb619b9ed9d"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,219,146,44,201,61,46,91,8,148,52,208,15,10,97,9,35,105,148,152,250,43,182,76,27,140,255,123,181,246,58,13,57,148,210,91,65,7,141,164,247,230,205,155,209,124,87,141,239,171,58,224,80,122,168,71,76,166,43,87,18,7,90,235,2,29,53,153,204,41,183,80,80,37,192,82,180,142,155,34,119,232,50,70,146,22,26,44,201,134,62,186,42,144,164,10,216,140,229,237,252,155,52,12,19,38,119,126,13,62,217,7,108,224,203,57,1,32,47,188,81,146,218,52,183,148,3,42,10,142,101,20,116,206,172,115,90,115,235,201,166,69,184,130,9,46,83,42,209,196,167,185,241,20,148,20,20,60,58,157,162,50,210,228,36,169,209,135,227,207,126,192,113,172,186,182,156,241,121,255,249,169,143,42,183,220,135,174,158,154,150,36,13,6,184,129,240,80,146,130,67,42,140,7,202,68,234,40,119,145,221,120,167,168,55,66,106,144,220,51,141,36,177,208,135,51,45,57,116,109,0,27,43,29,208,227,128,173,197,23,69,101,133,65,86,136,140,42,143,209,181,76,104,170,156,75,163,220,148,57,94,40,230,92,116,205,65,128,175,80,79,184,10,155,171,8,52,185,22,169,204,124,44,17,52,229,88,228,17,152,1,213,153,54,158,73,150,123,159,239,118,127,232,186,239,83,31,173,30,175,167,6,135,202,94,250,134,177,1,221,80,206,54,42,28,186,250,76,126,253,2,176,245,231,114,249,109,243,164,94,111,206,64,178,36,211,136,135,186,194,54,28,91,219,185,170,189,95,91,183,44,17,211,244,48,84,227,238,228,241,113,130,58,26,80,221,63,252,209,241,195,52,134,174,249,223,234,77,98,173,145,38,78,235,170,249,60,204,174,26,251,26,158,214,184,36,111,30,167,46,188,187,204,193,22,144,87,160,253,145,41,4,227,34,23,148,41,174,40,231,121,74,149,102,41,69,105,172,213,10,50,41,138,11,195,146,252,123,154,219,171,241,227,143,118,255,94,155,61,167,183,241,244,213,193,205,142,46,231,191,81,182,156,118,109,167,37,174,95,30,241,119,1,41,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c7f8a702-1219-42b2-bf9d-1f55c8264391"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3792585d-cd7c-494c-b316-b160fa45ae28"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("faa46a7f-a96c-46cf-9a47-add578864b68"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("68383c19-2658-416e-958d-1489861993aa"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("80cefc71-5fc6-4296-b100-29c98156e0b1"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("35445f62-ccc0-4a74-94f0-9ec9ea65b343"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,201,44,201,73,181,50,180,50,212,241,76,177,50,176,50,0,0,169,240,29,88,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("6cba6276-dc6c-4940-803b-a32b756d2ebd"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6d7147db-0aaa-41c5-8897-3ad2d88fd821"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("00aae8e4-4e62-4538-9bf7-d0b6178f7c93"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e696780e-c260-4f1d-ac47-1890fdb6b840"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("da459109-1578-45d4-9510-627e44859262"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("05f93e88-b9f0-488c-b37f-c86bd5b8d920"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1ddf79d1-87fa-413b-b322-71e34392312d"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("2f6fab91-5a02-44f1-9ea1-7012b00b2849"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d5f43f08-08d2-4c1d-aae8-d8cddf1e99e0"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b65917ae-2434-428b-b40e-92d5141b5034"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3c28f35a-ad91-46a3-b3de-3cad5ffcf70b"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("89c2533d-f152-4c4a-8358-baa80bdaa10b"),
				ContainerUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaOpportunityMangement = CreateOpportunityMangementLaneSet();
			LaneSets.Add(schemaOpportunityMangement);
			ProcessSchemaLane schemaOpportunityMangementProcess = CreateOpportunityMangementProcessLane();
			schemaOpportunityMangement.Lanes.Add(schemaOpportunityMangementProcess);
			ProcessSchemaSubProcess prospecting = CreateProspectingSubProcess();
			FlowElements.Add(prospecting);
			ProcessSchemaSubProcess needsanalysis = CreateNeedsAnalysisSubProcess();
			FlowElements.Add(needsanalysis);
			ProcessSchemaSubProcess oppmanagementvaluepproposition = CreateOppManagementValuePpropositionSubProcess();
			FlowElements.Add(oppmanagementvaluepproposition);
			ProcessSchemaSubProcess iddecisionmakers = CreateIdDecisionMakersSubProcess();
			FlowElements.Add(iddecisionmakers);
			ProcessSchemaSubProcess oppmanagementperceptionanalysis = CreateOppManagementPerceptionAnalysisSubProcess();
			FlowElements.Add(oppmanagementperceptionanalysis);
			ProcessSchemaSubProcess oppmanagementproposal = CreateOppManagementProposalSubProcess();
			FlowElements.Add(oppmanagementproposal);
			ProcessSchemaSubProcess oppmanagementnegotiations = CreateOppManagementNegotiationsSubProcess();
			FlowElements.Add(oppmanagementnegotiations);
			ProcessSchemaSubProcess oppmanagementcontractation = CreateOppManagementContractationSubProcess();
			FlowElements.Add(oppmanagementcontractation);
			ProcessSchemaSubProcess oppmanagementendstage = CreateOppManagementEndStageSubProcess();
			FlowElements.Add(oppmanagementendstage);
			ProcessSchemaUserTask readoppdata = CreateReadOppDataUserTask();
			FlowElements.Add(readoppdata);
			ProcessSchemaExclusiveGateway opportunitystage = CreateOpportunityStageExclusiveGateway();
			FlowElements.Add(opportunitystage);
			ProcessSchemaTerminateEvent terminate3 = CreateTerminate3TerminateEvent();
			FlowElements.Add(terminate3);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			ProcessSchemaUserTask findpresentation = CreateFindPresentationUserTask();
			FlowElements.Add(findpresentation);
			ProcessSchemaFormulaTask savepresentationparameter2 = CreateSavePresentationParameter2FormulaTask();
			FlowElements.Add(savepresentationparameter2);
			ProcessSchemaUserTask linkopptoprocess = CreateLinkOppToProcessUserTask();
			FlowElements.Add(linkopptoprocess);
			ProcessSchemaUserTask readoppmaincontact = CreateReadOppMainContactUserTask();
			FlowElements.Add(readoppmaincontact);
			ProcessSchemaFormulaTask savemaincontactparameter = CreateSaveMainContactParameterFormulaTask();
			FlowElements.Add(savemaincontactparameter);
			ProcessSchemaStartSignalEvent startsignalleadstagechange = CreateStartSignalLeadStageChangeStartSignalEvent();
			FlowElements.Add(startsignalleadstagechange);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			FlowElements.Add(exclusivegateway3);
			ProcessSchemaStartEvent startoppbusinessprocess = CreateStartOppBusinessProcessStartEvent();
			FlowElements.Add(startoppbusinessprocess);
			ProcessSchemaUserTask openeditpageusertask1 = CreateOpenEditPageUserTask1UserTask();
			FlowElements.Add(openeditpageusertask1);
			ProcessSchemaExclusiveGateway exclusivegateway4 = CreateExclusiveGateway4ExclusiveGateway();
			FlowElements.Add(exclusivegateway4);
			ProcessSchemaTerminateEvent terminate4 = CreateTerminate4TerminateEvent();
			FlowElements.Add(terminate4);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaFormulaTask formulatask2 = CreateFormulaTask2FormulaTask();
			FlowElements.Add(formulatask2);
			ProcessSchemaFormulaTask storeisstagechangedbyuser = CreateStoreIsStageChangedByUserFormulaTask();
			FlowElements.Add(storeisstagechangedbyuser);
			ProcessSchemaFormulaTask resetisstagechangedbyuser = CreateResetIsStageChangedByUserFormulaTask();
			FlowElements.Add(resetisstagechangedbyuser);
			ProcessSchemaUserTask readdatalead = CreateReadDataLeadUserTask();
			FlowElements.Add(readdatalead);
			ProcessSchemaUserTask changedatalead = CreateChangeDataLeadUserTask();
			FlowElements.Add(changedatalead);
			ProcessSchemaExclusiveGateway exclusivegatewaysetdatetimepresentation = CreateExclusiveGatewaySetDateTimePresentationExclusiveGateway();
			FlowElements.Add(exclusivegatewaysetdatetimepresentation);
			ProcessSchemaTerminateEvent terminate2 = CreateTerminate2TerminateEvent();
			FlowElements.Add(terminate2);
			ProcessSchemaUserTask adddatacontacttoopportunity = CreateAddDataContactToOpportunityUserTask();
			FlowElements.Add(adddatacontacttoopportunity);
			ProcessSchemaExclusiveGateway exclusivegatewayleadqualifiedascontact = CreateExclusiveGatewayLeadQualifiedAsContactExclusiveGateway();
			FlowElements.Add(exclusivegatewayleadqualifiedascontact);
			ProcessSchemaUserTask adddataopportunity = CreateAddDataOpportunityUserTask();
			FlowElements.Add(adddataopportunity);
			ProcessSchemaUserTask readdatacountopportunitybyaccount = CreateReadDataCountOpportunityByAccountUserTask();
			FlowElements.Add(readdatacountopportunitybyaccount);
			ProcessSchemaUserTask readdataaccount = CreateReadDataAccountUserTask();
			FlowElements.Add(readdataaccount);
			ProcessSchemaFormulaTask formulataskaccountbylead = CreateFormulaTaskAccountByLeadFormulaTask();
			FlowElements.Add(formulataskaccountbylead);
			ProcessSchemaUserTask readdatacontact = CreateReadDataContactUserTask();
			FlowElements.Add(readdatacontact);
			ProcessSchemaExclusiveGateway exclusivegatewayqualifiedbyaccount = CreateExclusiveGatewayQualifiedByAccountExclusiveGateway();
			FlowElements.Add(exclusivegatewayqualifiedbyaccount);
			ProcessSchemaFormulaTask savecurroppparameter = CreateSaveCurrOppParameterFormulaTask();
			FlowElements.Add(savecurroppparameter);
			ProcessSchemaUserTask presentationtaskcreation = CreatePresentationTaskCreationUserTask();
			FlowElements.Add(presentationtaskcreation);
			ProcessSchemaFormulaTask savepresentationparameter = CreateSavePresentationParameterFormulaTask();
			FlowElements.Add(savepresentationparameter);
			ProcessSchemaUserTask readoppoortunitydata2 = CreateReadOppoortunityData2UserTask();
			FlowElements.Add(readoppoortunitydata2);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaFormulaTask formulatask3 = CreateFormulaTask3FormulaTask();
			FlowElements.Add(formulatask3);
			ProcessSchemaFormulaTask formulatask4 = CreateFormulaTask4FormulaTask();
			FlowElements.Add(formulatask4);
			ProcessSchemaFormulaTask formulatask5 = CreateFormulaTask5FormulaTask();
			FlowElements.Add(formulatask5);
			ProcessSchemaFormulaTask formulatask6 = CreateFormulaTask6FormulaTask();
			FlowElements.Add(formulatask6);
			ProcessSchemaFormulaTask formulatask7 = CreateFormulaTask7FormulaTask();
			FlowElements.Add(formulatask7);
			ProcessSchemaFormulaTask formulatask8 = CreateFormulaTask8FormulaTask();
			FlowElements.Add(formulatask8);
			ProcessSchemaFormulaTask formulatask9 = CreateFormulaTask9FormulaTask();
			FlowElements.Add(formulatask9);
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateProspectingStageConditionalFlow());
			FlowElements.Add(CreateNeedAnalysisStageConditionalFlow());
			FlowElements.Add(CreateValuePropositionConditionalFlow());
			FlowElements.Add(CreateDecisionMakersConditionalFlow());
			FlowElements.Add(CreatePerceptionAnalysisStageConditionalFlow());
			FlowElements.Add(CreateNegotiationsStageConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateContractationStageConditionalFlow());
			FlowElements.Add(CreateProposalStageConditionalFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow24SequenceFlow());
			FlowElements.Add(CreateSequenceFlow25SequenceFlow());
			FlowElements.Add(CreateSequenceFlow27SequenceFlow());
			FlowElements.Add(CreateConditionalFlow8ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow30SequenceFlow());
			FlowElements.Add(CreateSequenceFlow31SequenceFlow());
			FlowElements.Add(CreateSequenceFlow32SequenceFlow());
			FlowElements.Add(CreateSequenceFlow33SequenceFlow());
			FlowElements.Add(CreateConditionalFlow10ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow34SequenceFlow());
			FlowElements.Add(CreateSequenceFlow35SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow36SequenceFlow());
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow7ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow37SequenceFlow());
			FlowElements.Add(CreateConditionalFlow11ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow38SequenceFlow());
			FlowElements.Add(CreateSequenceFlow39SequenceFlow());
			FlowElements.Add(CreateConditionalFlow12ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow40SequenceFlow());
			FlowElements.Add(CreateSequenceFlow41SequenceFlow());
			FlowElements.Add(CreateSequenceFlow42SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow43SequenceFlow());
			FlowElements.Add(CreateSequenceFlow44SequenceFlow());
			FlowElements.Add(CreateSequenceFlow28SequenceFlow());
			FlowElements.Add(CreateConditionalFlow5ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow46SequenceFlow());
			FlowElements.Add(CreateSequenceFlow47SequenceFlow());
			FlowElements.Add(CreateSequenceFlow50SequenceFlow());
			FlowElements.Add(CreateSequenceFlow49SequenceFlow());
			FlowElements.Add(CreateSequenceFlow29SequenceFlow());
			FlowElements.Add(CreateSequenceFlow45SequenceFlow());
			FlowElements.Add(CreateSequenceFlow26SequenceFlow());
			FlowElements.Add(CreateSequenceFlow48SequenceFlow());
			FlowElements.Add(CreateSequenceFlow51SequenceFlow());
			FlowElements.Add(CreateSequenceFlow52SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("b7a4e901-cd6d-48d8-8ea3-b631737057d2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(772, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateProspectingStageConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ProspectingStage",
				UId = new Guid("6da9cfcb-81e5-48a4-a1c1-42a6279225e6"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.c2067b11-0ee0-df11-971b-001d60e938c6#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(736, 133),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0dbea59a-7031-4af4-a9b8-d96dea1c356c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateNeedAnalysisStageConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "NeedAnalysisStage",
				UId = new Guid("9301d50a-6c5b-4489-badd-4a28230234ae"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.2a6de0f7-44d9-4b8a-bce6-acddb7ed8915#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(750, 199),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c6385211-3b10-447a-8d34-e3f3605c4793"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateValuePropositionConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ValueProposition",
				UId = new Guid("bb42fb47-5fbd-4f77-af1e-ce351db4f8f9"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.325f0619-0ee0-df11-971b-001d60e938c6#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(712, 283),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateDecisionMakersConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "DecisionMakers",
				UId = new Guid("f094c232-c29e-46d1-86fc-2e61dcac8e07"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.f4e4a00b-ec48-46d0-9ea0-c2b502165ee9#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(723, 322),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d58ab1aa-6acb-4539-9b28-cda203b74ced"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreatePerceptionAnalysisStageConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "PerceptionAnalysisStage",
				UId = new Guid("90dc5cd4-a514-48c4-9705-1babb54dc9a9"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.241ade6b-4256-4947-ba8a-7d96988a97b6#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(690, 398),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("da8227c5-5602-4a29-b848-1fb1e6b57440"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateNegotiationsStageConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "NegotiationsStage",
				UId = new Guid("3b93fd4b-c4ce-43ef-81de-d70f18e28cd9"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.f808c955-c5aa-4aba-95c0-ba7d584d2f32#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(693, 494),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2bd13ebc-d0be-488e-9dff-abea5ba029d2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("a0baa7ff-239e-42e9-8768-1ee3435f5a90"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(346, 308),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cc1b7702-073c-45cc-926b-05e107a8fd30"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4ba680da-7591-4eb5-8ede-25d1558e9149"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateContractationStageConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ContractationStage",
				UId = new Guid("97b5d2a4-5ab3-4fb5-9544-7ee6933c7e5a"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.fb563df2-5ae6-df11-971b-001d60e938c6#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(944, 656),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8cd60286-ecaa-4f5c-aa25-62e4f4b7ee26"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateProposalStageConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ProposalStage",
				UId = new Guid("94b519f4-4f88-4966-9c23-8a451496a11b"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{0c718c20-8264-4ad8-ac5f-2ec36a29a498}].[Parameter:{61d6f451-48d9-4c96-917b-f6c5ce85df83}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]==[#Lookup.ccf7d813-fc83-47ad-be61-8f3b3b98a54f.423774cb-5ae6-df11-971b-001d60e938c6#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(1006, 566),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e3b6949a-0754-40f7-a369-1f69dae8bc2d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow16",
				UId = new Guid("de2431a0-d30e-4cfc-b8cf-278b073a39f0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(1261, 438),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a754a29c-40c0-420e-941d-f2b4a941c8ab"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("a681a1ef-7292-4df0-8fc4-8af2fec6edb9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(1088, 494),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(2248, 716));
			schemaFlow.PolylinePointPositions.Add(new Point(1345, 716));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("8d4357f8-f4f9-48b5-a570-41ea6d475b92"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(919, 276),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0dbea59a-7031-4af4-a9b8-d96dea1c356c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("f96d1ad1-4a55-4afb-9ba8-e36591778f46"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(920, 333),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c6385211-3b10-447a-8d34-e3f3605c4793"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("3d3dd689-8fb9-4955-b1ca-b7d2ce229b92"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(936, 377),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("54731090-57ce-4f13-a4f0-8398e8e5479f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("0eb60d05-9aec-4c62-be1d-1178bca849d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(936, 440),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d58ab1aa-6acb-4539-9b28-cda203b74ced"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("2b63dc8f-d13f-49c5-835d-3483f4523a44"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(936, 520),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da8227c5-5602-4a29-b848-1fb1e6b57440"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("0e1f6ffa-18a8-4413-a8ec-e72659aa72f9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(936, 572),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e3b6949a-0754-40f7-a369-1f69dae8bc2d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("462272ae-0429-49e5-8618-a2a7fd3481fa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(918, 611),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2bd13ebc-d0be-488e-9dff-abea5ba029d2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("b535ac24-faf0-4bd6-ba78-19cfe825e870"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(917, 669),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8cd60286-ecaa-4f5c-aa25-62e4f4b7ee26"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a754a29c-40c0-420e-941d-f2b4a941c8ab"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("b131dc29-103b-498c-8cad-b0267ae02df9"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{af8eea9e-0e11-426e-a870-2cff33d00f84}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(330, 444),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4ba680da-7591-4eb5-8ede-25d1558e9149"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow14",
				UId = new Guid("be43f005-b89c-4be1-b699-0acc87df40c3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(320, 441),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4ba680da-7591-4eb5-8ede-25d1558e9149"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("656a4a04-8b53-40cb-9fe2-d14c1a49db28"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{da7cbb80-cd50-40b3-883c-6f5384f2478a}].[Parameter:{6f8cde56-f764-4ad1-b528-0d9031cd1e8e}]#].Count == 0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(386, 495),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("945c5224-09ec-408a-b369-ae94b490e7b7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(218, 604),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d8643dcc-9a0d-40a5-abbb-c08fc8ced26b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("af05fdeb-fca0-41d3-9791-46dc1679ea6c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(218, 716),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d8643dcc-9a0d-40a5-abbb-c08fc8ced26b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("d530128e-0ad3-40af-b76a-b9da0f99dec8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(427, 311),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0b3df41d-a31f-4753-9ad5-bb8d4c5137fb"),
				SourceSequenceFlowPointLocalPosition = new Point(-1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1304, 338));
			schemaFlow.PolylinePointPositions.Add(new Point(1304, 390));
			schemaFlow.PolylinePointPositions.Add(new Point(1141, 390));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("f2e28c79-53c0-420e-bc3b-2fe8df5cb57d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(380, 318),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a914a2b0-15d2-4c81-938d-6f3bcc01c912"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0b3df41d-a31f-4753-9ad5-bb8d4c5137fb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1421, 268));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("3a915671-271f-4aca-8ecb-49e7c53c9b5f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(380, 318),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a914a2b0-15d2-4c81-938d-6f3bcc01c912"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("44ae693f-6aa2-4a99-bdf0-2cde17ec3507"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(750, 303),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				SourceSequenceFlowPointLocalPosition = new Point(-1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("a580eaa3-fc67-44f4-97b8-d4612d7fe5bc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(1134, 440),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow24SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow24",
				UId = new Guid("de750837-99b2-4b33-b71b-deba1897a823"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(772, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("90ba94c4-778e-4da8-b1fa-20caa11d06b9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow25SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow25",
				UId = new Guid("55a5a7b6-1fe9-43e6-8550-f6da9d2fcf2b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(772, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("90ba94c4-778e-4da8-b1fa-20caa11d06b9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c07da6a9-f9fc-4d1b-a11d-633a4992ae39"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow27SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow27",
				UId = new Guid("788216e9-2036-4a1f-831c-141dbdcba7b5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(386, 151),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ba7fb0fc-f887-4dd2-9494-28335297b5e4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("da838103-79ee-48ff-b9fb-43f5d9fb0543"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow8ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow8",
				UId = new Guid("12da4680-7947-44ac-bce4-174e2ea3d434"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{fe4d88e0-465c-48ba-91bc-e9ded45b3c50}].[Parameter:{d4413fda-e205-481c-828d-b4e67061712f}].[EntityColumn:{32949ae4-ff13-48f5-9f5d-45a74558ea55}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(456, 66),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ba7fb0fc-f887-4dd2-9494-28335297b5e4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ab3f8e00-ffa9-4079-8f2d-c9aa8b4b4826"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow30SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow30",
				UId = new Guid("e15bb4f0-0213-4d52-8387-1a542b5d4eb4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(759, 158),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ab3f8e00-ffa9-4079-8f2d-c9aa8b4b4826"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow31SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow31",
				UId = new Guid("060a734c-031d-4892-97f8-7d1c8e825e30"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(896, 128),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cecd8639-1f00-4d59-b112-9fbe4de5517a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow32SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow32",
				UId = new Guid("af864a06-1ac3-4766-bdb4-9064d35c26ca"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(1041, 126),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b120e00e-d3f2-4b09-8118-ef17c00af6bb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow33SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow33",
				UId = new Guid("3df63af1-a134-40e5-b6bf-b5a735392364"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(1133, 190),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c017a416-4566-4caf-89f0-cd11dc760d58"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow10ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow10",
				UId = new Guid("fe99e954-54c6-4dbc-ae4e-724f11084d1e"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{fe4d88e0-465c-48ba-91bc-e9ded45b3c50}].[Parameter:{d4413fda-e205-481c-828d-b4e67061712f}].[EntityColumn:{ad490d58-054a-4d85-9246-dd8466eb3983}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(1224, 186),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c017a416-4566-4caf-89f0-cd11dc760d58"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow34SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow34",
				UId = new Guid("9aa77dec-7ab7-4403-a78e-711f966d98a3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(915, 264),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c017a416-4566-4caf-89f0-cd11dc760d58"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1547, 120));
			schemaFlow.PolylinePointPositions.Add(new Point(1680, 120));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow35SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow35",
				UId = new Guid("598e3e34-6da9-4dea-8c0d-5f7bcfca6637"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(946, 218),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1729, 47));
			schemaFlow.PolylinePointPositions.Add(new Point(1729, 177));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow1",
				UId = new Guid("8add388c-07d2-4f83-bfa0-ac871ab00d61"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(218, 110),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("375b9e3c-98fc-4100-83c4-c571cfe22b08"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow36SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow36",
				UId = new Guid("5ec251e3-686c-42c6-8f99-34b869d3217c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(946, 283),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f7a393e4-d550-4f6e-aba4-c4a007307258"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0b3df41d-a31f-4753-9ad5-bb8d4c5137fb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow4",
				UId = new Guid("6f012dc4-0679-4da3-84ce-757680848a3c"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{fe4d88e0-465c-48ba-91bc-e9ded45b3c50}].[Parameter:{d4413fda-e205-481c-828d-b4e67061712f}].[EntityColumn:{efc32501-4c3a-4500-8fa4-1d70c6bf26f9}]#] != null && !DateTime.MinValue.Equals([#[IsOwnerSchema:false].[IsSchema:false].[Element:{fe4d88e0-465c-48ba-91bc-e9ded45b3c50}].[Parameter:{d4413fda-e205-481c-828d-b4e67061712f}].[EntityColumn:{efc32501-4c3a-4500-8fa4-1d70c6bf26f9}]#])",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(862, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f7a393e4-d550-4f6e-aba4-c4a007307258"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow7ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow7",
				UId = new Guid("e1fae17b-971d-469e-82c9-0d8f1161f09b"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{fe4d88e0-465c-48ba-91bc-e9ded45b3c50}].[Parameter:{d4413fda-e205-481c-828d-b4e67061712f}].[EntityColumn:{7cfff438-9ee8-4272-816d-5deb7d0c9d36}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(342, 197),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ba7fb0fc-f887-4dd2-9494-28335297b5e4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow37SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow37",
				UId = new Guid("866016a6-730c-4f6d-8688-5ca07b0bba21"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(750, 303),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f7a393e4-d550-4f6e-aba4-c4a007307258"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow11ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow11",
				UId = new Guid("aff117cc-494a-447b-824c-ea45bf0c048a"),
				ConditionExpression = @"[#SysSettings.StartOppBusinessProcess#] == true",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(304, 236),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ef1d55e6-1755-412a-9d7c-f01d78a5edf9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow38SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow38",
				UId = new Guid("d775251b-c99c-4962-8c31-63e5179999be"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(298, 119),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ef1d55e6-1755-412a-9d7c-f01d78a5edf9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("375b9e3c-98fc-4100-83c4-c571cfe22b08"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(107, 176));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow39SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow39",
				UId = new Guid("2b69f135-398e-443a-a1a4-3237cbf24d5d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(768, 644),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("69c50fcc-abf2-43ac-a9d1-e9e6ed6a5397"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow12ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow12",
				UId = new Guid("b3fa892c-1d0a-4e76-a01e-553b47b9714a"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{b10332bd-27a4-46bc-a990-f59da9cdbb25}].[Parameter:{c5f0d6a4-d18b-446e-8335-18fb080f660a}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(834, 698),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69c50fcc-abf2-43ac-a9d1-e9e6ed6a5397"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("129d65ec-f59b-44af-b1d6-cda0a6b4ff21"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow40SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow40",
				UId = new Guid("7eab7b7b-6047-42c1-a1fb-6279a4cd3a64"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(1149, 544),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ad47ec52-76d5-44c0-b66d-9440119348ca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow41SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow41",
				UId = new Guid("1c43080a-684a-4791-9f3b-a6ab1a023caa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(990, 644),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69c50fcc-abf2-43ac-a9d1-e9e6ed6a5397"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ad47ec52-76d5-44c0-b66d-9440119348ca"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow42SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow42",
				UId = new Guid("a0e10bcc-d9cf-4167-8c98-8f859c88ba6a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(936, 377),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("54731090-57ce-4f13-a4f0-8398e8e5479f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21",
				UId = new Guid("de731752-04c3-40a1-9853-07e0a87ba911"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(2100, 440),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("2f225a00-7172-4df7-b6bb-f13891d00109"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(772, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c07da6a9-f9fc-4d1b-a11d-633a4992ae39"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("483624cb-e100-4417-b0d7-2d89990301bc"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{9d00770f-dda3-42a7-937d-59d67284f4c1}].[Parameter:{a73fd6bc-7349-44c8-9897-4cbf76d42e92}]#] == 0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbdfa4ab-c534-4027-a134-96b45d5b7770"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(1183, 361),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow43SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow43",
				UId = new Guid("87a64e65-a497-4ebc-a9cf-14260e618e18"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbdfa4ab-c534-4027-a134-96b45d5b7770"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(1286, 280),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow44SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow44",
				UId = new Guid("a5997d52-51b6-48a5-a656-bd7d3854ca36"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbdfa4ab-c534-4027-a134-96b45d5b7770"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(1234, 350),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1305, 500));
			schemaFlow.PolylinePointPositions.Add(new Point(1176, 500));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow28SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow28",
				UId = new Guid("72ab06d6-4130-493c-b2af-5c38d597d2ff"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(447, 123),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da838103-79ee-48ff-b9fb-43f5d9fb0543"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("375b9e3c-98fc-4100-83c4-c571cfe22b08"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow5ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow5",
				UId = new Guid("e9f42fb2-6bda-464a-8a5a-cfb4b9ca50b1"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{fe4d88e0-465c-48ba-91bc-e9ded45b3c50}].[Parameter:{d4413fda-e205-481c-828d-b4e67061712f}].[EntityColumn:{ad490d58-054a-4d85-9246-dd8466eb3983}]#]  != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(576, 108),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da838103-79ee-48ff-b9fb-43f5d9fb0543"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e71860b5-b65b-493b-8d7c-c65ed80dc169"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow46SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow46",
				UId = new Guid("59c61212-02fe-41a0-ad79-c40ccc35532c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(1041, 126),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b120e00e-d3f2-4b09-8118-ef17c00af6bb"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f284494f-5edb-489b-92c3-ddb20eaa0ab0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow47SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow47",
				UId = new Guid("17b0bf13-f217-45b1-afcc-b2adc6141887"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(991, 186),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("083b1a16-96f4-434c-bd21-1e475d6a546b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow50SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow50",
				UId = new Guid("a302bf3e-58ff-4854-bc1b-7eaa9052bfe8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(896, 128),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cecd8639-1f00-4d59-b112-9fbe4de5517a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow49SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow49",
				UId = new Guid("17087fe4-cdf9-44bf-87ae-069f098e6b9f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(906, 184),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d527d260-953d-4177-b84b-fd337a8b9408"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow29SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow29",
				UId = new Guid("7f2af97b-9700-4293-ab0f-ab54f86bdd6c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(751, 186),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d527d260-953d-4177-b84b-fd337a8b9408"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow45SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow45",
				UId = new Guid("153b7c7c-46d1-44e7-b271-f8fcdeacae3b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(644, 184),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e71860b5-b65b-493b-8d7c-c65ed80dc169"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow26SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow26",
				UId = new Guid("c6c60e5b-a2e1-4af3-81b1-7c228375d5c9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a3374f46-5620-4706-95ae-1144c8bbbf48"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ef1d55e6-1755-412a-9d7c-f01d78a5edf9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(66, 337));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow48SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow48",
				UId = new Guid("14dc3926-be2e-4381-aa61-5cf5889f09b2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48537fce-e726-43c7-8dd9-691e0e0c228e"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("083b1a16-96f4-434c-bd21-1e475d6a546b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7727ad4d-089b-417c-acfd-d66ee83afc06"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow51SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow51",
				UId = new Guid("d9b40787-f4db-4de9-a07f-63291d659ebb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48537fce-e726-43c7-8dd9-691e0e0c228e"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7727ad4d-089b-417c-acfd-d66ee83afc06"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1220, 176));
			schemaFlow.PolylinePointPositions.Add(new Point(1220, 47));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow52SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow52",
				UId = new Guid("29aaa936-4362-4814-a131-6dd7a498a947"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48537fce-e726-43c7-8dd9-691e0e0c228e"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f284494f-5edb-489b-92c3-ddb20eaa0ab0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1221, 337));
			schemaFlow.PolylinePointPositions.Add(new Point(1221, 47));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateOpportunityMangementLaneSet() {
			ProcessSchemaLaneSet schemaOpportunityMangement = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8ea1b510-d580-4bce-a7d9-506d9c032358"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"OpportunityMangement",
				Position = new Point(5, 5),
				Size = new Size(2403, 961),
				UseBackgroundMode = false
			};
			return schemaOpportunityMangement;
		}

		protected virtual ProcessSchemaLane CreateOpportunityMangementProcessLane() {
			ProcessSchemaLane schemaOpportunityMangementProcess = new ProcessSchemaLane(this) {
				UId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("8ea1b510-d580-4bce-a7d9-506d9c032358"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"OpportunityMangementProcess",
				Position = new Point(29, 0),
				Size = new Size(2374, 961),
				UseBackgroundMode = false
			};
			return schemaOpportunityMangementProcess;
		}

		protected virtual ProcessSchemaUserTask CreateReadOppDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ReadOppData",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1310, 569),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadOppDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateOpportunityStageExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"OpportunityStage",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1772, 569),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaSubProcess CreateProspectingSubProcess() {
			ProcessSchemaSubProcess schemaProspecting = new ProcessSchemaSubProcess(this) {
				UId = new Guid("0dbea59a-7031-4af4-a9b8-d96dea1c356c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"Prospecting",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1898, 23),
				SchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeProspectingParameters(schemaProspecting);
			return schemaProspecting;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate3TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("a754a29c-40c0-420e-941d-f2b4a941c8ab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"Terminate3",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2332, 583),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaSubProcess CreateNeedsAnalysisSubProcess() {
			ProcessSchemaSubProcess schemaNeedsAnalysis = new ProcessSchemaSubProcess(this) {
				UId = new Guid("c6385211-3b10-447a-8d34-e3f3605c4793"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"NeedsAnalysis",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1898, 128),
				SchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeNeedsAnalysisParameters(schemaNeedsAnalysis);
			return schemaNeedsAnalysis;
		}

		protected virtual ProcessSchemaSubProcess CreateOppManagementValuePpropositionSubProcess() {
			ProcessSchemaSubProcess schemaOppManagementValuePproposition = new ProcessSchemaSubProcess(this) {
				UId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"OppManagementValuePproposition",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1898, 219),
				SchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeOppManagementValuePpropositionParameters(schemaOppManagementValuePproposition);
			return schemaOppManagementValuePproposition;
		}

		protected virtual ProcessSchemaSubProcess CreateIdDecisionMakersSubProcess() {
			ProcessSchemaSubProcess schemaIdDecisionMakers = new ProcessSchemaSubProcess(this) {
				UId = new Guid("d58ab1aa-6acb-4539-9b28-cda203b74ced"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"IdDecisionMakers",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1898, 310),
				SchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeIdDecisionMakersParameters(schemaIdDecisionMakers);
			return schemaIdDecisionMakers;
		}

		protected virtual ProcessSchemaSubProcess CreateOppManagementPerceptionAnalysisSubProcess() {
			ProcessSchemaSubProcess schemaOppManagementPerceptionAnalysis = new ProcessSchemaSubProcess(this) {
				UId = new Guid("da8227c5-5602-4a29-b848-1fb1e6b57440"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"OppManagementPerceptionAnalysis",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1905, 639),
				SchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeOppManagementPerceptionAnalysisParameters(schemaOppManagementPerceptionAnalysis);
			return schemaOppManagementPerceptionAnalysis;
		}

		protected virtual ProcessSchemaSubProcess CreateOppManagementProposalSubProcess() {
			ProcessSchemaSubProcess schemaOppManagementProposal = new ProcessSchemaSubProcess(this) {
				UId = new Guid("e3b6949a-0754-40f7-a369-1f69dae8bc2d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"OppManagementProposal",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1905, 723),
				SchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeOppManagementProposalParameters(schemaOppManagementProposal);
			return schemaOppManagementProposal;
		}

		protected virtual ProcessSchemaSubProcess CreateOppManagementNegotiationsSubProcess() {
			ProcessSchemaSubProcess schemaOppManagementNegotiations = new ProcessSchemaSubProcess(this) {
				UId = new Guid("2bd13ebc-d0be-488e-9dff-abea5ba029d2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"OppManagementNegotiations",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1905, 807),
				SchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeOppManagementNegotiationsParameters(schemaOppManagementNegotiations);
			return schemaOppManagementNegotiations;
		}

		protected virtual ProcessSchemaSubProcess CreateOppManagementContractationSubProcess() {
			ProcessSchemaSubProcess schemaOppManagementContractation = new ProcessSchemaSubProcess(this) {
				UId = new Guid("8cd60286-ecaa-4f5c-aa25-62e4f4b7ee26"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"OppManagementContractation",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1905, 891),
				SchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeOppManagementContractationParameters(schemaOppManagementContractation);
			return schemaOppManagementContractation;
		}

		protected virtual ProcessSchemaSubProcess CreateOppManagementEndStageSubProcess() {
			ProcessSchemaSubProcess schemaOppManagementEndStage = new ProcessSchemaSubProcess(this) {
				UId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"OppManagementEndStage",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2213, 569),
				SchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeOppManagementEndStageParameters(schemaOppManagementEndStage);
			return schemaOppManagementEndStage;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("4ba680da-7591-4eb5-8ede-25d1558e9149"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(638, 569),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateFindPresentationUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"FindPresentation",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(778, 569),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeFindPresentationParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateSavePresentationParameter2FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("d8643dcc-9a0d-40a5-abbb-c08fc8ced26b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"SavePresentationParameter2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(939, 653),
				ResultParameterMetaPath = @"0eae6fcc-65b6-433e-b4dc-e42323c488c1",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,177,10,131,48,16,128,225,135,113,190,146,152,196,156,174,197,161,83,11,29,197,225,46,185,208,130,166,160,150,82,196,119,175,174,221,126,126,248,186,162,187,204,215,79,150,233,30,30,50,82,147,104,152,165,63,237,247,111,180,131,140,146,151,102,141,228,3,51,42,8,209,41,176,138,13,32,154,0,85,114,6,109,42,173,71,218,118,112,163,137,70,89,100,106,86,14,209,160,209,30,8,177,4,123,20,34,106,224,82,51,38,21,200,121,62,72,155,151,231,242,61,191,134,247,152,155,149,68,137,117,129,32,216,218,129,77,178,123,83,71,48,196,190,244,40,186,210,126,235,139,254,7,38,198,222,228,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateLinkOppToProcessUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"LinkOppToProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1107, 569),
				SchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeLinkOppToProcessParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadOppMainContactUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ReadOppMainContact",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1422, 569),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadOppMainContactParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateSaveMainContactParameterFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("90ba94c4-778e-4da8-b1fa-20caa11d06b9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"SaveMainContactParameter",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1534, 569),
				ResultParameterMetaPath = @"b8d6c762-b63e-49b7-b651-c8d29f9c8d74",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,145,61,75,3,81,16,69,255,202,66,26,45,70,246,125,191,89,8,22,18,196,74,193,50,164,152,55,111,6,3,217,85,146,13,18,66,254,187,47,109,236,44,109,47,28,230,158,59,119,207,199,109,125,88,141,95,243,169,91,46,187,245,98,253,114,120,253,158,100,255,206,31,50,210,160,180,59,200,230,161,165,55,193,106,39,163,76,243,112,238,57,153,204,182,135,108,163,7,79,53,3,113,80,176,194,46,146,69,242,152,47,13,120,163,61,141,50,203,126,56,71,83,163,250,96,192,231,138,224,25,35,160,73,5,52,114,96,201,161,106,118,87,100,53,205,219,249,244,244,185,59,142,83,163,60,245,161,40,129,11,125,5,95,139,66,209,118,77,75,72,72,201,171,67,185,108,22,155,251,238,241,47,30,28,69,201,9,1,171,231,230,33,9,114,239,20,56,132,204,198,99,37,235,111,60,146,152,34,182,85,64,35,173,17,18,66,177,24,26,103,92,84,235,107,31,236,111,15,138,54,87,71,4,9,99,155,0,189,131,156,99,129,198,132,182,76,229,182,199,213,163,27,254,197,59,126,0,19,38,209,124,98,2,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignalLeadStageChangeStartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("a3374f46-5620-4706-95ae-1144c8bbbf48"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"StartSignalLeadStageChange",
				NewEntityChangedColumns = false,
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(53, 60),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("bc0c2d60-5a3d-4840-aa4e-c60ea776e206");
			InitializeStartSignalLeadStageChangeParameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("ef1d55e6-1755-412a-9d7c-f01d78a5edf9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(80, 310),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaStartEvent CreateStartOppBusinessProcessStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("cc1b7702-073c-45cc-926b-05e107a8fd30"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"StartOppBusinessProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(313, 583),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaUserTask CreateOpenEditPageUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"OpenEditPageUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(631, 772),
				SchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeOpenEditPageUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway4ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("69c50fcc-abf2-43ac-a9d1-e9e6ed6a5397"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ExclusiveGateway4",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(778, 772),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate4TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("129d65ec-f59b-44af-b1d6-cda0a6b4ff21"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"Terminate4",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(792, 877),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("ad47ec52-76d5-44c0-b66d-9440119348ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"FormulaTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1107, 772),
				ResultParameterMetaPath = @"af8eea9e-0e11-426e-a870-2cff33d00f84",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,173,14,195,32,20,64,225,135,169,190,11,255,3,252,68,213,150,76,54,136,123,225,146,137,82,65,155,76,52,125,247,161,103,191,156,179,76,203,188,63,191,27,247,119,254,112,195,88,113,221,57,221,134,254,193,99,229,198,219,17,79,146,66,107,69,5,212,29,13,24,71,25,48,4,1,213,134,130,33,23,34,101,175,49,188,176,99,227,131,123,60,179,173,162,184,81,23,233,9,140,113,12,94,107,11,210,87,18,94,84,231,4,94,105,74,63,188,126,6,30,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask2FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("54731090-57ce-4f13-a4f0-8398e8e5479f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1c4add4a-0186-4391-8d42-9694825ccb10"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"FormulaTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2003, 219),
				ResultParameterMetaPath = @"0eae6fcc-65b6-433e-b4dc-e42323c488c1",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,47,205,76,209,115,205,45,40,169,4,0,200,160,7,199,10,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateStoreIsStageChangedByUserFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"StoreIsStageChangedByUser",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(2080, 569),
				ResultParameterMetaPath = @"9786c0e4-cc5f-4c9f-b46d-090a297e2b74",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,148,189,110,21,48,12,133,95,5,137,217,200,177,29,199,233,206,192,4,18,99,213,193,78,28,49,208,14,45,18,3,237,187,227,59,114,153,224,102,204,143,252,249,156,227,220,191,191,255,244,242,249,231,83,62,127,93,223,242,209,239,142,127,127,201,135,15,181,123,181,241,241,123,62,230,211,143,187,95,184,35,189,79,135,129,220,64,252,8,248,12,131,61,117,167,183,197,93,215,91,61,248,226,207,254,152,63,242,249,238,87,6,77,23,36,232,219,59,200,153,1,38,178,32,199,60,146,237,180,214,253,237,225,253,195,187,215,215,119,247,255,78,180,148,173,83,107,192,209,16,68,134,131,109,22,72,62,172,216,151,140,201,87,68,234,134,60,41,96,13,27,32,195,12,188,51,193,89,78,60,48,216,4,47,68,255,7,164,222,7,179,35,164,74,73,212,199,132,208,189,0,251,217,187,161,111,205,125,5,20,132,3,187,43,184,197,2,81,220,96,108,19,188,214,140,110,145,77,111,144,104,119,243,104,238,160,190,162,136,120,194,12,50,88,219,9,57,134,172,191,136,82,145,44,122,2,34,109,144,88,3,98,149,170,230,231,236,206,227,32,174,91,136,220,136,198,234,208,171,78,197,136,74,35,19,131,118,162,165,70,31,114,113,224,15,34,42,83,79,164,1,13,169,38,150,38,152,109,131,193,56,78,103,91,39,243,6,162,228,208,41,21,108,28,93,64,240,12,112,214,89,68,58,183,103,249,66,215,26,209,196,106,66,55,120,156,210,232,108,42,163,79,117,210,99,59,210,169,83,186,129,136,98,55,206,202,195,198,72,16,179,132,185,207,169,106,53,129,81,5,230,166,43,34,174,251,51,39,130,182,178,78,90,69,220,52,78,13,196,60,186,204,184,185,221,64,100,107,95,98,161,144,171,194,36,167,175,74,40,117,80,74,57,18,35,147,244,138,168,169,181,190,43,66,202,189,70,45,82,96,146,214,55,160,57,125,206,196,201,113,33,250,13,190,203,223,63,139,4,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateResetIsStageChangedByUserFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("c07da6a9-f9fc-4d1b-a11d-633a4992ae39"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ResetIsStageChangedByUser",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1660, 569),
				ResultParameterMetaPath = @"9786c0e4-cc5f-4c9f-b46d-090a297e2b74",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,75,204,41,78,5,0,48,104,205,43,5,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataLeadUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ReadDataLead",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(204, 310),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataLeadParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataLeadUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ChangeDataLead",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1505, 150),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeDataLeadParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewaySetDateTimePresentationExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("f7a393e4-d550-4f6e-aba4-c4a007307258"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ExclusiveGatewaySetDateTimePresentation",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1393, 150),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate2TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("375b9e3c-98fc-4100-83c4-c571cfe22b08"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"Terminate2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(225, 163),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataContactToOpportunityUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"AddDataContactToOpportunity",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1640, 20),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddDataContactToOpportunityParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayLeadQualifiedAsContactExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("c017a416-4566-4caf-89f0-cd11dc760d58"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ExclusiveGatewayLeadQualifiedAsContact",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1520, 20),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataOpportunityUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"AddDataOpportunity",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1260, 20),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddDataOpportunityParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataCountOpportunityByAccountUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ReadDataCountOpportunityByAccount",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(862, 310),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataCountOpportunityByAccountParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataAccountUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ReadDataAccount",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(617, 310),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataAccountParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTaskAccountByLeadFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("ab3f8e00-ffa9-4079-8f2d-c9aa8b4b4826"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"FormulaTaskAccountByLead",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(498, 310),
				ResultParameterMetaPath = @"342aec56-8359-4c5b-826b-9e8489fd6a4b",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,177,10,194,48,16,0,208,143,113,62,73,210,187,54,201,42,29,156,20,28,75,135,107,114,65,161,169,208,86,68,74,255,221,184,186,62,120,221,161,59,47,151,247,36,243,45,220,37,179,79,60,46,210,31,139,254,65,59,74,150,105,245,91,18,140,214,138,2,172,41,0,218,129,193,233,33,128,184,40,17,105,168,2,169,189,132,43,207,156,101,149,217,111,17,81,87,41,50,136,81,84,138,14,96,141,141,48,160,212,141,170,117,163,77,250,149,118,90,31,235,231,244,28,95,121,242,91,101,28,58,22,132,148,116,85,86,34,112,137,34,32,113,131,68,86,152,104,239,15,253,23,82,182,133,99,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataContactUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ReadDataContact",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(617, 149),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataContactParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayQualifiedByAccountExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("ba7fb0fc-f887-4dd2-9494-28335297b5e4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ExclusiveGatewayQualifiedByAccount",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(372, 310),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaFormulaTask CreateSaveCurrOppParameterFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("0b3df41d-a31f-4753-9ad5-bb8d4c5137fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"SaveCurrOppParameter",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1386, 311),
				ResultParameterMetaPath = @"af8eea9e-0e11-426e-a870-2cff33d00f84",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,177,10,195,32,16,0,208,143,201,124,165,156,198,139,238,29,58,165,208,49,56,156,222,73,135,152,193,4,58,132,252,123,157,187,62,120,203,176,60,247,249,187,105,123,231,143,86,14,133,215,93,227,173,235,31,60,86,173,186,29,225,180,118,44,110,82,132,36,119,3,150,172,3,118,68,96,144,82,82,34,44,46,95,61,188,184,113,213,67,91,56,197,101,195,50,121,32,227,9,172,72,47,136,30,202,136,90,56,25,177,38,93,113,136,63,181,94,204,26,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreatePresentationTaskCreationUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"PresentationTaskCreation",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1260, 150),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializePresentationTaskCreationParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateSavePresentationParameterFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("a914a2b0-15d2-4c81-938d-6f3bcc01c912"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"SavePresentationParameter",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1260, 241),
				ResultParameterMetaPath = @"0eae6fcc-65b6-433e-b4dc-e42323c488c1",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,173,14,194,48,20,6,208,135,153,190,164,244,111,185,245,8,20,36,200,165,226,222,242,53,136,117,162,91,130,88,246,238,76,99,79,114,166,97,186,175,143,239,130,254,42,31,52,73,85,230,21,249,114,234,31,220,102,52,44,91,218,125,168,170,163,97,82,120,38,207,65,72,48,26,170,5,142,237,187,132,104,202,113,134,167,116,105,216,208,211,238,212,121,182,49,82,17,5,121,41,76,172,162,196,6,65,152,149,221,213,30,121,200,63,255,140,172,32,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadOppoortunityData2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("feedf149-5e02-44a6-b2c6-d31a10db7744"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ReadOppoortunityData2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1645, 150),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadOppoortunityData2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbdfa4ab-c534-4027-a134-96b45d5b7770"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ReadDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1107, 430),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbdfa4ab-c534-4027-a134-96b45d5b7770"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"AddDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1271, 430),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("da838103-79ee-48ff-b9fb-43f5d9fb0543"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(372, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"ReadDataUserTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(862, 149),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask3FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("083b1a16-96f4-434c-bd21-1e475d6a546b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"FormulaTask3",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(988, 149),
				ResultParameterMetaPath = @"02b1469d-72ad-4909-a7cf-6b41b79d41a7",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,177,14,130,48,16,0,208,143,97,62,67,185,150,187,118,119,112,210,196,145,48,156,189,35,14,148,161,144,56,16,255,221,206,174,47,121,83,55,221,246,251,103,179,250,204,111,43,146,22,89,119,155,47,77,255,224,186,90,177,237,72,39,179,68,99,18,136,153,50,120,66,6,238,205,131,71,68,195,16,108,84,247,109,225,33,85,138,29,86,211,57,42,57,79,250,130,94,68,192,187,28,128,57,18,160,232,160,204,139,242,208,74,55,255,0,207,157,35,16,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask4FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("b120e00e-d3f2-4b09-8118-ef17c00af6bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"FormulaTask4",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(988, 310),
				ResultParameterMetaPath = @"02b1469d-72ad-4909-a7cf-6b41b79d41a7",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,177,14,194,32,16,0,208,143,233,124,70,188,131,30,236,14,78,154,56,54,12,7,28,113,40,29,104,19,135,166,255,110,103,215,151,188,105,152,30,235,243,187,104,127,231,143,54,9,85,230,85,227,229,212,63,184,207,218,116,217,194,158,172,225,76,226,128,144,5,40,97,2,246,236,193,120,66,29,179,43,104,175,199,25,94,210,165,233,166,61,236,194,152,213,27,4,84,203,64,37,49,36,235,16,70,115,171,84,77,53,133,234,17,135,248,3,216,229,173,9,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask5FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("cecd8639-1f00-4d59-b112-9fbe4de5517a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"FormulaTask5",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(736, 310),
				ResultParameterMetaPath = @"738ceb61-832b-4b27-a973-9347e26e827e",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,141,61,11,194,48,20,0,127,140,243,147,36,205,103,87,233,224,164,224,88,58,188,36,239,161,208,84,104,43,34,165,255,221,184,58,29,28,28,215,31,250,243,114,121,79,52,223,210,157,10,182,140,227,66,195,177,218,63,209,141,84,104,90,219,13,173,246,108,173,128,38,32,130,118,140,16,146,113,160,56,39,45,98,200,13,167,189,6,87,156,177,208,74,115,187,229,38,42,47,109,0,19,73,129,230,144,32,184,36,128,136,149,167,172,217,72,251,75,186,105,125,172,159,211,115,124,149,169,221,92,242,18,133,36,96,19,98,29,101,6,223,136,4,158,42,88,70,246,62,236,195,97,248,2,55,56,7,126,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask6FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("d527d260-953d-4177-b84b-fd337a8b9408"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"FormulaTask6",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(736, 149),
				ResultParameterMetaPath = @"738ceb61-832b-4b27-a973-9347e26e827e",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,187,10,194,48,20,0,208,143,113,190,146,230,157,172,210,193,73,193,177,116,184,73,110,80,104,34,180,17,145,210,127,183,174,174,7,206,112,24,206,203,229,93,105,190,197,59,21,244,25,167,133,198,227,174,127,208,79,84,168,54,191,146,205,150,132,203,64,74,56,144,204,26,64,169,29,32,23,193,201,46,68,45,205,182,135,43,206,88,168,209,236,215,132,200,28,37,3,28,77,2,41,21,3,20,12,33,37,139,177,211,145,33,211,191,210,215,246,104,159,211,115,122,149,234,87,84,49,162,113,28,164,73,251,226,22,193,138,28,64,69,199,67,74,206,228,108,183,241,48,126,1,146,45,47,48,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask7FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("e71860b5-b65b-493b-8d7c-c65ed80dc169"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7852560c-6de2-45bc-b542-143393a2f762"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"FormulaTask7",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(498, 149),
				ResultParameterMetaPath = @"b6534525-3848-4420-8930-e7bcc98a1756",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,205,177,10,194,48,16,128,225,135,113,62,73,154,75,122,201,42,29,156,20,28,75,135,36,119,69,161,141,208,86,68,74,223,221,186,186,254,240,241,183,135,246,60,95,222,69,166,91,190,203,24,67,31,135,89,186,227,94,255,66,51,200,40,101,9,107,47,200,68,162,0,157,205,128,148,34,120,157,50,136,103,97,180,201,100,171,182,29,92,227,20,71,89,100,10,43,35,106,211,115,4,169,148,221,137,206,64,21,49,36,20,87,43,167,107,93,245,63,210,148,229,177,124,78,207,225,53,150,176,70,70,175,216,18,40,139,17,246,169,5,95,161,3,102,66,231,36,25,79,102,235,14,221,23,218,197,238,43,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask8FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("7727ad4d-089b-417c-acfd-d66ee83afc06"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48537fce-e726-43c7-8dd9-691e0e0c228e"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"FormulaTask8",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1111, 149),
				ResultParameterMetaPath = @"b2b54e53-5309-4650-ac67-b8a4705d22b4",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,187,10,194,48,20,0,208,143,113,190,146,230,157,172,210,193,73,193,177,116,184,73,110,80,104,34,180,17,145,210,127,183,174,174,7,206,112,24,206,203,229,93,105,190,197,59,21,244,25,167,133,198,227,174,127,208,79,84,168,54,191,146,205,150,132,203,64,74,56,144,204,26,64,169,29,32,23,193,201,46,68,45,205,182,135,43,206,88,168,209,236,215,132,200,28,37,3,28,77,2,41,21,3,20,12,33,37,139,177,211,145,33,211,191,210,215,246,104,159,211,115,122,149,234,87,84,49,162,113,28,164,73,251,226,22,193,138,28,64,69,199,67,74,206,228,108,183,241,48,126,1,146,45,47,48,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask9FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("f284494f-5edb-489b-92c3-ddb20eaa0ab0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08258488-7269-4cb1-8e76-d67a44d8d892"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48537fce-e726-43c7-8dd9-691e0e0c228e"),
				CreatedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"),
				Name = @"FormulaTask9",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1113, 310),
				ResultParameterMetaPath = @"b2b54e53-5309-4650-ac67-b8a4705d22b4",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,141,61,11,194,48,20,0,127,140,243,147,36,205,103,87,233,224,164,224,88,58,188,36,239,161,208,84,104,43,34,165,255,221,184,58,29,28,28,215,31,250,243,114,121,79,52,223,210,157,10,182,140,227,66,195,177,218,63,209,141,84,104,90,219,13,173,246,108,173,128,38,32,130,118,140,16,146,113,160,56,39,45,98,200,13,167,189,6,87,156,177,208,74,115,187,229,38,42,47,109,0,19,73,129,230,144,32,184,36,128,136,149,167,172,217,72,251,75,186,105,125,172,159,211,115,124,149,169,221,92,242,18,133,36,96,19,98,29,101,6,223,136,4,158,42,88,70,246,62,236,195,97,248,2,55,56,7,126,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new OpportunityManagement(userConnection);
		}

		public override object Clone() {
			return new OpportunityManagementSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a5f68bdc-2044-42c4-8830-9965e224d704"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityManagement

	/// <exclude/>
	public class OpportunityManagement : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessOpportunityMangementProcess

		/// <exclude/>
		public class ProcessOpportunityMangementProcess : ProcessLane
		{

			public ProcessOpportunityMangementProcess(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadOppDataFlowElement

		/// <exclude/>
		public class ReadOppDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadOppDataFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadOppData";
				IsLogging = true;
				SchemaElementUId = new Guid("0c718c20-8264-4ad8-ac5f-2ec36a29a498");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,164,98,75,254,146,115,92,182,101,47,105,160,105,41,36,75,120,146,158,178,2,127,197,150,104,22,179,255,189,242,58,155,66,14,165,208,83,64,7,233,61,205,188,153,65,154,31,220,244,217,53,30,199,218,66,51,33,13,59,83,147,156,131,72,4,71,150,164,34,99,153,130,130,201,210,38,172,72,173,52,40,19,45,42,36,180,131,22,107,178,162,183,198,121,66,157,199,118,170,239,230,63,164,126,12,72,31,236,249,240,77,31,176,133,239,203,0,192,172,176,170,42,153,78,184,102,25,96,197,192,136,148,129,228,66,27,35,101,166,45,89,181,84,152,139,66,101,130,161,82,57,203,100,197,153,42,160,100,138,151,42,23,74,129,176,57,161,13,90,191,125,30,70,156,38,215,119,245,140,175,251,219,227,16,85,174,179,55,125,19,218,142,208,22,61,220,128,63,44,66,18,204,114,13,76,103,50,178,91,44,25,8,105,152,0,85,242,178,194,180,72,75,66,53,12,126,161,37,59,67,168,1,15,63,160,9,120,102,158,93,212,200,69,146,86,121,17,177,169,136,118,4,79,88,85,68,119,214,20,86,162,40,164,84,230,146,215,151,224,226,222,77,215,161,197,209,233,151,216,49,230,215,143,245,172,251,206,143,125,179,80,95,159,175,223,226,179,95,195,125,105,253,92,13,249,88,95,64,228,68,195,132,155,198,97,231,183,157,238,141,235,30,87,206,211,41,66,218,1,70,55,93,82,216,62,5,104,8,29,221,227,225,175,105,109,194,228,251,246,29,89,165,209,102,228,136,143,236,44,119,121,131,198,77,67,3,199,243,185,38,31,159,66,239,175,54,97,28,35,248,67,63,12,253,232,67,231,252,113,109,144,55,4,53,185,39,96,43,68,144,241,19,96,154,178,140,23,200,160,42,19,198,181,181,66,152,36,177,85,118,79,162,168,255,31,117,183,155,190,254,234,46,63,100,245,180,255,20,171,111,10,55,23,100,61,255,139,186,211,126,209,183,63,197,245,27,208,129,205,245,232,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,201,44,201,73,181,50,180,50,212,241,76,177,50,176,50,0,0,169,240,29,88,16,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ProspectingFlowElement

		/// <exclude/>
		public class ProspectingFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public ProspectingFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("7fce678b-995e-4c53-9b43-ec2f04fae40f");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagement)owner;
				Name = "Prospecting";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("0dbea59a-7031-4af4-a9b8-d96dea1c356c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagement)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
			}

			#endregion

		}

		#endregion

		#region Class: NeedsAnalysisFlowElement

		/// <exclude/>
		public class NeedsAnalysisFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public NeedsAnalysisFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagement)owner;
				Name = "NeedsAnalysis";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("c6385211-3b10-447a-8d34-e3f3605c4793");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagement)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
				SetParameterValue("MainContact", (Guid)((process.MainContact)));
			}

			#endregion

		}

		#endregion

		#region Class: OppManagementValuePpropositionFlowElement

		/// <exclude/>
		public class OppManagementValuePpropositionFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public OppManagementValuePpropositionFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("58cbaf95-b8d9-4650-8919-16e8dfa26bef");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid Presentation {
				get {
					return GetParameterValue<Guid>("Presentation");
				}
				set {
					SetParameterValue("Presentation", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagement)owner;
				Name = "OppManagementValuePproposition";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("6a5733a0-e641-4579-b6dc-05fdd10ad6ed");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagement)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
				SetParameterValue("Presentation", (Guid)((process.Presentation)));
				SetParameterValue("MainContact", (Guid)((process.MainContact)));
			}

			#endregion

		}

		#endregion

		#region Class: IdDecisionMakersFlowElement

		/// <exclude/>
		public class IdDecisionMakersFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public IdDecisionMakersFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("c1ab3a28-ca5a-4a5a-8b66-0426e04e71c9");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagement)owner;
				Name = "IdDecisionMakers";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("d58ab1aa-6acb-4539-9b28-cda203b74ced");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagement)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
				SetParameterValue("MainContact", (Guid)((process.MainContact)));
			}

			#endregion

		}

		#endregion

		#region Class: OppManagementPerceptionAnalysisFlowElement

		/// <exclude/>
		public class OppManagementPerceptionAnalysisFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public OppManagementPerceptionAnalysisFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagement)owner;
				Name = "OppManagementPerceptionAnalysis";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("da8227c5-5602-4a29-b848-1fb1e6b57440");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagement)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
				SetParameterValue("MainContact", (Guid)((process.MainContact)));
			}

			#endregion

		}

		#endregion

		#region Class: OppManagementProposalFlowElement

		/// <exclude/>
		public class OppManagementProposalFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public OppManagementProposalFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("032a799f-99c9-4e9d-8d1c-810f447a7791");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagement)owner;
				Name = "OppManagementProposal";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("e3b6949a-0754-40f7-a369-1f69dae8bc2d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagement)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
				SetParameterValue("MainContact", (Guid)((process.MainContact)));
			}

			#endregion

		}

		#endregion

		#region Class: OppManagementNegotiationsFlowElement

		/// <exclude/>
		public class OppManagementNegotiationsFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public OppManagementNegotiationsFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("01359e67-5d64-45ca-9679-be70642e4ebc");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagement)owner;
				Name = "OppManagementNegotiations";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("2bd13ebc-d0be-488e-9dff-abea5ba029d2");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagement)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
			}

			#endregion

		}

		#endregion

		#region Class: OppManagementContractationFlowElement

		/// <exclude/>
		public class OppManagementContractationFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public OppManagementContractationFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("b7ae2d23-17b7-4dca-bd06-4ac79c6dd368");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public bool OpportunityStageChanged {
				get {
					return GetParameterValue<bool>("OpportunityStageChanged");
				}
				set {
					SetParameterValue("OpportunityStageChanged", value);
				}
			}

			public Guid MainContact {
				get {
					return GetParameterValue<Guid>("MainContact");
				}
				set {
					SetParameterValue("MainContact", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagement)owner;
				Name = "OppManagementContractation";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("8cd60286-ecaa-4f5c-aa25-62e4f4b7ee26");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagement)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
			}

			#endregion

		}

		#endregion

		#region Class: OppManagementEndStageFlowElement

		/// <exclude/>
		public class OppManagementEndStageFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public OppManagementEndStageFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8");
			}

			#endregion

			#region Properties: Public

			public Guid CurrentOpportunity {
				get {
					return GetParameterValue<Guid>("CurrentOpportunity");
				}
				set {
					SetParameterValue("CurrentOpportunity", value);
				}
			}

			public int NextOpportunityStageNumber {
				get {
					return GetParameterValue<int>("NextOpportunityStageNumber");
				}
				set {
					SetParameterValue("NextOpportunityStageNumber", value);
				}
			}

			public Guid CurrentStage {
				get {
					return GetParameterValue<Guid>("CurrentStage");
				}
				set {
					SetParameterValue("CurrentStage", value);
				}
			}

			public LocalizableString Recommendation {
				get {
					return GetParameterValue<LocalizableString>("Recommendation");
				}
				set {
					SetParameterValue("Recommendation", value);
				}
			}

			public bool IsStageChangedByUser {
				get {
					return GetParameterValue<bool>("IsStageChangedByUser");
				}
				set {
					SetParameterValue("IsStageChangedByUser", value);
				}
			}

			public bool DontShowPageEndOfStage {
				get {
					return GetParameterValue<bool>("DontShowPageEndOfStage");
				}
				set {
					SetParameterValue("DontShowPageEndOfStage", value);
				}
			}

			public Guid NextStage {
				get {
					return GetParameterValue<Guid>("NextStage");
				}
				set {
					SetParameterValue("NextStage", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (OpportunityManagement)owner;
				Name = "OppManagementEndStage";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("a3d82030-af23-488b-b015-0c48be2056d9");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (OpportunityManagement)Owner;
				SetParameterValue("CurrentOpportunity", (Guid)((process.CurrentOpportunity)));
				SetParameterValue("IsStageChangedByUser", (bool)((process.IsStageChangedByUser)));
			}

			#endregion

		}

		#endregion

		#region Class: FindPresentationFlowElement

		/// <exclude/>
		public class FindPresentationFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public FindPresentationFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "FindPresentation";
				IsLogging = true;
				SchemaElementUId = new Guid("da7cbb80-cd50-40b3-883c-6f5384f2478a");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,150,91,107,27,71,20,199,191,138,217,135,62,237,148,185,156,185,169,143,198,5,67,235,4,146,150,66,48,225,204,204,25,123,137,164,85,118,103,105,141,208,119,239,172,100,37,34,56,174,235,150,22,67,222,246,118,238,255,223,156,221,190,239,198,31,187,101,161,97,145,113,57,82,59,93,166,69,67,90,123,155,2,48,138,206,49,136,100,153,11,153,179,132,92,56,145,188,78,33,52,237,26,87,180,104,14,214,23,169,43,77,219,21,90,141,139,119,219,207,78,203,48,81,251,62,239,111,222,196,91,90,225,47,115,128,8,224,147,83,146,33,196,200,32,112,193,130,79,154,57,20,50,130,68,159,157,111,14,185,72,97,162,228,200,153,204,222,51,72,193,50,31,92,100,58,129,163,168,29,96,112,77,187,164,92,46,254,216,12,52,142,93,191,94,108,233,211,245,219,187,77,205,242,16,251,188,95,78,171,117,211,174,168,224,107,44,183,53,17,151,28,100,31,89,0,23,24,88,31,152,199,104,24,128,144,89,129,50,17,101,211,70,220,148,217,109,243,166,96,153,198,166,29,40,211,64,235,72,39,53,57,174,17,35,1,115,134,3,3,94,155,134,158,2,227,89,131,176,160,189,138,188,105,19,22,252,21,151,19,237,243,218,118,213,48,72,175,185,21,153,89,194,90,33,25,201,92,18,200,188,240,33,43,171,100,206,242,216,237,159,250,254,195,180,169,157,30,175,166,21,13,93,188,31,27,213,254,247,195,98,27,251,117,25,250,229,236,252,234,196,224,48,158,251,151,191,29,90,178,220,191,153,13,155,93,59,141,116,190,236,104,93,46,214,177,79,221,250,102,63,185,221,174,218,172,54,56,116,227,177,145,23,31,39,92,214,6,116,55,183,143,54,252,53,14,53,126,157,250,75,43,185,221,28,51,223,231,60,203,57,117,227,102,137,119,251,251,69,243,221,199,169,47,63,92,174,207,54,67,127,51,215,124,120,208,124,97,120,252,80,121,72,16,28,48,237,200,176,148,133,96,222,138,42,11,46,146,225,228,149,139,230,222,195,174,125,48,212,85,95,206,170,240,134,66,233,47,66,185,167,135,186,174,179,253,87,57,85,65,101,97,156,103,201,217,122,102,240,96,152,231,150,87,88,5,130,204,73,57,238,159,207,169,6,47,162,82,153,145,151,182,158,72,232,24,106,91,131,129,19,156,80,67,212,230,132,211,217,217,195,148,90,29,32,169,138,185,214,105,174,40,153,89,121,156,169,12,30,181,75,222,68,251,210,36,251,141,210,175,81,250,22,199,15,143,51,147,3,113,140,85,10,49,71,126,96,38,112,158,255,27,102,16,149,140,152,171,170,73,11,6,18,76,53,226,188,126,31,129,156,161,228,140,248,39,187,77,64,70,43,24,241,122,8,128,146,154,97,221,119,117,134,128,210,43,74,66,185,19,102,206,177,208,77,63,220,61,204,141,55,130,36,119,53,65,33,171,179,84,41,12,220,235,25,116,65,6,146,137,223,182,219,11,40,249,137,220,252,76,84,170,205,227,232,128,140,22,34,248,255,101,221,132,168,181,179,220,176,108,98,93,55,214,26,22,172,79,76,10,72,100,73,24,46,229,243,209,1,179,95,165,88,115,48,179,218,231,225,169,28,152,229,20,37,102,74,218,230,19,116,94,109,54,253,80,166,117,87,190,66,15,18,152,28,156,101,145,203,90,24,82,93,95,73,137,250,131,40,85,76,201,123,136,249,165,73,233,249,244,156,79,99,233,87,47,173,222,39,162,115,62,13,117,250,229,172,255,172,137,199,49,194,236,168,22,75,140,147,152,151,128,33,134,85,217,76,198,156,149,74,117,25,57,120,252,7,241,111,135,124,119,57,190,250,125,125,68,239,208,182,235,239,235,211,47,30,124,58,230,22,219,167,100,185,187,62,193,253,122,247,39,24,125,65,165,92,14,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: LinkOppToProcessFlowElement

		/// <exclude/>
		public class LinkOppToProcessFlowElement : LinkEntityToProcessUserTask
		{

			#region Constructors: Public

			public LinkOppToProcessFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LinkOppToProcess";
				IsLogging = true;
				SchemaElementUId = new Guid("2a573100-970f-4c01-a74a-b5c18590a797");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_entityId = () => (Guid)((process.CurrentOpportunity));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _entityId;
			public override Guid EntityId {
				get {
					return (_entityId ?? (_entityId = () => Guid.Empty)).Invoke();
				}
				set {
					_entityId = () => { return value; };
				}
			}

			private Guid _entitySchemaId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadOppMainContactFlowElement

		/// <exclude/>
		public class ReadOppMainContactFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadOppMainContactFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadOppMainContact";
				IsLogging = true;
				SchemaElementUId = new Guid("c6efa3ea-cf4c-4ae7-803f-c558c149da24");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,203,106,220,48,20,253,149,224,69,87,86,145,37,217,146,220,93,134,41,4,74,18,232,131,66,24,194,149,116,149,49,241,99,98,203,52,97,152,127,175,236,201,36,97,8,165,165,217,100,167,135,239,209,185,231,158,227,237,117,53,124,174,234,128,125,233,161,30,48,29,207,92,153,168,76,107,170,20,37,90,74,65,4,102,142,232,130,229,4,140,144,76,231,40,152,214,73,218,66,131,101,178,175,94,186,42,36,105,21,176,25,202,171,237,51,104,232,71,76,175,253,188,249,106,215,216,192,247,233,1,15,76,10,207,29,201,37,112,34,4,34,49,133,16,196,105,46,68,6,60,115,200,146,61,23,83,24,235,169,245,68,50,231,137,96,185,38,144,83,30,43,51,42,12,230,76,170,248,105,141,62,44,239,55,61,14,67,213,181,229,22,159,214,223,30,54,145,229,254,237,69,87,143,77,155,164,13,6,184,132,176,46,147,92,228,38,19,14,136,5,85,16,1,146,69,116,229,73,238,192,115,160,198,120,71,147,212,194,38,76,176,201,197,102,211,245,97,108,171,240,144,164,61,122,236,177,181,248,162,49,64,81,120,163,36,177,148,217,136,135,138,128,227,25,1,205,184,117,78,107,97,125,146,58,8,240,3,234,17,103,114,219,106,106,51,234,74,101,22,219,68,208,81,242,130,17,229,50,32,58,211,198,115,201,153,247,236,32,249,151,174,187,29,55,81,238,225,124,108,176,175,236,227,236,48,14,161,235,203,173,237,218,208,119,245,4,126,254,162,96,63,163,199,203,159,123,93,234,249,102,42,76,118,233,56,224,162,174,176,13,203,214,118,174,106,111,230,241,237,118,177,166,217,64,95,13,7,53,151,119,35,212,81,128,234,102,253,71,213,23,227,16,186,230,189,245,155,198,94,35,76,116,236,204,121,50,180,171,134,77,13,15,243,190,76,62,220,141,93,248,180,24,251,56,253,112,210,61,123,98,127,145,28,1,28,10,192,43,140,205,34,161,152,101,209,201,5,18,80,146,18,102,189,231,220,81,234,149,120,68,216,165,111,243,228,213,217,112,241,171,61,68,111,47,219,234,99,60,61,58,184,60,84,151,219,191,97,185,91,29,120,174,162,59,222,52,238,17,223,107,149,115,226,164,87,68,56,147,17,69,181,38,86,3,231,168,105,94,228,254,63,226,110,105,97,24,32,145,118,250,177,249,24,124,165,115,70,140,228,90,105,206,114,86,168,23,113,191,236,171,6,250,135,147,201,67,96,195,171,70,214,212,20,185,137,92,35,241,152,248,76,68,194,82,106,194,4,163,113,1,94,83,121,48,242,105,215,213,8,237,63,56,121,177,70,123,123,218,221,31,251,216,78,231,38,158,191,230,226,25,243,63,98,251,228,134,247,213,240,43,185,61,78,197,228,207,217,180,171,221,111,167,91,127,183,250,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,205,79,201,76,203,76,77,241,207,179,50,178,50,212,241,76,177,50,176,50,0,0,136,48,240,252,21,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			private string _entityColumnMetaPathes;
			public override string EntityColumnMetaPathes {
				get {
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,5,193,65,1,0,32,8,3,192,68,123,224,112,64,28,132,254,25,188,107,157,92,118,35,74,6,47,39,50,245,96,212,149,237,206,148,62,148,174,20,226,36,0,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: OpenEditPageUserTask1FlowElement

		/// <exclude/>
		public class OpenEditPageUserTask1FlowElement : OpenEditPageUserTask
		{

			#region Constructors: Public

			public OpenEditPageUserTask1FlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("b10332bd-27a4-46bc-a990-f59da9cdbb25");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.OpportunityMangementProcess;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private Guid _objectSchemaId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			public override Guid ObjectSchemaId {
				get {
					return _objectSchemaId;
				}
				set {
					_objectSchemaId = value;
				}
			}

			private Guid _pageSchemaId = new Guid("df249c13-df7a-48d2-b128-85183c4a0e10");
			public override Guid PageSchemaId {
				get {
					return _pageSchemaId;
				}
				set {
					_pageSchemaId = value;
				}
			}

			private int _editMode = 0;
			public override int EditMode {
				get {
					return _editMode;
				}
				set {
					_editMode = value;
				}
			}

			private bool _isMatchConditions = false;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private bool _generateDecisionsFromColumn = false;
			public override bool GenerateDecisionsFromColumn {
				get {
					return _generateDecisionsFromColumn;
				}
				set {
					_generateDecisionsFromColumn = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("a5f68bdc204442c488309965e224d704",
						 "BaseElements.OpenEditPageUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataLeadFlowElement

		/// <exclude/>
		public class ReadDataLeadFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataLeadFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataLead";
				IsLogging = true;
				SchemaElementUId = new Guid("fe4d88e0-465c-48ba-91bc-e9ded45b3c50");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,43,139,14,61,89,193,31,178,44,185,167,18,182,101,161,164,161,77,75,33,187,132,145,52,202,10,252,177,177,100,146,96,246,191,87,94,103,91,200,161,228,210,67,193,7,205,72,239,205,123,143,241,116,231,252,71,215,4,28,106,11,141,199,100,220,152,154,100,210,90,142,105,74,139,74,48,202,84,165,169,50,105,78,83,166,75,101,109,145,231,138,145,164,131,22,107,178,160,215,198,5,146,184,128,173,175,111,167,63,164,97,24,49,185,179,167,226,155,222,99,11,223,231,1,44,3,43,36,74,90,149,169,162,12,149,162,66,131,166,145,91,42,206,4,203,80,147,69,11,151,69,202,115,163,169,182,149,165,76,8,67,21,207,128,102,25,67,109,173,180,188,200,73,210,160,13,235,167,195,128,222,187,190,171,39,252,125,190,121,62,68,149,203,236,203,190,25,219,142,36,45,6,184,134,176,175,9,96,138,172,212,64,53,147,37,101,22,43,10,133,52,180,0,85,229,149,192,140,103,21,73,52,28,194,76,75,54,134,36,6,2,252,128,102,196,19,243,228,162,198,188,72,51,81,242,136,205,10,77,89,145,167,84,112,81,81,107,184,149,88,112,41,149,57,231,245,105,116,241,236,252,213,216,226,224,244,75,236,24,243,235,135,122,210,125,23,134,190,153,169,175,78,207,111,240,41,44,225,190,92,253,92,12,133,216,159,65,228,152,140,30,47,27,135,93,88,119,186,55,174,187,95,56,143,199,8,105,15,48,56,127,78,97,253,48,66,67,146,193,221,239,255,154,214,229,232,67,223,254,71,86,147,104,51,114,196,37,59,201,157,119,208,56,127,104,224,249,84,215,228,221,195,216,135,247,159,17,204,202,7,184,199,122,181,221,46,189,15,143,224,66,100,90,121,104,240,220,188,248,138,186,31,204,106,99,150,154,188,26,80,147,45,129,162,168,152,101,156,150,60,134,192,170,148,83,89,2,206,139,201,180,80,74,89,38,46,140,146,168,132,102,20,88,145,81,6,144,81,137,200,104,41,82,203,173,197,76,72,190,37,209,217,191,215,123,187,241,95,30,187,243,111,184,4,183,187,136,221,87,141,117,131,109,76,184,158,222,98,240,24,1,215,231,81,245,244,22,187,199,221,108,120,119,140,223,47,96,108,124,62,126,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,241,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,197,68,70,233,19,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ChangeDataLeadFlowElement

		/// <exclude/>
		public class ChangeDataLeadFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataLeadFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataLead";
				IsLogging = true;
				SchemaElementUId = new Guid("4174120c-c7f0-4e56-9ca1-71be449af2d1");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Opportunity = () => (Guid)((process.AddDataOpportunity.RecordId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Opportunity", () => _recordColumnValues_Opportunity.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Opportunity;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private bool _isMatchConditions = true;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,93,107,219,48,20,253,43,65,15,123,178,130,63,100,125,120,143,193,29,121,233,202,214,141,65,27,138,62,174,26,129,108,167,182,204,90,76,254,251,228,56,217,160,15,35,79,131,129,49,146,236,115,238,61,71,231,78,79,110,184,113,62,64,95,89,233,7,72,198,173,169,16,0,147,52,215,6,231,196,8,76,88,193,176,96,165,198,5,213,25,37,37,48,81,50,148,180,178,129,10,45,232,218,184,128,18,23,160,25,170,135,233,15,105,232,71,72,158,236,105,243,85,239,161,145,223,230,2,36,147,150,11,16,152,149,169,194,4,148,194,92,75,141,173,45,132,162,132,147,12,52,58,247,66,129,105,158,26,204,152,178,152,112,41,176,52,156,97,150,131,42,121,206,210,82,151,40,241,96,67,253,122,232,97,24,92,215,86,19,252,94,223,191,29,98,151,75,237,77,231,199,166,69,73,3,65,222,201,176,175,144,132,20,72,169,37,214,68,148,152,88,96,88,22,194,224,66,42,150,51,14,25,205,162,82,45,15,97,166,69,91,131,18,35,131,252,46,253,8,39,230,201,197,30,243,34,205,120,73,35,54,43,52,38,69,158,98,78,99,143,214,80,43,160,160,66,40,115,241,235,211,232,226,218,13,183,99,3,189,211,103,219,33,250,215,245,213,164,187,54,244,157,159,169,111,79,191,223,195,107,88,204,61,127,250,177,8,10,241,124,6,161,99,50,14,176,241,14,218,80,183,186,51,174,125,94,56,143,199,8,105,14,178,119,195,197,133,250,101,148,30,37,189,123,222,255,213,173,205,56,132,174,249,143,164,38,81,102,228,136,33,59,181,59,103,208,184,225,224,229,219,105,95,161,15,47,99,23,62,126,1,105,86,126,126,205,202,214,55,174,31,194,106,14,237,170,179,171,232,192,232,67,228,92,233,206,123,208,243,141,175,183,102,65,162,119,21,42,244,136,44,16,195,57,164,152,208,56,27,132,43,137,69,166,52,6,97,192,144,82,21,186,76,215,134,144,172,176,70,98,200,211,24,48,158,105,204,115,110,176,34,64,89,26,211,149,229,118,125,77,10,31,81,212,255,15,84,61,108,135,207,63,219,203,180,46,254,238,214,241,244,221,65,237,161,137,23,81,77,215,216,112,140,128,187,75,169,106,186,198,148,25,82,183,193,133,183,101,106,171,233,26,151,142,187,217,167,221,49,62,191,0,138,129,16,15,219,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,207,111,218,48,20,254,87,144,219,35,70,137,109,236,56,183,169,221,1,169,221,208,218,245,82,56,60,219,207,107,164,144,32,39,108,98,40,255,251,140,129,1,221,118,153,15,137,242,156,239,199,243,251,188,35,183,253,118,141,164,36,207,24,2,116,173,239,39,119,109,192,201,60,180,22,187,110,242,208,90,168,171,159,96,106,156,67,128,21,246,24,94,160,222,96,247,80,117,253,120,116,13,35,99,114,251,61,237,146,242,117,71,102,61,174,190,206,92,100,183,44,183,86,154,156,50,212,72,133,68,70,11,239,21,85,210,89,159,123,141,140,155,8,182,109,189,89,53,143,216,195,28,250,55,82,238,72,98,139,4,202,122,239,5,47,168,70,44,168,96,42,18,228,210,209,169,67,163,92,102,181,227,146,12,99,210,217,55,92,65,18,61,131,69,14,190,208,168,169,154,102,134,10,52,134,22,22,44,245,158,107,35,69,33,114,180,123,240,241,255,51,240,245,230,117,214,125,254,209,96,120,74,188,165,135,186,195,229,36,86,223,21,62,214,184,194,166,47,119,66,76,189,44,98,127,198,101,156,10,37,36,5,169,20,229,76,25,131,74,49,47,237,16,1,191,79,179,220,57,105,57,184,34,218,227,90,81,225,92,132,48,166,169,159,50,244,96,184,19,220,12,203,155,229,222,162,171,186,117,13,219,151,63,157,126,112,110,212,174,215,109,232,55,77,213,111,39,119,1,161,71,55,10,104,219,224,70,51,119,32,88,95,77,241,146,98,183,56,132,97,65,202,197,191,226,112,124,31,154,191,14,196,251,44,44,200,120,65,158,218,77,176,123,70,190,255,56,205,38,41,100,199,69,255,242,56,173,3,71,130,61,66,3,223,48,124,138,138,9,158,182,238,161,135,36,254,28,125,159,136,13,211,211,76,229,158,42,4,29,167,45,99,84,92,14,84,231,218,120,174,56,243,158,37,244,23,244,24,176,177,120,109,12,80,72,111,10,69,109,198,44,21,16,243,6,142,231,20,52,227,214,57,173,133,245,9,159,148,207,102,78,177,141,149,102,83,215,73,160,75,253,239,239,193,209,248,113,231,254,98,140,23,12,173,171,124,133,110,214,252,207,81,13,100,24,150,195,47,156,153,101,0,210,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "a5f68bdc204442c488309965e224d704",
							"BaseElements.ChangeDataLead.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordColumnValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordColumnValues", getColumnValue);
					}
					return _recordColumnValues;
				}
				set {
					_recordColumnValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: AddDataContactToOpportunityFlowElement

		/// <exclude/>
		public class AddDataContactToOpportunityFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataContactToOpportunityFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataContactToOpportunity";
				IsLogging = true;
				SchemaElementUId = new Guid("c7fbc613-e8cf-48ac-9537-9cb0818cc78f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Opportunity = () => (Guid)((process.AddDataOpportunity.RecordId));
				_recordDefValues_Contact = () => (Guid)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty)));
				_recordDefValues_IsMainContact = () => (bool)(true);
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Opportunity", () => _recordDefValues_Opportunity.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_IsMainContact", () => _recordDefValues_IsMainContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Opportunity;
			internal Func<Guid> _recordDefValues_Contact;
			internal Func<bool> _recordDefValues_IsMainContact;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,86,77,111,219,70,16,253,43,2,147,163,70,32,247,123,117,43,156,20,48,144,180,110,146,230,98,251,48,187,51,155,8,160,73,131,164,90,184,130,254,123,71,180,85,127,180,117,131,162,135,180,40,15,164,184,171,247,102,118,231,189,89,238,170,151,211,205,53,87,235,234,3,15,3,142,125,153,86,39,253,192,171,179,161,207,60,142,171,55,125,198,118,243,11,166,150,207,112,192,43,158,120,248,136,237,150,199,55,155,113,90,46,30,195,170,101,245,242,167,121,182,90,159,239,170,211,137,175,126,60,37,97,71,23,84,200,193,65,180,81,131,193,18,33,56,42,192,218,103,195,38,50,251,34,224,220,183,219,171,238,45,79,120,134,211,231,106,189,171,102,54,33,176,198,166,198,16,66,70,97,49,232,21,160,13,5,44,97,209,88,167,84,168,174,246,203,106,204,159,249,10,231,160,247,224,130,202,155,162,9,172,71,137,110,152,33,57,99,128,162,54,166,65,221,16,171,3,248,238,255,247,192,243,23,231,167,227,247,63,119,60,188,159,121,215,5,219,145,47,87,50,250,100,224,117,203,87,220,77,235,157,49,182,184,192,10,18,213,18,203,27,7,232,188,7,173,124,74,236,189,42,46,239,5,240,219,110,174,119,228,178,70,10,17,188,142,30,12,145,64,148,138,80,172,226,130,73,147,209,105,127,249,226,242,144,34,109,198,235,22,111,62,254,62,211,111,136,22,253,245,117,63,76,219,110,51,221,172,78,6,198,137,105,49,112,238,7,90,156,210,45,193,245,163,42,62,164,216,93,220,138,225,162,90,95,252,153,28,238,158,183,139,127,44,136,167,90,184,168,150,23,213,251,126,59,228,3,163,62,188,28,107,51,71,168,239,46,248,131,219,241,186,229,152,97,111,177,195,79,60,124,39,17,103,248,60,245,10,39,156,131,127,144,188,143,196,73,69,91,251,166,128,103,140,96,216,41,8,212,32,196,38,166,162,189,86,165,168,25,253,142,11,15,220,101,126,156,24,178,113,37,5,15,185,86,89,164,198,1,144,116,3,24,149,206,68,49,154,92,102,252,28,249,62,153,163,108,101,164,219,182,237,28,96,156,215,127,240,193,93,226,119,51,175,30,148,241,1,67,79,155,178,97,58,237,254,206,86,237,171,253,126,249,208,116,77,96,155,88,103,32,173,18,24,237,29,164,130,65,100,143,162,196,220,136,232,210,179,166,67,167,2,105,68,240,209,53,96,162,209,16,130,75,208,104,103,93,67,148,115,116,95,133,233,10,27,10,129,107,48,206,74,201,66,58,84,59,101,224,72,76,210,57,116,182,245,83,211,73,18,186,72,67,97,85,91,129,52,25,164,69,17,36,17,140,175,93,227,27,85,14,144,215,221,36,110,58,153,247,104,189,67,50,177,38,27,160,182,6,197,170,193,66,84,98,113,162,96,156,227,164,99,208,127,109,213,119,140,180,104,15,55,18,1,175,190,221,12,227,180,216,72,221,22,125,17,191,142,219,118,218,116,159,22,82,152,150,243,180,233,187,213,15,91,233,194,7,105,44,112,148,241,110,194,60,253,239,231,47,243,115,227,196,4,206,54,16,138,180,101,211,88,57,123,136,106,192,80,75,107,117,65,19,233,127,133,159,165,9,149,44,203,5,170,141,216,49,39,130,88,55,6,116,99,115,225,108,92,46,244,252,33,154,107,151,20,50,248,236,13,152,131,250,67,180,114,84,201,193,19,162,86,86,185,240,207,251,121,26,228,241,140,31,142,243,255,125,37,199,58,57,155,138,116,143,82,164,77,53,82,197,224,125,4,101,84,45,63,228,171,168,246,207,41,249,139,19,251,10,149,124,185,255,21,202,193,77,110,108,10,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "a5f68bdc204442c488309965e224d704",
							"BaseElements.AddDataContactToOpportunity.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordDefValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordDefValues", getColumnValue);
					}
					return _recordDefValues;
				}
				set {
					_recordDefValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: AddDataOpportunityFlowElement

		/// <exclude/>
		public class AddDataOpportunityFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataOpportunityFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataOpportunity";
				IsLogging = true;
				SchemaElementUId = new Guid("445f68e2-bd03-4746-a677-327bbe772f6c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Account = () => (Guid)((process.Account));
				_recordDefValues_Title = () => new LocalizableString((process.ClientName)  + "/" + ((process.ClientOpportunityCount)+1).ToString());
				_recordDefValues_Budget = () => (Decimal)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("Budget").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Decimal>("Budget") : 0m)));
				_recordDefValues_IsPrimary = () => (bool)((process.ClientOpportunityCount) == 0);
				_recordDefValues_Owner = () => (Guid)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("SalesOwner").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("SalesOwnerId") : Guid.Empty)));
				_recordDefValues_LeadType = () => (Guid)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("LeadType").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("LeadTypeId") : Guid.Empty)));
				_recordDefValues_DueDate = () => (DateTime)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("DecisionDate").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<DateTime>("DecisionDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))));
				_recordDefValues_ResponsibleDepartment = () => (Guid)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("OpportunityDepartment").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("OpportunityDepartmentId") : Guid.Empty)));
				_recordDefValues_Contact = () => (Guid)((process.Contact));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Account", () => _recordDefValues_Account.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Title", () => _recordDefValues_Title.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Budget", () => _recordDefValues_Budget.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_IsPrimary", () => _recordDefValues_IsPrimary.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Owner", () => _recordDefValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_LeadType", () => _recordDefValues_LeadType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DueDate", () => _recordDefValues_DueDate.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_ResponsibleDepartment", () => _recordDefValues_ResponsibleDepartment.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Account;
			internal Func<string> _recordDefValues_Title;
			internal Func<Decimal> _recordDefValues_Budget;
			internal Func<bool> _recordDefValues_IsPrimary;
			internal Func<Guid> _recordDefValues_Owner;
			internal Func<Guid> _recordDefValues_LeadType;
			internal Func<DateTime> _recordDefValues_DueDate;
			internal Func<Guid> _recordDefValues_ResponsibleDepartment;
			internal Func<Guid> _recordDefValues_Contact;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,153,91,111,91,71,14,128,255,138,112,218,135,22,53,189,115,225,220,12,244,97,55,233,2,1,122,9,154,108,95,226,60,112,134,156,84,128,44,25,210,113,23,89,195,255,125,57,178,211,196,233,86,45,82,4,77,170,213,195,145,117,206,225,112,134,228,55,36,199,215,211,167,243,203,75,153,206,166,167,178,221,210,110,211,231,211,7,155,173,156,62,222,110,154,236,118,167,95,111,26,173,150,255,161,186,146,199,180,165,11,153,101,251,3,173,174,100,247,245,114,55,159,44,238,139,77,39,211,167,63,237,159,78,103,207,174,167,71,179,92,252,235,17,235,232,84,197,9,101,132,230,67,0,204,45,64,118,214,128,23,177,25,209,35,178,83,225,182,89,93,93,172,191,145,153,30,211,252,227,116,118,61,237,71,211,1,176,150,32,190,119,232,28,28,32,137,133,106,40,128,107,193,26,189,111,3,165,233,230,100,218,181,31,229,130,246,74,95,11,147,96,236,53,39,104,198,181,33,156,129,216,91,160,226,124,99,46,5,91,31,194,119,239,191,22,124,246,201,179,71,187,239,254,189,150,237,147,253,184,103,157,86,59,121,126,170,119,223,186,241,179,113,206,174,61,58,146,22,34,100,31,10,96,11,85,215,26,43,20,201,152,75,231,72,88,111,158,127,242,124,104,228,229,238,114,69,47,127,248,165,226,191,183,182,185,90,207,183,175,93,222,51,253,155,47,94,159,223,122,240,124,58,59,255,53,31,222,125,223,206,248,190,23,223,118,224,249,116,114,62,61,217,92,109,219,24,209,143,31,175,12,186,215,96,238,62,240,63,46,175,62,183,99,236,197,190,161,53,189,144,237,183,170,113,47,190,127,244,144,102,218,43,127,170,243,126,53,112,117,37,152,100,59,36,33,53,154,68,7,153,45,65,177,165,118,159,188,235,221,237,165,191,151,46,91,89,55,185,63,49,23,56,53,75,21,44,139,1,12,70,227,3,141,3,227,196,136,198,134,227,120,187,184,189,230,215,147,121,21,107,122,103,125,181,90,237,21,236,246,235,31,193,123,55,241,187,39,15,223,112,214,27,35,108,120,217,151,194,143,214,239,98,170,155,233,230,230,228,77,82,48,86,79,6,51,232,106,72,99,85,153,161,24,25,10,181,110,123,202,197,115,59,72,74,42,38,68,223,6,41,22,1,57,48,80,232,12,53,10,115,181,134,35,251,15,132,148,234,106,64,9,30,130,55,234,244,24,12,80,139,9,106,38,76,38,176,115,21,7,41,139,197,23,139,243,233,111,231,147,126,127,246,78,154,140,171,22,99,97,72,142,24,176,168,58,74,106,163,88,209,214,84,24,45,165,161,233,11,251,249,233,211,205,147,121,187,92,191,248,236,243,195,132,142,224,88,108,250,162,173,150,50,64,125,107,150,15,246,183,191,187,188,220,108,231,171,245,114,126,249,224,150,231,95,170,248,235,211,29,26,249,208,117,191,39,171,96,226,240,49,149,72,224,179,103,138,212,53,182,219,33,186,127,247,196,62,116,186,67,77,13,185,84,224,193,52,146,238,117,57,91,253,89,76,115,26,251,213,97,62,156,7,61,230,108,138,64,236,70,19,169,139,77,7,208,125,174,132,220,187,20,83,109,138,127,38,221,95,173,228,66,195,254,236,186,11,114,206,99,47,142,65,117,229,58,246,242,218,64,10,11,99,168,190,5,115,115,31,82,70,180,190,51,129,184,177,182,108,117,109,46,235,206,165,233,32,153,104,147,117,125,136,124,181,158,247,56,13,27,157,93,231,236,106,183,156,192,179,166,15,116,38,67,54,141,160,246,98,125,203,140,125,72,253,86,186,253,94,136,23,171,113,97,13,224,211,127,46,183,187,121,177,84,191,13,194,183,178,187,90,205,202,235,66,29,179,146,54,47,55,235,211,127,92,241,11,57,154,252,28,90,203,38,26,134,200,138,49,166,228,65,107,25,117,80,179,154,90,123,12,133,226,81,16,92,130,13,209,186,65,112,213,156,85,141,135,18,145,161,199,106,52,12,75,242,233,112,37,235,137,52,195,59,7,202,65,4,77,60,17,74,174,85,135,106,169,145,51,181,154,63,149,224,119,200,154,139,47,191,92,152,195,124,253,90,54,252,89,244,175,143,144,110,206,49,212,158,193,116,5,7,45,90,200,41,21,112,99,207,74,137,122,49,233,56,16,242,6,123,65,4,215,171,86,3,133,43,140,238,14,108,119,85,11,132,18,52,174,14,34,20,51,134,224,73,139,136,160,193,169,68,16,80,199,10,189,165,40,165,139,143,5,143,43,9,134,102,58,165,18,181,41,206,94,99,203,69,173,164,165,64,235,204,205,169,177,10,153,247,145,4,159,208,74,118,139,205,48,202,177,100,194,63,218,169,218,88,53,64,131,194,223,197,169,171,130,150,128,204,90,26,103,227,25,163,86,196,236,63,10,140,131,235,154,174,74,209,42,126,116,170,174,120,32,223,12,68,205,10,88,123,115,76,230,48,198,213,112,203,218,159,250,84,179,90,162,141,202,173,16,68,241,134,153,180,221,245,238,216,48,142,69,31,35,68,167,235,193,160,197,69,142,181,131,86,10,177,105,96,68,207,225,125,96,252,173,8,47,6,156,255,135,248,247,65,44,134,171,84,45,226,176,120,189,136,136,242,219,29,144,195,68,161,55,201,57,127,20,16,247,68,88,179,98,84,155,130,136,77,183,164,236,21,40,150,110,197,70,12,142,211,65,136,91,238,129,163,182,95,218,203,150,177,11,4,229,112,160,210,123,148,140,38,134,208,143,11,98,108,158,98,215,166,190,20,214,92,92,169,107,171,20,16,76,138,46,33,155,152,66,123,31,16,63,148,182,220,233,31,139,121,121,33,171,229,250,104,96,102,103,165,72,71,141,162,136,128,198,58,168,46,71,232,100,41,171,147,152,16,143,162,176,214,157,167,183,90,16,58,202,56,59,142,13,138,233,2,5,173,165,98,25,179,233,7,97,182,161,155,110,138,5,137,113,156,165,104,101,158,77,210,194,26,155,118,128,209,107,162,62,178,211,37,66,67,17,71,131,97,134,73,141,104,183,142,41,142,206,163,89,238,181,22,255,94,78,151,110,11,107,94,254,180,71,250,88,72,254,163,105,57,176,118,134,177,34,216,48,98,131,37,104,67,164,23,210,70,211,244,152,138,246,73,31,5,201,106,134,42,186,24,232,156,180,190,96,70,168,209,49,164,156,162,205,62,116,169,135,255,11,20,145,76,168,26,183,62,24,205,235,172,69,100,237,156,161,215,144,138,214,231,221,23,249,64,78,153,106,12,94,235,140,160,125,4,106,209,139,206,104,190,244,6,36,213,214,74,38,155,66,252,109,196,30,108,214,51,181,163,57,143,61,230,46,244,249,205,127,1,0,73,221,101,183,32,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "a5f68bdc204442c488309965e224d704",
							"BaseElements.AddDataOpportunity.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordDefValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordDefValues", getColumnValue);
					}
					return _recordDefValues;
				}
				set {
					_recordDefValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataCountOpportunityByAccountFlowElement

		/// <exclude/>
		public class ReadDataCountOpportunityByAccountFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataCountOpportunityByAccountFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataCountOpportunityByAccount";
				IsLogging = true;
				SchemaElementUId = new Guid("b518c4a6-438a-4b3b-8989-1943e7c6d350");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,203,106,221,48,16,253,23,45,186,178,138,172,135,109,185,171,114,185,133,64,73,3,125,80,8,151,48,150,70,137,168,95,177,101,218,96,252,239,149,175,175,219,144,69,41,221,21,188,176,70,62,103,206,57,51,158,239,252,248,206,215,1,135,210,65,61,98,50,93,217,146,228,40,152,171,148,162,185,213,5,149,70,56,90,9,204,104,206,192,72,147,170,194,106,32,73,11,13,150,100,67,31,173,15,36,241,1,155,177,188,157,127,147,134,97,194,228,206,157,15,31,205,3,54,240,121,109,0,40,51,87,21,57,53,140,27,42,1,11,10,86,164,20,52,23,198,90,173,165,113,100,211,82,137,194,10,6,21,205,114,107,169,204,101,69,11,192,156,102,90,88,6,232,42,233,10,146,212,232,194,241,71,63,224,56,250,174,45,103,252,245,254,233,169,143,42,183,222,135,174,158,154,150,36,13,6,184,129,240,80,18,89,105,133,194,57,234,172,226,171,144,148,86,12,20,229,70,165,44,214,83,5,57,73,12,244,97,165,37,111,141,233,166,54,58,29,208,225,128,173,193,103,166,184,178,185,73,163,210,212,34,163,82,177,200,37,25,167,140,35,195,200,195,109,134,36,177,16,224,11,212,19,158,133,205,126,181,200,181,98,121,234,104,142,160,169,196,140,211,194,166,64,117,170,43,39,114,193,157,227,123,220,239,187,238,219,212,199,168,199,235,169,193,193,155,203,220,48,14,160,27,202,217,116,109,24,186,122,37,191,126,6,216,230,115,185,252,186,101,82,159,111,86,32,89,146,105,196,67,237,177,13,199,214,116,214,183,247,231,209,45,75,196,52,61,12,126,220,147,60,62,78,80,199,0,252,253,195,31,19,63,76,99,232,154,255,205,111,18,189,70,154,184,173,103,205,235,50,91,63,246,53,60,157,207,37,121,245,56,117,225,205,101,15,182,3,121,1,218,63,18,146,3,26,149,209,66,168,104,211,168,184,185,60,171,168,198,66,22,218,217,12,100,117,97,88,146,127,111,115,123,53,126,248,222,238,191,215,22,207,233,117,172,190,40,220,236,232,114,254,27,101,203,105,215,118,90,226,243,19,99,190,182,24,41,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 1;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _aggregationColumnName;
			public override string AggregationColumnName {
				get {
					return _aggregationColumnName ?? (_aggregationColumnName = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,1,0,242,67,189,42,2,0,0,0 })));
				}
				set {
					_aggregationColumnName = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataAccountFlowElement

		/// <exclude/>
		public class ReadDataAccountFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataAccountFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataAccount";
				IsLogging = true;
				SchemaElementUId = new Guid("a648f660-39aa-47fa-9c57-2fdc40b9d3fc");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,235,211,146,123,42,203,182,236,37,13,52,45,133,100,9,99,105,156,21,248,99,99,203,52,193,236,127,175,188,206,182,16,72,233,181,224,131,102,164,247,230,189,199,120,190,15,227,167,208,68,28,202,26,154,17,179,105,231,75,98,149,84,166,146,72,121,141,53,149,133,112,20,184,179,148,41,47,152,226,76,213,26,72,214,65,139,37,89,209,91,31,34,201,66,196,118,44,111,231,63,164,113,152,48,187,175,207,197,87,119,192,22,190,45,3,184,242,133,99,80,81,230,49,167,82,229,140,86,50,231,52,231,152,163,130,130,123,141,100,213,34,180,17,58,207,145,74,105,44,149,73,2,181,53,247,84,231,90,87,22,173,169,61,35,89,131,117,220,62,29,7,28,199,208,119,229,140,191,207,55,207,199,164,114,157,189,233,155,169,237,72,214,98,132,107,136,135,146,64,154,39,149,3,234,164,85,84,214,88,80,16,214,83,1,85,193,11,131,76,179,130,100,14,142,113,161,37,59,79,50,15,17,190,67,51,225,153,121,14,139,29,145,51,163,116,194,178,20,149,20,60,167,70,155,130,214,94,215,22,133,182,182,242,151,188,62,79,33,157,195,120,53,181,56,4,247,18,59,166,252,250,161,156,93,223,197,161,111,22,234,171,243,243,27,124,138,107,184,47,87,63,86,67,49,245,23,16,57,101,211,136,155,38,96,23,183,157,235,125,232,30,86,206,211,41,65,218,35,12,97,188,164,176,125,156,160,33,217,16,30,14,127,77,107,51,141,177,111,255,35,171,89,178,153,56,210,146,157,229,46,59,232,195,120,108,224,249,92,151,228,221,227,212,199,15,31,157,235,167,216,173,5,121,5,42,201,29,17,146,3,58,165,169,17,42,45,155,83,21,53,92,87,212,162,73,219,151,60,130,172,238,72,18,242,54,125,23,223,166,191,221,141,95,126,118,151,63,97,213,190,127,159,186,175,26,215,23,100,57,255,139,162,211,126,209,180,63,165,239,23,77,248,193,226,208,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,248,134,94,83,15,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataContactFlowElement

		/// <exclude/>
		public class ReadDataContactFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataContactFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataContact";
				IsLogging = true;
				SchemaElementUId = new Guid("e8f8e39f-e539-4087-a469-a23b941bc647");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,202,162,67,79,214,34,89,178,44,185,199,176,41,185,164,233,39,133,36,4,89,51,74,4,254,216,216,50,77,48,251,223,43,175,179,45,228,80,114,43,5,99,36,217,243,206,188,143,102,230,187,48,158,135,38,226,80,121,219,140,152,77,23,80,17,174,153,118,166,246,20,77,201,168,100,165,162,218,114,160,194,91,93,26,155,3,175,57,201,58,219,98,69,214,232,29,132,72,178,16,177,29,171,235,249,143,104,28,38,204,238,252,113,243,197,61,96,107,191,29,19,168,26,133,42,56,213,30,115,42,121,97,168,6,96,212,106,38,64,42,45,0,4,89,107,241,162,102,69,109,12,181,202,104,42,85,13,84,171,92,80,86,50,239,185,145,76,25,70,178,6,125,220,61,237,7,28,199,208,119,213,140,191,215,95,159,247,169,202,53,247,89,223,76,109,71,178,22,163,189,178,241,161,34,22,25,202,194,89,234,164,41,168,244,88,82,43,76,114,106,235,50,47,53,114,197,75,146,57,187,143,139,44,185,0,146,129,141,246,187,109,38,60,42,207,33,213,152,11,198,117,161,82,44,23,142,74,145,179,84,163,46,169,7,229,77,50,106,76,13,39,94,31,166,144,214,97,188,156,90,28,130,123,193,142,137,95,63,84,179,235,187,56,244,205,34,125,121,252,253,43,62,197,21,238,203,167,31,171,161,152,206,151,32,114,200,166,17,207,154,128,93,220,117,174,135,208,221,175,154,135,67,10,105,247,118,8,227,137,194,238,113,178,13,201,134,112,255,240,87,90,103,211,24,251,246,63,178,154,37,155,73,35,53,217,177,220,165,7,33,140,251,198,62,31,247,21,121,247,56,245,241,253,103,180,176,105,150,215,226,108,123,30,134,49,110,150,166,221,244,126,147,8,76,77,76,154,27,215,55,13,186,229,198,183,159,18,176,224,3,194,198,142,155,165,44,235,226,170,69,94,229,172,200,13,241,40,65,107,76,35,163,138,4,71,215,150,26,94,187,52,70,128,32,139,90,184,130,109,65,74,46,60,88,138,57,75,45,167,185,163,58,215,64,107,137,170,100,169,223,120,238,183,22,164,97,80,104,202,10,105,105,82,45,168,201,165,162,0,90,42,133,181,48,90,220,144,68,228,159,248,188,190,24,63,254,236,78,19,189,222,193,237,54,157,190,58,216,53,216,166,203,170,230,183,128,57,164,128,171,83,170,106,126,11,166,37,100,215,197,16,159,215,201,174,230,183,112,59,220,46,228,110,15,233,249,5,19,114,238,11,255,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: PresentationTaskCreationFlowElement

		/// <exclude/>
		public class PresentationTaskCreationFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public PresentationTaskCreationFlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "PresentationTaskCreation";
				IsLogging = true;
				SchemaElementUId = new Guid("45fbb709-be49-495a-ae70-fce392dc560c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Title = () => new LocalizableString("Conduct presentation");
				_recordDefValues_Opportunity = () => (Guid)((process.AddDataOpportunity.RecordId));
				_recordDefValues_Type = () => (Guid)(new Guid("fbe0acdc-cfc0-df11-b00f-001d60e938c6"));
				_recordDefValues_ActivityCategory = () => (Guid)(new Guid("42c74c49-58e6-df11-971b-001d60e938c6"));
				_recordDefValues_ShowInScheduler = () => (bool)(true);
				_recordDefValues_StartDate = () => (DateTime)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("MeetingDate").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<DateTime>("MeetingDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))));
				_recordDefValues_DueDate = () => (DateTime)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("MeetingDate").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<DateTime>("MeetingDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))).AddHours(1));
				_recordDefValues_Owner = () => (Guid)(((process.ReadOppoortunityData2.ResultEntity.IsColumnValueLoaded(process.ReadOppoortunityData2.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadOppoortunityData2.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_recordDefValues_Contact = () => (Guid)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty)));
				_recordDefValues_Lead = () => (Guid)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_recordDefValues_Account = () => (Guid)(((process.ReadDataLead.ResultEntity.IsColumnValueLoaded(process.ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? process.ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Title", () => _recordDefValues_Title.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Opportunity", () => _recordDefValues_Opportunity.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Type", () => _recordDefValues_Type.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_ActivityCategory", () => _recordDefValues_ActivityCategory.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_ShowInScheduler", () => _recordDefValues_ShowInScheduler.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_StartDate", () => _recordDefValues_StartDate.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DueDate", () => _recordDefValues_DueDate.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Owner", () => _recordDefValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Lead", () => _recordDefValues_Lead.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Account", () => _recordDefValues_Account.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Title;
			internal Func<Guid> _recordDefValues_Opportunity;
			internal Func<Guid> _recordDefValues_Type;
			internal Func<Guid> _recordDefValues_ActivityCategory;
			internal Func<bool> _recordDefValues_ShowInScheduler;
			internal Func<DateTime> _recordDefValues_StartDate;
			internal Func<DateTime> _recordDefValues_DueDate;
			internal Func<Guid> _recordDefValues_Owner;
			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_Lead;
			internal Func<Guid> _recordDefValues_Account;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,90,93,111,27,199,21,253,43,4,157,135,22,208,16,243,253,161,55,195,73,81,1,118,235,58,110,94,44,63,220,153,123,199,33,66,145,2,185,74,225,10,250,239,61,187,146,106,89,77,25,53,137,10,43,18,31,72,106,151,119,102,247,222,115,230,156,59,171,243,249,87,195,199,83,153,31,206,223,202,118,75,187,77,31,22,47,54,91,89,188,222,110,154,236,118,139,151,155,70,171,229,63,169,174,228,53,109,233,68,6,217,126,71,171,51,217,189,92,238,134,131,217,231,97,243,131,249,87,63,78,103,231,135,239,206,231,71,131,156,252,253,136,49,186,79,153,170,207,65,113,102,175,188,45,90,101,210,248,214,181,171,201,91,9,28,16,220,54,171,179,147,245,43,25,232,53,13,223,207,15,207,231,211,104,227,0,220,186,38,103,84,234,156,148,231,74,138,52,6,16,111,92,53,41,56,239,204,252,226,96,190,107,223,203,9,77,147,126,10,110,222,23,206,206,42,242,173,41,95,181,81,181,112,192,37,24,219,188,165,210,115,25,131,175,126,255,41,240,120,254,98,179,230,179,54,204,78,183,178,147,245,64,195,114,179,62,158,143,63,230,229,238,116,69,31,191,251,95,98,78,63,75,225,205,168,243,227,203,74,28,207,15,143,255,91,45,174,62,191,157,110,241,243,106,220,46,196,241,252,224,120,254,237,230,108,219,198,17,221,248,199,117,98,166,25,244,213,75,253,196,219,245,235,114,140,41,236,21,173,233,131,108,255,130,25,167,240,233,212,215,52,208,52,249,91,92,247,245,192,161,145,11,221,104,69,6,89,246,45,38,69,37,146,114,217,49,69,234,212,122,155,162,223,72,151,173,172,155,252,194,11,155,102,254,116,49,215,152,193,145,245,217,106,53,77,176,155,238,127,4,225,213,133,95,157,249,250,70,229,110,140,176,225,101,95,10,31,173,127,201,21,93,204,47,46,14,110,34,190,122,171,133,98,87,209,48,33,17,129,85,77,186,40,171,35,55,202,41,38,83,246,35,62,102,207,30,56,247,53,86,32,222,144,42,174,87,149,180,52,75,93,56,164,254,219,35,254,221,179,119,71,187,191,254,99,45,219,203,44,28,118,90,237,228,253,2,71,111,29,248,102,37,39,64,247,225,185,247,161,199,44,86,85,214,78,249,228,163,162,152,146,114,54,213,42,41,217,30,219,5,2,254,141,216,195,115,142,205,17,231,162,146,43,35,155,25,33,214,22,213,131,149,78,213,177,119,245,226,253,179,247,251,120,246,238,217,115,230,217,230,244,116,179,29,206,214,203,225,227,226,141,180,205,150,103,71,124,25,248,251,39,91,181,37,232,100,186,74,66,69,121,137,86,229,9,39,166,212,238,146,179,189,219,125,100,35,241,177,215,156,84,211,22,40,33,201,138,24,107,44,21,235,26,115,41,190,245,7,65,54,93,156,182,218,26,101,98,176,202,235,92,85,73,46,43,83,186,113,197,102,118,178,159,108,193,23,211,156,235,74,138,5,32,65,80,69,33,21,197,62,27,208,56,128,191,241,62,200,246,114,179,249,225,236,116,145,66,245,236,74,85,33,240,56,2,248,128,66,106,229,186,47,20,50,151,216,210,162,87,209,212,112,30,75,168,86,220,13,166,209,186,35,55,134,163,150,226,114,139,63,71,153,171,249,158,183,97,249,35,40,51,27,89,176,120,75,187,31,158,40,115,55,202,220,165,82,15,130,50,214,37,27,1,123,5,174,51,18,81,139,162,74,94,89,118,49,183,210,56,148,180,151,50,45,27,223,41,25,37,218,64,159,156,13,138,90,102,164,195,147,45,78,216,184,124,143,148,41,209,136,213,25,194,97,236,40,143,160,109,213,37,128,252,213,72,244,80,152,166,23,222,182,228,27,110,50,100,137,151,148,41,9,87,251,107,40,243,130,6,249,176,217,126,92,188,18,25,150,235,15,79,204,185,27,115,238,82,176,7,193,156,108,113,31,169,144,178,217,137,242,209,67,108,96,89,84,55,176,62,5,82,81,184,239,101,14,18,197,210,130,81,57,7,128,223,102,82,128,39,222,116,211,205,248,106,188,243,191,61,115,134,45,62,246,32,253,250,252,239,31,201,69,215,24,106,207,74,247,142,20,26,143,74,36,136,189,133,101,199,23,234,69,167,71,209,163,36,71,186,90,114,202,5,241,163,13,23,56,119,88,159,234,200,230,88,165,117,110,123,145,60,98,142,2,140,86,52,21,221,30,242,166,74,103,88,18,83,98,49,17,62,158,249,139,232,81,186,120,206,89,52,232,58,82,46,215,113,221,170,13,118,143,133,125,168,174,5,125,187,71,241,222,184,142,222,13,108,199,42,149,77,83,25,78,82,85,44,125,73,71,147,140,237,99,200,55,235,1,178,240,98,202,209,225,185,244,6,37,156,90,95,135,214,45,160,8,185,67,86,13,39,221,98,237,54,246,242,243,157,205,27,33,158,173,198,55,6,128,23,127,90,110,119,195,108,137,186,205,54,125,182,149,221,217,106,84,158,25,10,179,146,54,110,47,92,139,209,248,123,153,209,154,103,195,242,68,30,139,52,177,53,82,164,123,244,49,17,56,214,6,189,40,0,172,58,25,202,40,20,147,247,143,130,208,197,91,147,99,198,202,70,4,141,45,104,237,114,41,78,89,27,140,19,232,174,196,186,127,211,65,195,18,9,68,222,132,138,70,42,58,13,87,88,163,210,45,57,172,140,21,226,86,159,8,253,83,132,94,60,103,254,51,106,191,251,131,249,227,255,137,220,183,167,124,34,250,163,33,186,131,9,239,102,76,132,245,73,249,4,24,19,184,167,98,64,31,106,122,242,189,237,223,79,239,58,185,216,33,253,169,48,176,157,34,136,46,17,221,96,132,51,141,88,51,48,204,23,65,244,228,92,135,19,49,138,67,159,218,204,162,106,71,51,87,163,35,113,186,104,9,245,54,209,59,161,139,29,183,19,219,232,239,252,136,146,30,88,161,49,45,149,169,56,38,249,79,162,199,236,67,112,148,20,133,130,134,24,201,81,212,225,237,123,75,81,74,23,23,139,191,163,114,223,216,148,188,51,199,167,172,60,22,193,254,181,189,164,129,57,117,113,236,160,186,64,166,76,40,136,103,64,56,107,120,206,152,29,179,123,16,60,174,172,13,181,10,153,6,252,0,85,231,33,216,186,168,208,116,213,58,80,175,86,239,229,113,237,68,165,165,174,154,139,25,3,104,100,210,77,143,95,82,140,186,99,145,240,247,178,11,243,229,10,54,49,250,16,14,240,64,193,67,176,57,7,85,172,143,138,57,251,24,165,186,146,221,125,56,240,191,157,209,106,130,198,140,118,56,190,30,168,13,79,124,126,100,124,118,197,21,157,51,252,115,173,16,17,55,110,56,22,174,42,89,207,181,64,179,188,219,191,55,196,208,26,111,144,63,239,2,22,4,3,207,89,27,150,6,49,38,115,15,146,131,149,71,198,103,209,226,67,35,213,252,184,91,216,5,10,237,160,208,142,106,178,41,139,65,224,125,240,249,233,49,226,93,217,235,13,1,88,82,84,10,186,142,143,18,170,202,141,154,234,221,1,242,62,123,35,237,65,176,87,72,68,58,40,23,11,58,60,223,70,233,200,22,198,81,114,182,132,150,56,217,253,143,17,123,213,28,59,12,181,73,4,87,61,254,135,11,194,2,248,136,60,184,22,89,63,54,53,134,13,247,133,196,3,12,198,33,170,35,165,163,23,247,129,18,252,118,22,10,225,222,213,152,90,219,156,173,159,212,248,142,124,182,129,83,51,84,149,225,17,33,227,230,71,29,141,165,182,88,138,81,55,11,145,250,82,249,252,254,226,95,221,42,32,238,211,38,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "a5f68bdc204442c488309965e224d704",
							"BaseElements.PresentationTaskCreation.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordDefValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordDefValues", getColumnValue);
					}
					return _recordDefValues;
				}
				set {
					_recordDefValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadOppoortunityData2FlowElement

		/// <exclude/>
		public class ReadOppoortunityData2FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadOppoortunityData2FlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadOppoortunityData2";
				IsLogging = true;
				SchemaElementUId = new Guid("733fbec1-d5fb-4329-bfe6-b63ae3090e5b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,172,98,89,178,108,57,199,101,91,246,146,6,154,150,66,178,132,103,233,41,43,240,87,108,137,102,49,251,223,43,175,179,41,228,80,10,61,5,116,144,158,52,243,102,134,167,249,193,77,159,93,227,113,172,44,52,19,38,97,103,42,130,185,54,117,102,129,178,186,6,42,148,204,105,201,184,160,220,0,178,90,151,92,88,65,146,14,90,172,200,138,222,26,231,73,226,60,182,83,117,55,255,33,245,99,192,228,193,158,15,223,244,1,91,248,190,52,0,20,210,214,101,65,117,154,105,42,0,75,10,134,51,10,42,227,218,24,165,132,182,100,213,34,139,210,160,205,82,106,133,42,168,176,82,82,197,153,162,170,72,115,89,34,22,41,211,36,105,208,250,237,243,48,226,52,185,190,171,102,124,221,223,30,135,168,114,237,189,233,155,208,118,36,105,209,195,13,248,195,34,36,69,145,107,160,90,168,60,178,99,65,129,43,67,57,212,69,86,148,200,36,43,72,162,97,240,11,45,217,25,146,24,240,240,3,154,128,103,230,217,69,141,25,79,89,153,203,136,101,60,218,225,81,109,41,163,59,107,164,85,200,165,82,181,185,228,245,37,184,184,119,211,117,104,113,116,250,37,118,140,249,245,99,53,235,190,243,99,223,44,212,215,231,231,183,248,236,215,112,95,174,126,174,134,124,172,47,32,114,74,194,132,155,198,97,231,183,157,238,141,235,30,87,206,211,41,66,218,1,70,55,93,82,216,62,5,104,72,50,186,199,195,95,211,218,132,201,247,237,59,178,154,68,155,145,35,14,217,89,238,50,131,198,77,67,3,199,243,185,34,31,159,66,239,175,54,97,28,35,248,67,63,12,253,232,67,231,252,113,189,32,111,8,42,114,79,192,198,233,2,133,52,69,198,168,200,36,82,40,139,148,102,218,90,206,77,154,218,82,220,147,40,234,255,91,221,237,166,175,191,186,203,15,89,61,237,63,197,234,155,194,205,5,89,205,255,162,238,180,95,244,237,79,113,253,6,219,198,33,213,232,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("9d00770f-dda3-42a7-937d-59d67284f4c1");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,75,107,220,48,16,254,43,139,14,61,89,139,100,203,178,228,158,202,178,45,11,37,13,109,90,10,217,16,198,210,40,17,248,177,177,101,146,96,246,191,87,94,103,91,200,161,228,210,67,193,7,205,72,51,223,99,198,211,173,31,62,250,58,96,95,58,168,7,76,198,157,45,9,164,186,200,211,20,168,202,4,163,34,70,84,131,146,84,105,147,217,84,48,131,182,32,73,11,13,150,100,169,222,90,31,72,226,3,54,67,121,61,253,105,26,250,17,147,91,119,10,190,153,123,108,224,251,12,192,157,148,60,79,145,10,206,20,21,218,42,170,117,158,81,169,153,200,29,147,214,41,69,22,46,182,226,178,208,204,82,83,104,65,5,200,130,66,6,154,170,74,74,229,128,177,212,197,167,53,186,176,125,58,244,56,12,190,107,203,9,127,159,175,158,15,145,229,130,189,233,234,177,105,73,210,96,128,75,8,247,37,73,141,168,176,18,57,181,58,215,84,100,140,209,170,170,144,58,20,70,59,168,164,227,106,13,200,80,228,6,168,17,58,167,194,225,76,65,91,154,65,85,164,133,66,46,121,180,195,192,33,204,216,228,51,130,93,239,44,73,44,4,248,1,245,136,39,14,147,143,106,210,140,113,149,207,26,120,102,34,94,202,168,146,170,160,206,74,167,49,147,90,87,246,236,236,167,209,199,179,31,46,198,6,123,111,94,6,132,209,233,174,47,39,211,181,161,239,234,185,245,197,233,249,21,62,133,101,12,47,87,63,23,233,33,230,231,34,114,76,198,1,55,181,199,54,108,91,211,89,223,222,45,61,143,199,88,210,28,160,247,195,217,175,237,195,8,53,73,122,127,119,255,87,95,55,227,16,186,230,63,146,154,68,153,177,71,92,199,19,221,121,91,173,31,14,53,60,159,226,146,188,123,24,187,240,126,158,225,106,8,112,135,229,106,191,95,114,31,30,193,135,216,105,53,64,141,231,228,250,43,154,174,183,171,157,93,98,242,10,160,36,123,2,89,86,8,39,36,205,101,52,65,20,76,82,157,3,82,206,133,48,42,238,155,19,106,109,43,141,149,50,130,130,200,120,220,115,224,84,35,10,154,43,230,164,115,200,149,150,123,18,149,253,123,190,215,187,225,203,99,123,254,97,23,227,110,214,49,251,42,177,173,177,137,14,151,211,91,4,30,99,193,229,25,170,156,222,34,247,120,51,11,190,57,198,239,23,104,109,241,196,168,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 1;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _aggregationColumnName;
			public override string AggregationColumnName {
				get {
					return _aggregationColumnName ?? (_aggregationColumnName = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,1,0,242,67,189,42,2,0,0,0 })));
				}
				set {
					_aggregationColumnName = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,177,50,180,50,212,241,76,177,50,176,50,0,0,230,77,107,227,15,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("1f66152e-4108-49d8-9953-69045f06df88")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("1f66152e-4108-49d8-9953-69045f06df88"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: AddDataUserTask1FlowElement

		/// <exclude/>
		public class AddDataUserTask1FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask1FlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("8cefef55-2cb9-4d67-93b5-1c6727144b04");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Opportunity = () => (Guid)((process.AddDataOpportunity.RecordId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Product", () => _recordDefValues_Product.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Opportunity", () => _recordDefValues_Opportunity.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Product;
			internal Func<Guid> _recordDefValues_Opportunity;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,43,139,14,61,89,139,101,75,178,228,158,202,178,45,11,37,13,109,90,10,217,16,198,210,40,17,248,99,99,203,36,193,236,127,175,188,206,182,144,67,201,165,135,130,15,154,145,231,189,121,111,70,211,173,31,62,250,58,96,95,58,168,7,76,198,157,45,9,10,231,164,202,37,213,5,230,148,179,52,163,26,10,75,193,113,33,152,200,140,192,130,36,45,52,88,146,165,122,107,125,32,137,15,216,12,229,245,244,7,52,244,35,38,183,238,20,124,51,247,216,192,247,153,128,57,41,35,14,206,216,138,114,109,21,213,90,228,84,234,148,11,151,74,235,148,34,75,47,66,229,105,94,160,162,153,208,150,114,99,20,173,138,74,82,22,99,100,21,51,92,75,146,212,232,194,246,233,208,227,48,248,174,45,39,252,125,190,122,62,196,46,23,238,77,87,143,77,75,146,6,3,92,66,184,47,73,102,120,133,21,23,212,106,161,41,207,211,148,86,85,133,212,33,55,218,65,37,29,83,107,192,20,185,48,64,35,151,160,220,97,65,33,143,205,228,80,21,89,161,144,73,22,237,48,112,8,51,55,249,140,96,215,59,75,18,11,1,126,64,61,226,169,135,201,71,53,89,158,50,37,100,4,96,185,137,124,89,74,149,84,5,117,86,58,141,185,212,186,178,103,103,63,141,62,158,253,112,49,54,216,123,243,50,32,140,78,119,125,57,153,174,13,125,87,207,208,23,167,223,175,240,41,44,99,120,185,250,185,72,15,49,63,23,145,99,50,14,184,169,61,182,97,219,154,206,250,246,110,193,60,30,99,73,115,128,222,15,103,191,182,15,35,212,36,233,253,221,253,95,125,221,140,67,232,154,255,72,106,18,101,70,140,184,142,167,118,231,109,181,126,56,212,240,124,138,75,242,238,97,236,194,251,121,134,171,33,192,29,150,171,253,126,201,125,120,4,31,34,210,106,128,26,207,201,245,87,52,93,111,87,59,187,196,228,21,65,73,246,4,242,188,224,142,75,42,100,52,129,23,105,124,88,2,144,50,198,185,81,113,223,28,87,107,91,105,172,148,225,20,120,206,40,7,96,84,35,114,42,84,234,164,115,200,148,150,123,18,149,253,251,126,175,119,195,151,199,246,252,96,23,227,110,214,49,251,42,177,173,177,137,14,151,211,91,4,30,99,193,229,153,170,156,222,34,247,120,51,11,190,57,198,239,23,225,253,223,116,168,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private Guid _filterEntitySchemaId = new Guid("1f66152e-4108-49d8-9953-69045f06df88");
			public override Guid FilterEntitySchemaId {
				get {
					return _filterEntitySchemaId;
				}
				set {
					_filterEntitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,84,193,110,219,48,12,253,149,66,237,49,12,100,73,150,172,92,183,29,2,180,93,177,118,189,36,57,80,18,181,6,112,236,192,118,86,116,65,254,125,138,147,172,105,177,117,88,81,116,62,216,144,196,71,62,63,242,105,205,206,186,135,37,177,17,187,161,166,193,182,142,221,240,67,221,208,240,170,169,61,181,237,240,188,246,88,206,127,160,43,233,10,27,92,80,71,205,45,150,43,106,207,231,109,55,56,121,10,99,3,118,246,189,63,101,163,201,154,141,59,90,124,29,135,148,93,69,149,147,10,5,160,11,6,84,20,25,20,58,16,20,89,84,194,21,30,101,16,9,236,235,114,181,168,46,168,195,43,236,238,216,104,205,250,108,41,129,204,162,43,164,242,192,131,214,160,132,17,128,156,11,176,34,26,34,107,131,247,138,109,6,172,245,119,180,192,190,232,35,24,115,157,27,210,14,164,18,1,84,198,21,20,232,18,25,116,210,80,20,182,208,124,11,222,199,63,2,141,180,60,74,111,129,83,180,137,118,226,142,156,36,112,71,54,88,18,58,242,108,136,196,73,229,30,193,43,155,167,32,74,65,210,6,144,232,140,48,5,101,58,51,219,236,97,222,46,75,124,184,125,94,36,73,29,86,190,27,38,206,41,106,249,68,229,227,184,245,116,215,172,41,27,77,255,212,174,253,247,186,87,225,105,195,158,247,106,202,6,83,118,93,175,26,191,205,168,183,139,131,118,125,5,190,127,224,55,175,195,179,203,209,195,46,176,194,111,212,92,166,138,61,188,63,250,136,29,246,197,111,18,239,127,78,252,133,34,53,84,121,122,37,177,190,242,35,153,195,88,245,59,111,214,217,61,211,182,23,114,59,240,123,5,170,85,89,110,21,56,106,250,17,149,58,204,227,156,194,184,122,205,175,109,216,102,51,56,118,87,180,82,59,133,28,50,21,11,80,193,56,64,107,8,164,228,58,11,130,59,195,253,139,238,66,155,163,34,85,128,41,108,6,74,90,5,142,156,7,171,48,23,65,248,66,6,247,246,238,154,156,78,198,237,231,251,138,154,157,10,163,136,101,75,179,97,218,125,182,241,169,164,5,85,221,104,173,84,30,117,65,2,92,224,18,148,81,26,80,27,3,82,24,231,200,24,17,181,223,36,192,175,209,31,173,131,246,18,67,97,33,181,60,93,61,33,36,136,16,22,98,46,40,38,138,65,73,183,153,157,206,94,178,232,228,244,146,238,79,234,229,178,110,186,85,53,239,30,134,219,117,67,190,110,194,201,56,236,192,255,201,185,242,253,156,235,132,205,185,201,34,24,194,100,26,210,2,138,144,33,216,204,186,40,141,20,49,138,151,156,139,164,116,186,198,13,120,46,60,40,164,52,36,65,102,105,88,133,244,33,88,171,124,252,139,115,247,182,122,127,195,205,54,63,1,86,222,91,182,44,7,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "a5f68bdc204442c488309965e224d704",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordDefValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordDefValues", getColumnValue);
					}
					return _recordDefValues;
				}
				set {
					_recordDefValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask2FlowElement

		/// <exclude/>
		public class ReadDataUserTask2FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask2FlowElement(UserConnection userConnection, OpportunityManagement process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("88a9e87a-9c7c-4738-80e4-4333e355e6d1");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,219,146,44,201,61,46,91,8,148,52,208,15,10,97,9,35,105,148,152,250,43,182,76,27,140,255,123,181,246,58,13,57,148,210,91,65,7,141,164,247,230,205,155,209,124,87,141,239,171,58,224,80,122,168,71,76,166,43,87,18,7,90,235,2,29,53,153,204,41,183,80,80,37,192,82,180,142,155,34,119,232,50,70,146,22,26,44,201,134,62,186,42,144,164,10,216,140,229,237,252,155,52,12,19,38,119,126,13,62,217,7,108,224,203,57,1,32,47,188,81,146,218,52,183,148,3,42,10,142,101,20,116,206,172,115,90,115,235,201,166,69,184,130,9,46,83,42,209,196,167,185,241,20,148,20,20,60,58,157,162,50,210,228,36,169,209,135,227,207,126,192,113,172,186,182,156,241,121,255,249,169,143,42,183,220,135,174,158,154,150,36,13,6,184,129,240,80,146,130,67,42,140,7,202,68,234,40,119,145,221,120,167,168,55,66,106,144,220,51,141,36,177,208,135,51,45,57,116,109,0,27,43,29,208,227,128,173,197,23,69,101,133,65,86,136,140,42,143,209,181,76,104,170,156,75,163,220,148,57,94,40,230,92,116,205,65,128,175,80,79,184,10,155,171,8,52,185,22,169,204,124,44,17,52,229,88,228,17,152,1,213,153,54,158,73,150,123,159,239,118,127,232,186,239,83,31,173,30,175,167,6,135,202,94,250,134,177,1,221,80,206,54,42,28,186,250,76,126,253,2,176,245,231,114,249,109,243,164,94,111,206,64,178,36,211,136,135,186,194,54,28,91,219,185,170,189,95,91,183,44,17,211,244,48,84,227,238,228,241,113,130,58,26,80,221,63,252,209,241,195,52,134,174,249,223,234,77,98,173,145,38,78,235,170,249,60,204,174,26,251,26,158,214,184,36,111,30,167,46,188,187,204,193,22,144,87,160,253,145,41,4,227,34,23,148,41,174,40,231,121,74,149,102,41,69,105,172,213,10,50,41,138,11,195,146,252,123,154,219,171,241,227,143,118,255,94,155,61,167,183,241,244,213,193,205,142,46,231,191,81,182,156,118,109,167,37,174,95,30,241,119,1,41,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 1;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _aggregationColumnName;
			public override string AggregationColumnName {
				get {
					return _aggregationColumnName ?? (_aggregationColumnName = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })));
				}
				set {
					_aggregationColumnName = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,201,44,201,73,181,50,180,50,212,241,76,177,50,176,50,0,0,169,240,29,88,16,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		public OpportunityManagement(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityManagement";
			SchemaUId = new Guid("a5f68bdc-2044-42c4-8830-9965e224d704");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a5f68bdc-2044-42c4-8830-9965e224d704");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: OpportunityManagement, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: OpportunityManagement, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid CurrentOpportunity {
			get;
			set;
		}

		public virtual Guid Presentation {
			get;
			set;
		}

		public virtual Guid MainContact {
			get;
			set;
		}

		public virtual Guid Account {
			get;
			set;
		}

		public virtual bool IsStageChangedByUser {
			get;
			set;
		}

		public virtual int ClientOpportunityCount {
			get;
			set;
		}

		public virtual string OpportunityTitle {
			get;
			set;
		}

		public virtual Guid Contact {
			get;
			set;
		}

		public virtual string ClientName {
			get;
			set;
		}

		private ProcessOpportunityMangementProcess _opportunityMangementProcess;
		public ProcessOpportunityMangementProcess OpportunityMangementProcess {
			get {
				return _opportunityMangementProcess ?? ((_opportunityMangementProcess) = new ProcessOpportunityMangementProcess(UserConnection, this));
			}
		}

		private ReadOppDataFlowElement _readOppData;
		public ReadOppDataFlowElement ReadOppData {
			get {
				return _readOppData ?? (_readOppData = new ReadOppDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _opportunityStage;
		public ProcessExclusiveGateway OpportunityStage {
			get {
				return _opportunityStage ?? (_opportunityStage = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "OpportunityStage",
					SchemaElementUId = new Guid("fd6a7aba-01a4-4537-95f0-71af43bde436"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.OpportunityStage.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProspectingFlowElement _prospecting;
		public ProspectingFlowElement Prospecting {
			get {
				return _prospecting ?? ((_prospecting) = new ProspectingFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _terminate3;
		public ProcessTerminateEvent Terminate3 {
			get {
				return _terminate3 ?? (_terminate3 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate3",
					SchemaElementUId = new Guid("a754a29c-40c0-420e-941d-f2b4a941c8ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private NeedsAnalysisFlowElement _needsAnalysis;
		public NeedsAnalysisFlowElement NeedsAnalysis {
			get {
				return _needsAnalysis ?? ((_needsAnalysis) = new NeedsAnalysisFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OppManagementValuePpropositionFlowElement _oppManagementValuePproposition;
		public OppManagementValuePpropositionFlowElement OppManagementValuePproposition {
			get {
				return _oppManagementValuePproposition ?? ((_oppManagementValuePproposition) = new OppManagementValuePpropositionFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private IdDecisionMakersFlowElement _idDecisionMakers;
		public IdDecisionMakersFlowElement IdDecisionMakers {
			get {
				return _idDecisionMakers ?? ((_idDecisionMakers) = new IdDecisionMakersFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OppManagementPerceptionAnalysisFlowElement _oppManagementPerceptionAnalysis;
		public OppManagementPerceptionAnalysisFlowElement OppManagementPerceptionAnalysis {
			get {
				return _oppManagementPerceptionAnalysis ?? ((_oppManagementPerceptionAnalysis) = new OppManagementPerceptionAnalysisFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OppManagementProposalFlowElement _oppManagementProposal;
		public OppManagementProposalFlowElement OppManagementProposal {
			get {
				return _oppManagementProposal ?? ((_oppManagementProposal) = new OppManagementProposalFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OppManagementNegotiationsFlowElement _oppManagementNegotiations;
		public OppManagementNegotiationsFlowElement OppManagementNegotiations {
			get {
				return _oppManagementNegotiations ?? ((_oppManagementNegotiations) = new OppManagementNegotiationsFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OppManagementContractationFlowElement _oppManagementContractation;
		public OppManagementContractationFlowElement OppManagementContractation {
			get {
				return _oppManagementContractation ?? ((_oppManagementContractation) = new OppManagementContractationFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OppManagementEndStageFlowElement _oppManagementEndStage;
		public OppManagementEndStageFlowElement OppManagementEndStage {
			get {
				return _oppManagementEndStage ?? ((_oppManagementEndStage) = new OppManagementEndStageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2;
		public ProcessExclusiveGateway ExclusiveGateway2 {
			get {
				return _exclusiveGateway2 ?? (_exclusiveGateway2 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2",
					SchemaElementUId = new Guid("4ba680da-7591-4eb5-8ede-25d1558e9149"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private FindPresentationFlowElement _findPresentation;
		public FindPresentationFlowElement FindPresentation {
			get {
				return _findPresentation ?? (_findPresentation = new FindPresentationFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _savePresentationParameter2;
		public ProcessScriptTask SavePresentationParameter2 {
			get {
				return _savePresentationParameter2 ?? (_savePresentationParameter2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "SavePresentationParameter2",
					SchemaElementUId = new Guid("d8643dcc-9a0d-40a5-abbb-c08fc8ced26b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = SavePresentationParameter2Execute,
				});
			}
		}

		private LinkOppToProcessFlowElement _linkOppToProcess;
		public LinkOppToProcessFlowElement LinkOppToProcess {
			get {
				return _linkOppToProcess ?? (_linkOppToProcess = new LinkOppToProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadOppMainContactFlowElement _readOppMainContact;
		public ReadOppMainContactFlowElement ReadOppMainContact {
			get {
				return _readOppMainContact ?? (_readOppMainContact = new ReadOppMainContactFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _saveMainContactParameter;
		public ProcessScriptTask SaveMainContactParameter {
			get {
				return _saveMainContactParameter ?? (_saveMainContactParameter = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "SaveMainContactParameter",
					SchemaElementUId = new Guid("90ba94c4-778e-4da8-b1fa-20caa11d06b9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = SaveMainContactParameterExecute,
				});
			}
		}

		private ProcessStartSignalEvent _startSignalLeadStageChange;
		public ProcessStartSignalEvent StartSignalLeadStageChange {
			get {
				return _startSignalLeadStageChange ?? (_startSignalLeadStageChange = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignalLeadStageChange",
					SerializeToDB = false,
					IsLogging = false,
					SchemaElementUId = new Guid("a3374f46-5620-4706-95ae-1144c8bbbf48"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway3;
		public ProcessExclusiveGateway ExclusiveGateway3 {
			get {
				return _exclusiveGateway3 ?? (_exclusiveGateway3 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway3",
					SchemaElementUId = new Guid("ef1d55e6-1755-412a-9d7c-f01d78a5edf9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway3.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessFlowElement _startOppBusinessProcess;
		public ProcessFlowElement StartOppBusinessProcess {
			get {
				return _startOppBusinessProcess ?? (_startOppBusinessProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartOppBusinessProcess",
					SchemaElementUId = new Guid("cc1b7702-073c-45cc-926b-05e107a8fd30"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private OpenEditPageUserTask1FlowElement _openEditPageUserTask1;
		public OpenEditPageUserTask1FlowElement OpenEditPageUserTask1 {
			get {
				return _openEditPageUserTask1 ?? (_openEditPageUserTask1 = new OpenEditPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway4;
		public ProcessExclusiveGateway ExclusiveGateway4 {
			get {
				return _exclusiveGateway4 ?? (_exclusiveGateway4 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway4",
					SchemaElementUId = new Guid("69c50fcc-abf2-43ac-a9d1-e9e6ed6a5397"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway4.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminate4;
		public ProcessTerminateEvent Terminate4 {
			get {
				return _terminate4 ?? (_terminate4 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate4",
					SchemaElementUId = new Guid("129d65ec-f59b-44af-b1d6-cda0a6b4ff21"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _formulaTask1;
		public ProcessScriptTask FormulaTask1 {
			get {
				return _formulaTask1 ?? (_formulaTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask1",
					SchemaElementUId = new Guid("ad47ec52-76d5-44c0-b66d-9440119348ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask2;
		public ProcessScriptTask FormulaTask2 {
			get {
				return _formulaTask2 ?? (_formulaTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask2",
					SchemaElementUId = new Guid("54731090-57ce-4f13-a4f0-8398e8e5479f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask2Execute,
				});
			}
		}

		private ProcessScriptTask _storeIsStageChangedByUser;
		public ProcessScriptTask StoreIsStageChangedByUser {
			get {
				return _storeIsStageChangedByUser ?? (_storeIsStageChangedByUser = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "StoreIsStageChangedByUser",
					SchemaElementUId = new Guid("437d217c-6201-420a-a4e5-134fac88d589"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = StoreIsStageChangedByUserExecute,
				});
			}
		}

		private ProcessScriptTask _resetIsStageChangedByUser;
		public ProcessScriptTask ResetIsStageChangedByUser {
			get {
				return _resetIsStageChangedByUser ?? (_resetIsStageChangedByUser = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "ResetIsStageChangedByUser",
					SchemaElementUId = new Guid("c07da6a9-f9fc-4d1b-a11d-633a4992ae39"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ResetIsStageChangedByUserExecute,
				});
			}
		}

		private ReadDataLeadFlowElement _readDataLead;
		public ReadDataLeadFlowElement ReadDataLead {
			get {
				return _readDataLead ?? (_readDataLead = new ReadDataLeadFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataLeadFlowElement _changeDataLead;
		public ChangeDataLeadFlowElement ChangeDataLead {
			get {
				return _changeDataLead ?? (_changeDataLead = new ChangeDataLeadFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewaySetDateTimePresentation;
		public ProcessExclusiveGateway ExclusiveGatewaySetDateTimePresentation {
			get {
				return _exclusiveGatewaySetDateTimePresentation ?? (_exclusiveGatewaySetDateTimePresentation = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewaySetDateTimePresentation",
					SchemaElementUId = new Guid("f7a393e4-d550-4f6e-aba4-c4a007307258"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewaySetDateTimePresentation.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminate2;
		public ProcessTerminateEvent Terminate2 {
			get {
				return _terminate2 ?? (_terminate2 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate2",
					SchemaElementUId = new Guid("375b9e3c-98fc-4100-83c4-c571cfe22b08"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private AddDataContactToOpportunityFlowElement _addDataContactToOpportunity;
		public AddDataContactToOpportunityFlowElement AddDataContactToOpportunity {
			get {
				return _addDataContactToOpportunity ?? (_addDataContactToOpportunity = new AddDataContactToOpportunityFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayLeadQualifiedAsContact;
		public ProcessExclusiveGateway ExclusiveGatewayLeadQualifiedAsContact {
			get {
				return _exclusiveGatewayLeadQualifiedAsContact ?? (_exclusiveGatewayLeadQualifiedAsContact = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayLeadQualifiedAsContact",
					SchemaElementUId = new Guid("c017a416-4566-4caf-89f0-cd11dc760d58"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayLeadQualifiedAsContact.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private AddDataOpportunityFlowElement _addDataOpportunity;
		public AddDataOpportunityFlowElement AddDataOpportunity {
			get {
				return _addDataOpportunity ?? (_addDataOpportunity = new AddDataOpportunityFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataCountOpportunityByAccountFlowElement _readDataCountOpportunityByAccount;
		public ReadDataCountOpportunityByAccountFlowElement ReadDataCountOpportunityByAccount {
			get {
				return _readDataCountOpportunityByAccount ?? (_readDataCountOpportunityByAccount = new ReadDataCountOpportunityByAccountFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataAccountFlowElement _readDataAccount;
		public ReadDataAccountFlowElement ReadDataAccount {
			get {
				return _readDataAccount ?? (_readDataAccount = new ReadDataAccountFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTaskAccountByLead;
		public ProcessScriptTask FormulaTaskAccountByLead {
			get {
				return _formulaTaskAccountByLead ?? (_formulaTaskAccountByLead = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTaskAccountByLead",
					SchemaElementUId = new Guid("ab3f8e00-ffa9-4079-8f2d-c9aa8b4b4826"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTaskAccountByLeadExecute,
				});
			}
		}

		private ReadDataContactFlowElement _readDataContact;
		public ReadDataContactFlowElement ReadDataContact {
			get {
				return _readDataContact ?? (_readDataContact = new ReadDataContactFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayQualifiedByAccount;
		public ProcessExclusiveGateway ExclusiveGatewayQualifiedByAccount {
			get {
				return _exclusiveGatewayQualifiedByAccount ?? (_exclusiveGatewayQualifiedByAccount = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayQualifiedByAccount",
					SchemaElementUId = new Guid("ba7fb0fc-f887-4dd2-9494-28335297b5e4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayQualifiedByAccount.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _saveCurrOppParameter;
		public ProcessScriptTask SaveCurrOppParameter {
			get {
				return _saveCurrOppParameter ?? (_saveCurrOppParameter = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "SaveCurrOppParameter",
					SchemaElementUId = new Guid("0b3df41d-a31f-4753-9ad5-bb8d4c5137fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = SaveCurrOppParameterExecute,
				});
			}
		}

		private PresentationTaskCreationFlowElement _presentationTaskCreation;
		public PresentationTaskCreationFlowElement PresentationTaskCreation {
			get {
				return _presentationTaskCreation ?? (_presentationTaskCreation = new PresentationTaskCreationFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _savePresentationParameter;
		public ProcessScriptTask SavePresentationParameter {
			get {
				return _savePresentationParameter ?? (_savePresentationParameter = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "SavePresentationParameter",
					SchemaElementUId = new Guid("a914a2b0-15d2-4c81-938d-6f3bcc01c912"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = SavePresentationParameterExecute,
				});
			}
		}

		private ReadOppoortunityData2FlowElement _readOppoortunityData2;
		public ReadOppoortunityData2FlowElement ReadOppoortunityData2 {
			get {
				return _readOppoortunityData2 ?? (_readOppoortunityData2 = new ReadOppoortunityData2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddDataUserTask1FlowElement _addDataUserTask1;
		public AddDataUserTask1FlowElement AddDataUserTask1 {
			get {
				return _addDataUserTask1 ?? (_addDataUserTask1 = new AddDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("da838103-79ee-48ff-b9fb-43f5d9fb0543"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ReadDataUserTask2FlowElement _readDataUserTask2;
		public ReadDataUserTask2FlowElement ReadDataUserTask2 {
			get {
				return _readDataUserTask2 ?? (_readDataUserTask2 = new ReadDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTask3;
		public ProcessScriptTask FormulaTask3 {
			get {
				return _formulaTask3 ?? (_formulaTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask3",
					SchemaElementUId = new Guid("083b1a16-96f4-434c-bd21-1e475d6a546b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask3Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask4;
		public ProcessScriptTask FormulaTask4 {
			get {
				return _formulaTask4 ?? (_formulaTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask4",
					SchemaElementUId = new Guid("b120e00e-d3f2-4b09-8118-ef17c00af6bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask4Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask5;
		public ProcessScriptTask FormulaTask5 {
			get {
				return _formulaTask5 ?? (_formulaTask5 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask5",
					SchemaElementUId = new Guid("cecd8639-1f00-4d59-b112-9fbe4de5517a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask5Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask6;
		public ProcessScriptTask FormulaTask6 {
			get {
				return _formulaTask6 ?? (_formulaTask6 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask6",
					SchemaElementUId = new Guid("d527d260-953d-4177-b84b-fd337a8b9408"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask6Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask7;
		public ProcessScriptTask FormulaTask7 {
			get {
				return _formulaTask7 ?? (_formulaTask7 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask7",
					SchemaElementUId = new Guid("e71860b5-b65b-493b-8d7c-c65ed80dc169"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask7Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask8;
		public ProcessScriptTask FormulaTask8 {
			get {
				return _formulaTask8 ?? (_formulaTask8 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask8",
					SchemaElementUId = new Guid("7727ad4d-089b-417c-acfd-d66ee83afc06"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask8Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask9;
		public ProcessScriptTask FormulaTask9 {
			get {
				return _formulaTask9 ?? (_formulaTask9 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask9",
					SchemaElementUId = new Guid("f284494f-5edb-489b-92c3-ddb20eaa0ab0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask9Execute,
				});
			}
		}

		private ProcessConditionalFlow _prospectingStage;
		public ProcessConditionalFlow ProspectingStage {
			get {
				return _prospectingStage ?? (_prospectingStage = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ProspectingStage",
					SchemaElementUId = new Guid("6da9cfcb-81e5-48a4-a1c1-42a6279225e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _needAnalysisStage;
		public ProcessConditionalFlow NeedAnalysisStage {
			get {
				return _needAnalysisStage ?? (_needAnalysisStage = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "NeedAnalysisStage",
					SchemaElementUId = new Guid("9301d50a-6c5b-4489-badd-4a28230234ae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _valueProposition;
		public ProcessConditionalFlow ValueProposition {
			get {
				return _valueProposition ?? (_valueProposition = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ValueProposition",
					SchemaElementUId = new Guid("bb42fb47-5fbd-4f77-af1e-ce351db4f8f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _decisionMakers;
		public ProcessConditionalFlow DecisionMakers {
			get {
				return _decisionMakers ?? (_decisionMakers = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "DecisionMakers",
					SchemaElementUId = new Guid("f094c232-c29e-46d1-86fc-2e61dcac8e07"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _perceptionAnalysisStage;
		public ProcessConditionalFlow PerceptionAnalysisStage {
			get {
				return _perceptionAnalysisStage ?? (_perceptionAnalysisStage = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "PerceptionAnalysisStage",
					SchemaElementUId = new Guid("90dc5cd4-a514-48c4-9705-1babb54dc9a9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _negotiationsStage;
		public ProcessConditionalFlow NegotiationsStage {
			get {
				return _negotiationsStage ?? (_negotiationsStage = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "NegotiationsStage",
					SchemaElementUId = new Guid("3b93fd4b-c4ce-43ef-81de-d70f18e28cd9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _contractationStage;
		public ProcessConditionalFlow ContractationStage {
			get {
				return _contractationStage ?? (_contractationStage = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ContractationStage",
					SchemaElementUId = new Guid("97b5d2a4-5ab3-4fb5-9544-7ee6933c7e5a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _proposalStage;
		public ProcessConditionalFlow ProposalStage {
			get {
				return _proposalStage ?? (_proposalStage = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ProposalStage",
					SchemaElementUId = new Guid("94b519f4-4f88-4966-9c23-8a451496a11b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("b131dc29-103b-498c-8cad-b0267ae02df9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow2;
		public ProcessConditionalFlow ConditionalFlow2 {
			get {
				return _conditionalFlow2 ?? (_conditionalFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow2",
					SchemaElementUId = new Guid("656a4a04-8b53-40cb-9fe2-d14c1a49db28"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow8;
		public ProcessConditionalFlow ConditionalFlow8 {
			get {
				return _conditionalFlow8 ?? (_conditionalFlow8 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow8",
					SchemaElementUId = new Guid("12da4680-7947-44ac-bce4-174e2ea3d434"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow10;
		public ProcessConditionalFlow ConditionalFlow10 {
			get {
				return _conditionalFlow10 ?? (_conditionalFlow10 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow10",
					SchemaElementUId = new Guid("fe99e954-54c6-4dbc-ae4e-724f11084d1e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow4;
		public ProcessConditionalFlow ConditionalFlow4 {
			get {
				return _conditionalFlow4 ?? (_conditionalFlow4 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow4",
					SchemaElementUId = new Guid("6f012dc4-0679-4da3-84ce-757680848a3c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow7;
		public ProcessConditionalFlow ConditionalFlow7 {
			get {
				return _conditionalFlow7 ?? (_conditionalFlow7 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow7",
					SchemaElementUId = new Guid("e1fae17b-971d-469e-82c9-0d8f1161f09b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow11;
		public ProcessConditionalFlow ConditionalFlow11 {
			get {
				return _conditionalFlow11 ?? (_conditionalFlow11 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow11",
					SchemaElementUId = new Guid("aff117cc-494a-447b-824c-ea45bf0c048a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow12;
		public ProcessConditionalFlow ConditionalFlow12 {
			get {
				return _conditionalFlow12 ?? (_conditionalFlow12 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow12",
					SchemaElementUId = new Guid("b3fa892c-1d0a-4e76-a01e-553b47b9714a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow3;
		public ProcessConditionalFlow ConditionalFlow3 {
			get {
				return _conditionalFlow3 ?? (_conditionalFlow3 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow3",
					SchemaElementUId = new Guid("483624cb-e100-4417-b0d7-2d89990301bc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow5;
		public ProcessConditionalFlow ConditionalFlow5 {
			get {
				return _conditionalFlow5 ?? (_conditionalFlow5 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow5",
					SchemaElementUId = new Guid("e9f42fb2-6bda-464a-8a5a-cfb4b9ca50b1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessToken _opportunityStageProspectingToken;
		public ProcessToken OpportunityStageProspectingToken {
			get {
				return _opportunityStageProspectingToken ?? (_opportunityStageProspectingToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageProspectingToken",
					SchemaElementUId = new Guid("782edabc-0368-4df6-9a66-de3930602cec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _opportunityStageNeedsAnalysisToken;
		public ProcessToken OpportunityStageNeedsAnalysisToken {
			get {
				return _opportunityStageNeedsAnalysisToken ?? (_opportunityStageNeedsAnalysisToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageNeedsAnalysisToken",
					SchemaElementUId = new Guid("fce49da6-501f-4ee2-a918-050aabbde4fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _opportunityStageOppManagementValuePpropositionToken;
		public ProcessToken OpportunityStageOppManagementValuePpropositionToken {
			get {
				return _opportunityStageOppManagementValuePpropositionToken ?? (_opportunityStageOppManagementValuePpropositionToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageOppManagementValuePpropositionToken",
					SchemaElementUId = new Guid("f6bb6c56-91c0-4c6d-af8a-121a7752e9c5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _opportunityStageIdDecisionMakersToken;
		public ProcessToken OpportunityStageIdDecisionMakersToken {
			get {
				return _opportunityStageIdDecisionMakersToken ?? (_opportunityStageIdDecisionMakersToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageIdDecisionMakersToken",
					SchemaElementUId = new Guid("18fa16dc-8ca4-49b8-a07c-4aae568be19b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _opportunityStageOppManagementPerceptionAnalysisToken;
		public ProcessToken OpportunityStageOppManagementPerceptionAnalysisToken {
			get {
				return _opportunityStageOppManagementPerceptionAnalysisToken ?? (_opportunityStageOppManagementPerceptionAnalysisToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageOppManagementPerceptionAnalysisToken",
					SchemaElementUId = new Guid("028384c1-a3f6-49c7-b0a7-54a3f1cb05bc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _opportunityStageOppManagementProposalToken;
		public ProcessToken OpportunityStageOppManagementProposalToken {
			get {
				return _opportunityStageOppManagementProposalToken ?? (_opportunityStageOppManagementProposalToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageOppManagementProposalToken",
					SchemaElementUId = new Guid("cf6f56c3-4f21-40f7-8087-40788d4f1b40"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _opportunityStageOppManagementNegotiationsToken;
		public ProcessToken OpportunityStageOppManagementNegotiationsToken {
			get {
				return _opportunityStageOppManagementNegotiationsToken ?? (_opportunityStageOppManagementNegotiationsToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageOppManagementNegotiationsToken",
					SchemaElementUId = new Guid("a82babee-5329-4aaf-8565-a92cbd85315c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _opportunityStageOppManagementContractationToken;
		public ProcessToken OpportunityStageOppManagementContractationToken {
			get {
				return _opportunityStageOppManagementContractationToken ?? (_opportunityStageOppManagementContractationToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "OpportunityStageOppManagementContractationToken",
					SchemaElementUId = new Guid("86cd820f-10f8-4b7f-aada-3d123a5f1757"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _storeIsStageChangedByUserOppManagementEndStageToken;
		public ProcessToken StoreIsStageChangedByUserOppManagementEndStageToken {
			get {
				return _storeIsStageChangedByUserOppManagementEndStageToken ?? (_storeIsStageChangedByUserOppManagementEndStageToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "StoreIsStageChangedByUserOppManagementEndStageToken",
					SchemaElementUId = new Guid("7669db1a-0421-4354-b3ef-a52c449e9b13"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ReadOppData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadOppData };
			FlowElements[OpportunityStage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStage };
			FlowElements[Prospecting.SchemaElementUId] = new Collection<ProcessFlowElement> { Prospecting };
			FlowElements[Terminate3.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate3 };
			FlowElements[NeedsAnalysis.SchemaElementUId] = new Collection<ProcessFlowElement> { NeedsAnalysis };
			FlowElements[OppManagementValuePproposition.SchemaElementUId] = new Collection<ProcessFlowElement> { OppManagementValuePproposition };
			FlowElements[IdDecisionMakers.SchemaElementUId] = new Collection<ProcessFlowElement> { IdDecisionMakers };
			FlowElements[OppManagementPerceptionAnalysis.SchemaElementUId] = new Collection<ProcessFlowElement> { OppManagementPerceptionAnalysis };
			FlowElements[OppManagementProposal.SchemaElementUId] = new Collection<ProcessFlowElement> { OppManagementProposal };
			FlowElements[OppManagementNegotiations.SchemaElementUId] = new Collection<ProcessFlowElement> { OppManagementNegotiations };
			FlowElements[OppManagementContractation.SchemaElementUId] = new Collection<ProcessFlowElement> { OppManagementContractation };
			FlowElements[OppManagementEndStage.SchemaElementUId] = new Collection<ProcessFlowElement> { OppManagementEndStage };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[FindPresentation.SchemaElementUId] = new Collection<ProcessFlowElement> { FindPresentation };
			FlowElements[SavePresentationParameter2.SchemaElementUId] = new Collection<ProcessFlowElement> { SavePresentationParameter2 };
			FlowElements[LinkOppToProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { LinkOppToProcess };
			FlowElements[ReadOppMainContact.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadOppMainContact };
			FlowElements[SaveMainContactParameter.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveMainContactParameter };
			FlowElements[StartSignalLeadStageChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignalLeadStageChange };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[StartOppBusinessProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { StartOppBusinessProcess };
			FlowElements[OpenEditPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageUserTask1 };
			FlowElements[ExclusiveGateway4.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway4 };
			FlowElements[Terminate4.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate4 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[FormulaTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask2 };
			FlowElements[StoreIsStageChangedByUser.SchemaElementUId] = new Collection<ProcessFlowElement> { StoreIsStageChangedByUser };
			FlowElements[ResetIsStageChangedByUser.SchemaElementUId] = new Collection<ProcessFlowElement> { ResetIsStageChangedByUser };
			FlowElements[ReadDataLead.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataLead };
			FlowElements[ChangeDataLead.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataLead };
			FlowElements[ExclusiveGatewaySetDateTimePresentation.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewaySetDateTimePresentation };
			FlowElements[Terminate2.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate2 };
			FlowElements[AddDataContactToOpportunity.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataContactToOpportunity };
			FlowElements[ExclusiveGatewayLeadQualifiedAsContact.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayLeadQualifiedAsContact };
			FlowElements[AddDataOpportunity.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataOpportunity };
			FlowElements[ReadDataCountOpportunityByAccount.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataCountOpportunityByAccount };
			FlowElements[ReadDataAccount.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataAccount };
			FlowElements[FormulaTaskAccountByLead.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTaskAccountByLead };
			FlowElements[ReadDataContact.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataContact };
			FlowElements[ExclusiveGatewayQualifiedByAccount.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayQualifiedByAccount };
			FlowElements[SaveCurrOppParameter.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveCurrOppParameter };
			FlowElements[PresentationTaskCreation.SchemaElementUId] = new Collection<ProcessFlowElement> { PresentationTaskCreation };
			FlowElements[SavePresentationParameter.SchemaElementUId] = new Collection<ProcessFlowElement> { SavePresentationParameter };
			FlowElements[ReadOppoortunityData2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadOppoortunityData2 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[FormulaTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask3 };
			FlowElements[FormulaTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask4 };
			FlowElements[FormulaTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask5 };
			FlowElements[FormulaTask6.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask6 };
			FlowElements[FormulaTask7.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask7 };
			FlowElements[FormulaTask8.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask8 };
			FlowElements[FormulaTask9.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask9 };
			FlowElements[OpportunityStageProspectingToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageProspectingToken };
			FlowElements[OpportunityStageNeedsAnalysisToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageNeedsAnalysisToken };
			FlowElements[OpportunityStageOppManagementValuePpropositionToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageOppManagementValuePpropositionToken };
			FlowElements[OpportunityStageIdDecisionMakersToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageIdDecisionMakersToken };
			FlowElements[OpportunityStageOppManagementPerceptionAnalysisToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageOppManagementPerceptionAnalysisToken };
			FlowElements[OpportunityStageOppManagementProposalToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageOppManagementProposalToken };
			FlowElements[OpportunityStageOppManagementNegotiationsToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageOppManagementNegotiationsToken };
			FlowElements[OpportunityStageOppManagementContractationToken.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityStageOppManagementContractationToken };
			FlowElements[StoreIsStageChangedByUserOppManagementEndStageToken.SchemaElementUId] = new Collection<ProcessFlowElement> { StoreIsStageChangedByUserOppManagementEndStageToken };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ReadOppData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadOppMainContact", e.Context.SenderName));
						break;
					case "OpportunityStage":
						if (ProspectingStageExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageProspectingToken", e.Context.SenderName));
							break;
						}
						if (NeedAnalysisStageExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageNeedsAnalysisToken", e.Context.SenderName));
							break;
						}
						if (ValuePropositionExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageOppManagementValuePpropositionToken", e.Context.SenderName));
							break;
						}
						if (DecisionMakersExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageIdDecisionMakersToken", e.Context.SenderName));
							break;
						}
						if (PerceptionAnalysisStageExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageOppManagementPerceptionAnalysisToken", e.Context.SenderName));
							break;
						}
						if (NegotiationsStageExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageOppManagementNegotiationsToken", e.Context.SenderName));
							break;
						}
						if (ContractationStageExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageOppManagementContractationToken", e.Context.SenderName));
							break;
						}
						if (ProposalStageExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStageOppManagementProposalToken", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate3", e.Context.SenderName));
						break;
					case "Prospecting":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUser", e.Context.SenderName));
						break;
					case "Terminate3":
						CompleteProcess();
						break;
					case "NeedsAnalysis":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUser", e.Context.SenderName));
						break;
					case "OppManagementValuePproposition":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask2", e.Context.SenderName));
						break;
					case "IdDecisionMakers":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUser", e.Context.SenderName));
						break;
					case "OppManagementPerceptionAnalysis":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUser", e.Context.SenderName));
						break;
					case "OppManagementProposal":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUser", e.Context.SenderName));
						break;
					case "OppManagementNegotiations":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUser", e.Context.SenderName));
						break;
					case "OppManagementContractation":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate3", e.Context.SenderName));
						break;
					case "OppManagementEndStage":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadOppData", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FindPresentation", e.Context.SenderName));
						break;
					case "FindPresentation":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkOppToProcess", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SavePresentationParameter2", e.Context.SenderName));
						break;
					case "SavePresentationParameter2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkOppToProcess", e.Context.SenderName));
						break;
					case "LinkOppToProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadOppData", e.Context.SenderName));
						break;
					case "ReadOppMainContact":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SaveMainContactParameter", e.Context.SenderName));
						break;
					case "SaveMainContactParameter":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ResetIsStageChangedByUser", e.Context.SenderName));
						break;
					case "StartSignalLeadStageChange":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway3", e.Context.SenderName));
						break;
					case "ExclusiveGateway3":
						if (ConditionalFlow11ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataLead", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate2", e.Context.SenderName));
						break;
					case "StartOppBusinessProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "OpenEditPageUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway4", e.Context.SenderName));
						break;
					case "ExclusiveGateway4":
						if (ConditionalFlow12ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate4", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "Terminate4":
						CompleteProcess();
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkOppToProcess", e.Context.SenderName));
						break;
					case "FormulaTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUser", e.Context.SenderName));
						break;
					case "StoreIsStageChangedByUser":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StoreIsStageChangedByUserOppManagementEndStageToken", e.Context.SenderName));
						break;
					case "ResetIsStageChangedByUser":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpportunityStage", e.Context.SenderName));
						break;
					case "ReadDataLead":
						if (ConditionalFlow7ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayQualifiedByAccount", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate2", e.Context.SenderName));
						break;
					case "ChangeDataLead":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewaySetDateTimePresentation", e.Context.SenderName));
						break;
					case "ExclusiveGatewaySetDateTimePresentation":
						if (ConditionalFlow4ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("PresentationTaskCreation", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SaveCurrOppParameter", e.Context.SenderName));
						break;
					case "Terminate2":
						CompleteProcess();
						break;
					case "AddDataContactToOpportunity":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadOppoortunityData2", e.Context.SenderName));
						break;
					case "ExclusiveGatewayLeadQualifiedAsContact":
						if (ConditionalFlow10ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataContactToOpportunity", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadOppoortunityData2", e.Context.SenderName));
						break;
					case "AddDataOpportunity":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayLeadQualifiedAsContact", e.Context.SenderName));
						break;
					case "ReadDataCountOpportunityByAccount":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask4", e.Context.SenderName));
						break;
					case "ReadDataAccount":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask5", e.Context.SenderName));
						break;
					case "FormulaTaskAccountByLead":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataAccount", e.Context.SenderName));
						break;
					case "ReadDataContact":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask6", e.Context.SenderName));
						break;
					case "ExclusiveGatewayQualifiedByAccount":
						if (ConditionalFlow8ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTaskAccountByLead", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "SaveCurrOppParameter":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "PresentationTaskCreation":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SavePresentationParameter", e.Context.SenderName));
						break;
					case "SavePresentationParameter":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SaveCurrOppParameter", e.Context.SenderName));
						break;
					case "ReadOppoortunityData2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataLead", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkOppToProcess", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkOppToProcess", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow5ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask7", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask3", e.Context.SenderName));
						break;
					case "FormulaTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask8", e.Context.SenderName));
						break;
					case "FormulaTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask9", e.Context.SenderName));
						break;
					case "FormulaTask5":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataCountOpportunityByAccount", e.Context.SenderName));
						break;
					case "FormulaTask6":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "FormulaTask7":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataContact", e.Context.SenderName));
						break;
					case "FormulaTask8":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataOpportunity", e.Context.SenderName));
						break;
					case "FormulaTask9":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataOpportunity", e.Context.SenderName));
						break;
					case "OpportunityStageProspectingToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Prospecting", e.Context.SenderName));
						break;
					case "OpportunityStageNeedsAnalysisToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("NeedsAnalysis", e.Context.SenderName));
						break;
					case "OpportunityStageOppManagementValuePpropositionToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OppManagementValuePproposition", e.Context.SenderName));
						break;
					case "OpportunityStageIdDecisionMakersToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IdDecisionMakers", e.Context.SenderName));
						break;
					case "OpportunityStageOppManagementPerceptionAnalysisToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OppManagementPerceptionAnalysis", e.Context.SenderName));
						break;
					case "OpportunityStageOppManagementProposalToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OppManagementProposal", e.Context.SenderName));
						break;
					case "OpportunityStageOppManagementNegotiationsToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OppManagementNegotiations", e.Context.SenderName));
						break;
					case "OpportunityStageOppManagementContractationToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OppManagementContractation", e.Context.SenderName));
						break;
					case "StoreIsStageChangedByUserOppManagementEndStageToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OppManagementEndStage", e.Context.SenderName));
						break;
			}
		}

		private bool ProspectingStageExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("c2067b11-0ee0-df11-971b-001d60e938c6"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "ProspectingStage", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"c2067b11-0ee0-df11-971b-001d60e938c6\")", result);
			return result;
		}

		private bool NeedAnalysisStageExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("2a6de0f7-44d9-4b8a-bce6-acddb7ed8915"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "NeedAnalysisStage", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"2a6de0f7-44d9-4b8a-bce6-acddb7ed8915\")", result);
			return result;
		}

		private bool ValuePropositionExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("325f0619-0ee0-df11-971b-001d60e938c6"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "ValueProposition", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"325f0619-0ee0-df11-971b-001d60e938c6\")", result);
			return result;
		}

		private bool DecisionMakersExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("f4e4a00b-ec48-46d0-9ea0-c2b502165ee9"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "DecisionMakers", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"f4e4a00b-ec48-46d0-9ea0-c2b502165ee9\")", result);
			return result;
		}

		private bool PerceptionAnalysisStageExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("241ade6b-4256-4947-ba8a-7d96988a97b6"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "PerceptionAnalysisStage", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"241ade6b-4256-4947-ba8a-7d96988a97b6\")", result);
			return result;
		}

		private bool NegotiationsStageExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("f808c955-c5aa-4aba-95c0-ba7d584d2f32"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "NegotiationsStage", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"f808c955-c5aa-4aba-95c0-ba7d584d2f32\")", result);
			return result;
		}

		private bool ContractationStageExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("fb563df2-5ae6-df11-971b-001d60e938c6"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "ContractationStage", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"fb563df2-5ae6-df11-971b-001d60e938c6\")", result);
			return result;
		}

		private bool ProposalStageExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty))==new Guid("423774cb-5ae6-df11-971b-001d60e938c6"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "OpportunityStage", "ProposalStage", "((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName(\"Stage\").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>(\"StageId\") : Guid.Empty))==new Guid(\"423774cb-5ae6-df11-971b-001d60e938c6\")", result);
			return result;
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((CurrentOpportunity) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway2", "ConditionalFlow1", "(CurrentOpportunity) == Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((FindPresentation.ResultEntityCollection).Count == 0);
			Log.InfoFormat(ConditionalExpressionLogMessage, "FindPresentation", "ConditionalFlow2", "(FindPresentation.ResultEntityCollection).Count == 0", result);
			return result;
		}

		private bool ConditionalFlow8ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayQualifiedByAccount", "ConditionalFlow8", "((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName(\"QualifiedAccount\").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>(\"QualifiedAccountId\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow10ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayLeadQualifiedAsContact", "ConditionalFlow10", "((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName(\"QualifiedContact\").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>(\"QualifiedContactId\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow4ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("MeetingDate").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<DateTime>("MeetingDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))) != null && !DateTime.MinValue.Equals(((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("MeetingDate").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<DateTime>("MeetingDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture)))));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewaySetDateTimePresentation", "ConditionalFlow4", "((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName(\"MeetingDate\").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<DateTime>(\"MeetingDate\") : DateTime.ParseExact(\"01.01.0001 0:00\", \"dd.MM.yyyy H:mm\", CultureInfo.InvariantCulture))) != null && !DateTime.MinValue.Equals(((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName(\"MeetingDate\").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<DateTime>(\"MeetingDate\") : DateTime.ParseExact(\"01.01.0001 0:00\", \"dd.MM.yyyy H:mm\", CultureInfo.InvariantCulture))))", result);
			return result;
		}

		private bool ConditionalFlow7ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("Opportunity").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("OpportunityId") : Guid.Empty)) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataLead", "ConditionalFlow7", "((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName(\"Opportunity\").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>(\"OpportunityId\") : Guid.Empty)) == Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow11ExpressionExecute() {
			bool result = Convert.ToBoolean(((Boolean)SysSettings.GetValue(UserConnection, "StartOppBusinessProcess")) == true);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway3", "ConditionalFlow11", "((Boolean)SysSettings.GetValue(UserConnection, \"StartOppBusinessProcess\")) == true", result);
			return result;
		}

		private bool ConditionalFlow12ExpressionExecute() {
			bool result = Convert.ToBoolean((OpenEditPageUserTask1.RecordId) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway4", "ConditionalFlow12", "(OpenEditPageUserTask1.RecordId) == Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean((ReadDataUserTask1.ResultCount) == 0);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask1", "ConditionalFlow3", "(ReadDataUserTask1.ResultCount) == 0", result);
			return result;
		}

		private bool ConditionalFlow5ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty))  != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow5", "((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName(\"QualifiedContact\").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>(\"QualifiedContactId\") : Guid.Empty))  != Guid.Empty", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CurrentOpportunity")) {
				writer.WriteValue("CurrentOpportunity", CurrentOpportunity, Guid.Empty);
			}
			if (!HasMapping("Presentation")) {
				writer.WriteValue("Presentation", Presentation, Guid.Empty);
			}
			if (!HasMapping("MainContact")) {
				writer.WriteValue("MainContact", MainContact, Guid.Empty);
			}
			if (!HasMapping("Account")) {
				writer.WriteValue("Account", Account, Guid.Empty);
			}
			if (!HasMapping("IsStageChangedByUser")) {
				writer.WriteValue("IsStageChangedByUser", IsStageChangedByUser, false);
			}
			if (!HasMapping("ClientOpportunityCount")) {
				writer.WriteValue("ClientOpportunityCount", ClientOpportunityCount, 0);
			}
			if (!HasMapping("OpportunityTitle")) {
				writer.WriteValue("OpportunityTitle", OpportunityTitle, null);
			}
			if (!HasMapping("Contact")) {
				writer.WriteValue("Contact", Contact, Guid.Empty);
			}
			if (!HasMapping("ClientName")) {
				writer.WriteValue("ClientName", ClientName, null);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			if (IsProcessExecutedBySignal) {
				return;
			}
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartOppBusinessProcess", string.Empty));
		}

		protected override void CompleteApplyingFlowElementsPropertiesData() {
			base.CompleteApplyingFlowElementsPropertiesData();
			foreach (var item in FlowElements) {
				foreach (var itemValue in item.Value) {
					if (Guid.Equals(itemValue.CreatedInSchemaUId, InternalSchemaUId)) {
						itemValue.ExecutedEventHandler = OnExecuted;
					}
				}
			}
		}

		protected override void InitializeMetaPathParameterValues() {
			base.InitializeMetaPathParameterValues();
			MetaPathParameterValues.Add("af8eea9e-0e11-426e-a870-2cff33d00f84", () => CurrentOpportunity);
			MetaPathParameterValues.Add("0eae6fcc-65b6-433e-b4dc-e42323c488c1", () => Presentation);
			MetaPathParameterValues.Add("b8d6c762-b63e-49b7-b651-c8d29f9c8d74", () => MainContact);
			MetaPathParameterValues.Add("342aec56-8359-4c5b-826b-9e8489fd6a4b", () => Account);
			MetaPathParameterValues.Add("9786c0e4-cc5f-4c9f-b46d-090a297e2b74", () => IsStageChangedByUser);
			MetaPathParameterValues.Add("02b1469d-72ad-4909-a7cf-6b41b79d41a7", () => ClientOpportunityCount);
			MetaPathParameterValues.Add("738ceb61-832b-4b27-a973-9347e26e827e", () => OpportunityTitle);
			MetaPathParameterValues.Add("b6534525-3848-4420-8930-e7bcc98a1756", () => Contact);
			MetaPathParameterValues.Add("b2b54e53-5309-4650-ac67-b8a4705d22b4", () => ClientName);
			MetaPathParameterValues.Add("378a7c4d-c2ae-4dc0-8450-7d00de21889a", () => ReadOppData.DataSourceFilters);
			MetaPathParameterValues.Add("09ca5d94-4475-494b-bb1d-1711734825d0", () => ReadOppData.ResultType);
			MetaPathParameterValues.Add("809504a0-92ba-4c37-9223-2bd86178ceeb", () => ReadOppData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("47e4b981-ae34-43d6-80d1-541eb76f8886", () => ReadOppData.NumberOfRecords);
			MetaPathParameterValues.Add("093cfd0d-3919-4594-bdbd-243b89c2421c", () => ReadOppData.FunctionType);
			MetaPathParameterValues.Add("99a55b65-320e-4a00-a443-906ccbd17195", () => ReadOppData.AggregationColumnName);
			MetaPathParameterValues.Add("ea0a8aa9-15cc-4e7b-b857-0fde66046c9d", () => ReadOppData.OrderInfo);
			MetaPathParameterValues.Add("61d6f451-48d9-4c96-917b-f6c5ce85df83", () => ReadOppData.ResultEntity);
			MetaPathParameterValues.Add("10ddcd85-ccf7-42e5-8390-78074cc70ded", () => ReadOppData.ResultCount);
			MetaPathParameterValues.Add("c1248569-3f8c-43f3-9cb3-48975e8f84ef", () => ReadOppData.ResultIntegerFunction);
			MetaPathParameterValues.Add("3feedf55-86a5-4ac5-bb7d-a85d1a84eb9d", () => ReadOppData.ResultFloatFunction);
			MetaPathParameterValues.Add("734b2f72-a22c-41d7-900f-06d5bb7faf75", () => ReadOppData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("d60364bd-0961-431f-8a33-c5f616c3de09", () => ReadOppData.ResultRowsCount);
			MetaPathParameterValues.Add("5fc444a5-9b7a-422c-8693-86213fa317e7", () => ReadOppData.CanReadUncommitedData);
			MetaPathParameterValues.Add("e4513fe5-860a-4300-889d-38b3328e8894", () => ReadOppData.ResultEntityCollection);
			MetaPathParameterValues.Add("adee94c3-29c5-4b7a-960c-20c6b71d3afb", () => ReadOppData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("454dc5b0-a0d3-4a3d-b852-62380501a11c", () => ReadOppData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("b8a4d7c8-f486-4ff4-8d57-c646ef576c20", () => ReadOppData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("1642233f-c291-40c4-83ec-5184121f5590", () => ReadOppData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("81432db0-f5f5-40d1-8f22-4d8c3bb4cf48", () => Prospecting.CurrentOpportunity);
			MetaPathParameterValues.Add("eb29a402-5da5-4f9b-844c-e79f4e1f115a", () => Prospecting.OpportunityStageChanged);
			MetaPathParameterValues.Add("fdc628cc-1da4-4b5d-b397-d6c93e1e9517", () => Prospecting.MainContact);
			MetaPathParameterValues.Add("5b443132-caa7-4f82-80dd-cc84a5380caa", () => NeedsAnalysis.CurrentOpportunity);
			MetaPathParameterValues.Add("6a80392b-c787-4788-a532-fca2370b3840", () => NeedsAnalysis.OpportunityStageChanged);
			MetaPathParameterValues.Add("5e47a6d3-f9bb-404f-87e2-aed31c62acc3", () => NeedsAnalysis.MainContact);
			MetaPathParameterValues.Add("4274528b-203f-43bc-87d3-abf86b9a792e", () => OppManagementValuePproposition.CurrentOpportunity);
			MetaPathParameterValues.Add("b20705a6-a8bc-460d-8389-aaaa9b58be16", () => OppManagementValuePproposition.OpportunityStageChanged);
			MetaPathParameterValues.Add("f7d5c580-2ff1-4209-a013-2bef80d7f3a9", () => OppManagementValuePproposition.Presentation);
			MetaPathParameterValues.Add("2a0e89a7-92f6-4cf6-a9f2-a0140105ba95", () => OppManagementValuePproposition.MainContact);
			MetaPathParameterValues.Add("76602486-f8b8-47cb-8b9f-d00841250f90", () => IdDecisionMakers.CurrentOpportunity);
			MetaPathParameterValues.Add("e6028b5e-002d-4bc7-bc34-8affd537f00c", () => IdDecisionMakers.OpportunityStageChanged);
			MetaPathParameterValues.Add("5dc6ce94-0fc5-4ffa-8e00-83c67ce5da35", () => IdDecisionMakers.MainContact);
			MetaPathParameterValues.Add("c647b290-fae9-4f2f-b291-b94262f923dc", () => OppManagementPerceptionAnalysis.CurrentOpportunity);
			MetaPathParameterValues.Add("2d34fbe8-274b-4c6e-88d8-7307f538cfee", () => OppManagementPerceptionAnalysis.OpportunityStageChanged);
			MetaPathParameterValues.Add("36230419-640f-4176-ad85-8beca7d791ca", () => OppManagementPerceptionAnalysis.MainContact);
			MetaPathParameterValues.Add("0a768934-39e6-4d8e-9fd4-4859b59f0779", () => OppManagementProposal.CurrentOpportunity);
			MetaPathParameterValues.Add("2902276d-abfd-4fd2-b6f9-b5bda02f0222", () => OppManagementProposal.OpportunityStageChanged);
			MetaPathParameterValues.Add("dc02a11c-a24c-4451-897b-9dce3a6a7178", () => OppManagementProposal.MainContact);
			MetaPathParameterValues.Add("f58812eb-a5a3-43ef-84a7-454b69c3aaed", () => OppManagementNegotiations.CurrentOpportunity);
			MetaPathParameterValues.Add("33eb9e90-615e-412b-86bf-8d9f6c8831a8", () => OppManagementNegotiations.OpportunityStageChanged);
			MetaPathParameterValues.Add("47d1669f-a6cc-48ac-85b8-94795d69938e", () => OppManagementNegotiations.MainContact);
			MetaPathParameterValues.Add("a2600d6c-144b-4c75-acb3-f04cb1577884", () => OppManagementContractation.CurrentOpportunity);
			MetaPathParameterValues.Add("16815d2d-6357-4be4-9265-46e9a99e093b", () => OppManagementContractation.OpportunityStageChanged);
			MetaPathParameterValues.Add("b812d4a7-16f1-4a13-b2e9-f0b2c48a8532", () => OppManagementContractation.MainContact);
			MetaPathParameterValues.Add("1494d351-8b28-4d15-a088-912b8872f732", () => OppManagementEndStage.CurrentOpportunity);
			MetaPathParameterValues.Add("0fa7431c-1004-411e-ae2e-b485fc040737", () => OppManagementEndStage.NextOpportunityStageNumber);
			MetaPathParameterValues.Add("dcb46392-5cd0-43ba-9004-211ef9690ca5", () => OppManagementEndStage.CurrentStage);
			MetaPathParameterValues.Add("9c2d0712-831e-499c-a94b-562db3eaed86", () => OppManagementEndStage.Recommendation);
			MetaPathParameterValues.Add("2f2941be-b24c-4797-8b31-addbd6057927", () => OppManagementEndStage.IsStageChangedByUser);
			MetaPathParameterValues.Add("ef2201a2-720c-453d-8a5b-62d5077c6041", () => OppManagementEndStage.DontShowPageEndOfStage);
			MetaPathParameterValues.Add("a8f664f6-40f1-4b7e-9602-25265d8962b3", () => OppManagementEndStage.NextStage);
			MetaPathParameterValues.Add("590098f3-05ec-4bc7-ac56-18d861124c44", () => FindPresentation.DataSourceFilters);
			MetaPathParameterValues.Add("d7349ecf-3808-499e-94e5-a6af0b6c8059", () => FindPresentation.ResultType);
			MetaPathParameterValues.Add("3ddba6f3-67f9-46a5-bda4-c9be1d38263b", () => FindPresentation.ReadSomeTopRecords);
			MetaPathParameterValues.Add("7711d045-dde7-4665-b251-2b6cda4ba16c", () => FindPresentation.NumberOfRecords);
			MetaPathParameterValues.Add("14ac52bb-d8de-4e93-ba14-2092314ad9ec", () => FindPresentation.FunctionType);
			MetaPathParameterValues.Add("44ef2079-3350-48f5-8417-a062c43f2a0e", () => FindPresentation.AggregationColumnName);
			MetaPathParameterValues.Add("f79b49c3-44b7-458a-af53-ffc25ba8de44", () => FindPresentation.OrderInfo);
			MetaPathParameterValues.Add("bcd38317-a882-4317-8881-b21b8f0ca57b", () => FindPresentation.ResultEntity);
			MetaPathParameterValues.Add("9371b699-8ba0-411a-be54-7912877edf8f", () => FindPresentation.ResultCount);
			MetaPathParameterValues.Add("ca81fffe-20a5-46bf-ab20-5fa6f0638a5f", () => FindPresentation.ResultIntegerFunction);
			MetaPathParameterValues.Add("6c987b70-a95f-48b9-bcfb-8ddc2192e44a", () => FindPresentation.ResultFloatFunction);
			MetaPathParameterValues.Add("e64f2c49-b461-45e7-bb8f-1f660acca3cc", () => FindPresentation.ResultDateTimeFunction);
			MetaPathParameterValues.Add("b598adf2-e516-42e9-9f34-f99fb251a690", () => FindPresentation.ResultRowsCount);
			MetaPathParameterValues.Add("5b343947-0aa5-4776-9b18-096d905e7603", () => FindPresentation.CanReadUncommitedData);
			MetaPathParameterValues.Add("6f8cde56-f764-4ad1-b528-0d9031cd1e8e", () => FindPresentation.ResultEntityCollection);
			MetaPathParameterValues.Add("6351aab6-3117-48e1-afe4-c9ad827a53d7", () => FindPresentation.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("1fbf3104-1357-48ca-926e-2f85305a4602", () => FindPresentation.IgnoreDisplayValues);
			MetaPathParameterValues.Add("4b31518f-f475-452a-8aba-9cda085b4492", () => FindPresentation.ResultCompositeObjectList);
			MetaPathParameterValues.Add("58a36797-420b-4f2a-a864-3829561982fe", () => FindPresentation.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("41befda8-dd24-45a3-8e91-5fa9d9e03fa0", () => LinkOppToProcess.EntityId);
			MetaPathParameterValues.Add("773490bc-4ab0-4078-9f03-a0ead61c8e69", () => LinkOppToProcess.EntitySchemaId);
			MetaPathParameterValues.Add("6ec44add-c3cb-4c83-aa2a-21116fe737ce", () => ReadOppMainContact.DataSourceFilters);
			MetaPathParameterValues.Add("d00d1284-6858-4e40-8c5e-a0f9533fcf07", () => ReadOppMainContact.ResultType);
			MetaPathParameterValues.Add("b0d4d59f-c216-40cc-ae96-8a3781c09399", () => ReadOppMainContact.ReadSomeTopRecords);
			MetaPathParameterValues.Add("e0d7bbe7-f11e-455f-b2e5-ea58c2f931f5", () => ReadOppMainContact.NumberOfRecords);
			MetaPathParameterValues.Add("c886b18d-6796-4aed-9bbf-b5cf5d06a8fb", () => ReadOppMainContact.FunctionType);
			MetaPathParameterValues.Add("57ed4753-40aa-4155-9040-01d05641a1f9", () => ReadOppMainContact.AggregationColumnName);
			MetaPathParameterValues.Add("5f7ffe6c-b419-41a7-92a7-41c7106f2edd", () => ReadOppMainContact.OrderInfo);
			MetaPathParameterValues.Add("7e1be2d8-91ed-49a9-b295-80136f24d052", () => ReadOppMainContact.ResultEntity);
			MetaPathParameterValues.Add("57df5b20-4163-4583-a743-b3bd41e7476c", () => ReadOppMainContact.ResultCount);
			MetaPathParameterValues.Add("36a1459d-8951-4d2d-83c0-ce1785ad17d6", () => ReadOppMainContact.ResultIntegerFunction);
			MetaPathParameterValues.Add("5227d4a1-7e1a-488c-b08f-249e8af25b4f", () => ReadOppMainContact.ResultFloatFunction);
			MetaPathParameterValues.Add("26f8e2e7-d0a5-4cce-a1c4-005d27eac4ef", () => ReadOppMainContact.ResultDateTimeFunction);
			MetaPathParameterValues.Add("a91ced74-aa15-4fc9-ad90-beb2c4848a91", () => ReadOppMainContact.ResultRowsCount);
			MetaPathParameterValues.Add("0597c0d4-7fe9-438b-996d-a1cec2485907", () => ReadOppMainContact.CanReadUncommitedData);
			MetaPathParameterValues.Add("24109401-bfc2-4470-b36d-6264dd15b451", () => ReadOppMainContact.ResultEntityCollection);
			MetaPathParameterValues.Add("213f4da0-dbd4-4801-9f20-61ad02c52c1a", () => ReadOppMainContact.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("14eb509a-8789-4d60-a6db-802311455631", () => ReadOppMainContact.IgnoreDisplayValues);
			MetaPathParameterValues.Add("d0767765-3046-4ca8-9f14-831752bcf2cb", () => ReadOppMainContact.ResultCompositeObjectList);
			MetaPathParameterValues.Add("cc9eac64-33dd-45a4-b215-5fd338d82349", () => ReadOppMainContact.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("db9eb8c4-a431-4aa1-9ee4-580f6ffe1896", () => StartSignalLeadStageChange.RecordId);
			MetaPathParameterValues.Add("e33c0cfe-adc7-4b51-8f8f-370d3a2a3f3d", () => StartSignalLeadStageChange.EntitySchemaUId);
			MetaPathParameterValues.Add("89651dda-ab13-4a9a-8a6c-4c658eb62d6b", () => OpenEditPageUserTask1.ObjectSchemaId);
			MetaPathParameterValues.Add("26dd7e96-d79a-4c1d-a31a-e8388a3d205d", () => OpenEditPageUserTask1.PageSchemaId);
			MetaPathParameterValues.Add("816e7c8a-2c10-4a6f-9be0-35eb9c4ddff5", () => OpenEditPageUserTask1.EditMode);
			MetaPathParameterValues.Add("97a322a9-f1ca-49d6-ab97-756349dc65dc", () => OpenEditPageUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("c5f0d6a4-d18b-446e-8335-18fb080f660a", () => OpenEditPageUserTask1.RecordId);
			MetaPathParameterValues.Add("dc433afb-dfc9-4098-97f6-caf21a16f74e", () => OpenEditPageUserTask1.ExecutedMode);
			MetaPathParameterValues.Add("1c82493a-8e96-4e42-8e59-0050ff57ccc6", () => OpenEditPageUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("933618d4-76fc-43ac-ac72-94ef456a3325", () => OpenEditPageUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("0e24948f-5ffc-48eb-8cd6-6290a4458b50", () => OpenEditPageUserTask1.GenerateDecisionsFromColumn);
			MetaPathParameterValues.Add("41355bca-971c-4003-990e-8da96ce29d27", () => OpenEditPageUserTask1.DecisionalColumnMetaPath);
			MetaPathParameterValues.Add("b8971ff1-f4b5-4bd1-ad83-92a56940fda8", () => OpenEditPageUserTask1.ResultParameter);
			MetaPathParameterValues.Add("6399efc5-9d36-4c8d-84c5-3e5851db8ea2", () => OpenEditPageUserTask1.IsReexecution);
			MetaPathParameterValues.Add("c482b777-a1a7-41d8-86f3-3deb50dd0ff8", () => OpenEditPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("8a4540f5-5964-49f6-9dd1-077938701455", () => OpenEditPageUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("4960bd57-b2f9-45a4-9184-feb6f57d727b", () => OpenEditPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("dbe4def5-6971-4b97-a463-8f91e0d395d8", () => OpenEditPageUserTask1.Duration);
			MetaPathParameterValues.Add("865a5fc7-ff9d-42c1-b37f-e7d02f2ef7aa", () => OpenEditPageUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("f513407c-014f-4acb-a526-b212d7445f91", () => OpenEditPageUserTask1.StartIn);
			MetaPathParameterValues.Add("8dabbbff-449b-468b-a494-80ad1cb1636d", () => OpenEditPageUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("502e4584-f30e-4b9b-bc80-da8f5149d287", () => OpenEditPageUserTask1.RemindBefore);
			MetaPathParameterValues.Add("514f3679-fd23-41d3-ac6e-b13355c6b716", () => OpenEditPageUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("ea067875-15ce-466a-b805-9fd42938fa32", () => OpenEditPageUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("ab3aea55-ee61-4a61-8d37-c77f890582a6", () => OpenEditPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("e98d7ab1-5b31-4dfd-bd8a-01a99df1c13e", () => OpenEditPageUserTask1.Lead);
			MetaPathParameterValues.Add("4fbdcb67-4e39-4e84-b5d0-e4916df0cc20", () => OpenEditPageUserTask1.Account);
			MetaPathParameterValues.Add("92150aaf-bd20-4b0b-aae5-802a6ddacaaf", () => OpenEditPageUserTask1.Contact);
			MetaPathParameterValues.Add("b9c197e7-4fda-443b-af5d-04703f2512af", () => OpenEditPageUserTask1.Opportunity);
			MetaPathParameterValues.Add("500c6c82-6637-4f8b-bb30-9fb30e6c5c7a", () => OpenEditPageUserTask1.Invoice);
			MetaPathParameterValues.Add("4450ed80-79a2-4253-bf53-f4c99757acd0", () => OpenEditPageUserTask1.Document);
			MetaPathParameterValues.Add("ad403374-d787-48cb-8401-24d5938fecff", () => OpenEditPageUserTask1.Incident);
			MetaPathParameterValues.Add("29b687ca-aff7-43a8-8cf5-918beb75a406", () => OpenEditPageUserTask1.Case);
			MetaPathParameterValues.Add("12c7bcea-bbb6-467e-8b86-c73d6c2327ac", () => OpenEditPageUserTask1.ActivityResult);
			MetaPathParameterValues.Add("0b1c3a54-c7df-40ad-9016-020646d1af0f", () => OpenEditPageUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("f71b0056-5161-4704-b6e6-57433d6cec8d", () => OpenEditPageUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("8a103d16-ba6b-4bd1-8ddc-3e9254763dc8", () => OpenEditPageUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("ef2d226f-d2f6-44b9-8885-f2dc3c38e962", () => OpenEditPageUserTask1.PageTypeUId);
			MetaPathParameterValues.Add("41c2a0db-39ad-4b1a-9e9b-392fb44871ef", () => OpenEditPageUserTask1.ActivitySchemaUId);
			MetaPathParameterValues.Add("b75c6907-0060-42e9-a1b2-3ef95bc2be78", () => OpenEditPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("66c1e2c8-d668-462c-8641-cc41b2cb6ee7", () => OpenEditPageUserTask1.Order);
			MetaPathParameterValues.Add("aef3f8a1-0813-481c-8557-882ce62c0029", () => OpenEditPageUserTask1.Requests);
			MetaPathParameterValues.Add("002eea98-0f7a-4a3f-843b-636f63d8cf6e", () => OpenEditPageUserTask1.Listing);
			MetaPathParameterValues.Add("bc19d651-dabb-46b9-9f3b-b8da6581c36d", () => OpenEditPageUserTask1.Property);
			MetaPathParameterValues.Add("f650edfc-44d9-4d70-bb68-14bd3c9ad3d1", () => OpenEditPageUserTask1.Contract);
			MetaPathParameterValues.Add("ca76ab70-8cff-4f21-81c9-b9e679c8ddff", () => OpenEditPageUserTask1.Problem);
			MetaPathParameterValues.Add("b40747ec-b53b-4474-ba15-384d04322c33", () => OpenEditPageUserTask1.Change);
			MetaPathParameterValues.Add("35d9c012-2263-46ec-952f-e92631c411de", () => OpenEditPageUserTask1.Release);
			MetaPathParameterValues.Add("cd406c52-f5b6-4f47-9117-6e510888a57e", () => OpenEditPageUserTask1.Project);
			MetaPathParameterValues.Add("9d21b7c3-5ea8-4f73-a5bf-f266ecb2b022", () => ReadDataLead.DataSourceFilters);
			MetaPathParameterValues.Add("ddb8f352-0211-44fc-8b93-f3abbd023649", () => ReadDataLead.ResultType);
			MetaPathParameterValues.Add("65843b8b-f9d2-41cc-8170-734e51b1a5ca", () => ReadDataLead.ReadSomeTopRecords);
			MetaPathParameterValues.Add("b341955e-cf2a-400b-907c-a8557f3c93c1", () => ReadDataLead.NumberOfRecords);
			MetaPathParameterValues.Add("1409c0d5-2885-44c0-8161-47a69431903e", () => ReadDataLead.FunctionType);
			MetaPathParameterValues.Add("bf8e626b-4175-4de4-99ed-f96ac7a26c1d", () => ReadDataLead.AggregationColumnName);
			MetaPathParameterValues.Add("5b1ea493-ed30-4d02-bdbb-0efcafe849f9", () => ReadDataLead.OrderInfo);
			MetaPathParameterValues.Add("d4413fda-e205-481c-828d-b4e67061712f", () => ReadDataLead.ResultEntity);
			MetaPathParameterValues.Add("95dce4e4-ff66-4664-b6f7-dacd9bf91bca", () => ReadDataLead.ResultCount);
			MetaPathParameterValues.Add("9a35a728-e367-4047-bda3-0b7be164f5ae", () => ReadDataLead.ResultIntegerFunction);
			MetaPathParameterValues.Add("7090f5b0-1f18-467e-9a40-60d3d177b9c4", () => ReadDataLead.ResultFloatFunction);
			MetaPathParameterValues.Add("11af421d-b60c-4cf9-a2f6-5d599eaa340c", () => ReadDataLead.ResultDateTimeFunction);
			MetaPathParameterValues.Add("2c5d37d8-5236-42a7-b93f-6d4732c94385", () => ReadDataLead.ResultRowsCount);
			MetaPathParameterValues.Add("83955bee-426f-4831-9715-4eda69412fb7", () => ReadDataLead.CanReadUncommitedData);
			MetaPathParameterValues.Add("2d0ef092-481e-4e72-920c-caa204e62d66", () => ReadDataLead.ResultEntityCollection);
			MetaPathParameterValues.Add("e72ba4ac-d6aa-4c7c-8d86-2be667ba6622", () => ReadDataLead.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("cc0389f7-a908-4db4-b2f9-dc8c55c3a68c", () => ReadDataLead.IgnoreDisplayValues);
			MetaPathParameterValues.Add("51f4ccd8-a3bb-4d1e-b73c-052fe071da49", () => ReadDataLead.ResultCompositeObjectList);
			MetaPathParameterValues.Add("b4764d2c-5f48-499c-866c-b435787d5c35", () => ReadDataLead.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("f161763e-878f-4674-8e4e-3fc88a6a58b3", () => ChangeDataLead.EntitySchemaUId);
			MetaPathParameterValues.Add("092165e2-051d-4f89-92cf-c710ba91ab13", () => ChangeDataLead.IsMatchConditions);
			MetaPathParameterValues.Add("6c0d30ee-7c93-4ea8-9ca4-918c3d232658", () => ChangeDataLead.DataSourceFilters);
			MetaPathParameterValues.Add("55a55d6a-8498-40c0-bdfe-95136f257586", () => ChangeDataLead.RecordColumnValues);
			MetaPathParameterValues.Add("77b402b4-36ef-4afe-85ca-fbbfe0540b9f", () => AddDataContactToOpportunity.EntitySchemaId);
			MetaPathParameterValues.Add("611d2131-f988-40c6-a266-7ac3720e4624", () => AddDataContactToOpportunity.DataSourceFilters);
			MetaPathParameterValues.Add("f87e7355-4618-4675-ac15-23509e6ffedd", () => AddDataContactToOpportunity.RecordAddMode);
			MetaPathParameterValues.Add("20e936ce-6092-493c-b50c-aaf70285c26b", () => AddDataContactToOpportunity.FilterEntitySchemaId);
			MetaPathParameterValues.Add("ccc51ea5-dba9-4d02-9514-ddb4ac2fa55c", () => AddDataContactToOpportunity.RecordDefValues);
			MetaPathParameterValues.Add("77fca69f-0da0-430c-a3da-c7ed23ab5394", () => AddDataContactToOpportunity.RecordId);
			MetaPathParameterValues.Add("36768833-e793-4cd5-8c7c-6fa9657737df", () => AddDataOpportunity.EntitySchemaId);
			MetaPathParameterValues.Add("1aa11035-b136-470f-8cb3-1f4060a6f342", () => AddDataOpportunity.DataSourceFilters);
			MetaPathParameterValues.Add("05d8eeec-d375-46f9-ae98-2ee983ccb91d", () => AddDataOpportunity.RecordAddMode);
			MetaPathParameterValues.Add("8513b4b5-7a5d-4bac-b336-7ffa764d5510", () => AddDataOpportunity.FilterEntitySchemaId);
			MetaPathParameterValues.Add("488491cb-2475-44b0-9985-39cc11395c42", () => AddDataOpportunity.RecordDefValues);
			MetaPathParameterValues.Add("d6c3ad89-7397-4dd6-a229-f52efab3d43b", () => AddDataOpportunity.RecordId);
			MetaPathParameterValues.Add("95d638cd-1142-40c7-b944-f9e7fdc8b952", () => ReadDataCountOpportunityByAccount.DataSourceFilters);
			MetaPathParameterValues.Add("baccf23b-370e-4e0b-b657-7bfa21cdd970", () => ReadDataCountOpportunityByAccount.ResultType);
			MetaPathParameterValues.Add("daf54a7f-8a62-4589-9c9c-c261921a13fd", () => ReadDataCountOpportunityByAccount.ReadSomeTopRecords);
			MetaPathParameterValues.Add("cf300c28-9b38-48ff-a8d5-ecb1fba12e64", () => ReadDataCountOpportunityByAccount.NumberOfRecords);
			MetaPathParameterValues.Add("fc3b5658-a8e6-4cab-b27b-819a3025ed71", () => ReadDataCountOpportunityByAccount.FunctionType);
			MetaPathParameterValues.Add("693953ab-8637-4183-87d1-ee4988a862f8", () => ReadDataCountOpportunityByAccount.AggregationColumnName);
			MetaPathParameterValues.Add("5e608114-da8f-4197-a7c1-9abde0e48dca", () => ReadDataCountOpportunityByAccount.OrderInfo);
			MetaPathParameterValues.Add("a81f55d7-8bc9-4327-b691-9ede33487823", () => ReadDataCountOpportunityByAccount.ResultEntity);
			MetaPathParameterValues.Add("a83ce913-3e58-4db8-b563-712f4f1f1d4f", () => ReadDataCountOpportunityByAccount.ResultCount);
			MetaPathParameterValues.Add("f23fe366-df2c-4531-b2ed-ebdf444d985e", () => ReadDataCountOpportunityByAccount.ResultIntegerFunction);
			MetaPathParameterValues.Add("236f9f63-489b-4485-b92a-f5a499fe453e", () => ReadDataCountOpportunityByAccount.ResultFloatFunction);
			MetaPathParameterValues.Add("5a384c94-4c0e-46d6-ab9c-2f2f6cf1de5a", () => ReadDataCountOpportunityByAccount.ResultDateTimeFunction);
			MetaPathParameterValues.Add("199f3817-15db-4ed6-b57f-350fc7b100b3", () => ReadDataCountOpportunityByAccount.ResultRowsCount);
			MetaPathParameterValues.Add("d3ab4b8a-b637-47a5-bc47-da539d6683f1", () => ReadDataCountOpportunityByAccount.CanReadUncommitedData);
			MetaPathParameterValues.Add("156fda51-7aad-4289-bdf5-909adb3f882f", () => ReadDataCountOpportunityByAccount.ResultEntityCollection);
			MetaPathParameterValues.Add("84c58779-0b9a-4c9a-92d9-5ba3900861f5", () => ReadDataCountOpportunityByAccount.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("d2b28272-8058-40a5-b869-30703026b4b7", () => ReadDataCountOpportunityByAccount.IgnoreDisplayValues);
			MetaPathParameterValues.Add("86bf89f7-55de-4505-b0fc-9974a9da0381", () => ReadDataCountOpportunityByAccount.ResultCompositeObjectList);
			MetaPathParameterValues.Add("92537119-d563-41e8-905c-09def63277af", () => ReadDataCountOpportunityByAccount.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("760c8144-4547-4f2e-9058-d28c8497d3e6", () => ReadDataAccount.DataSourceFilters);
			MetaPathParameterValues.Add("29d241ea-e7c1-468b-93dd-4fabc9692e05", () => ReadDataAccount.ResultType);
			MetaPathParameterValues.Add("99fe1d4f-11a3-4a99-a403-3f8329c46387", () => ReadDataAccount.ReadSomeTopRecords);
			MetaPathParameterValues.Add("23c9ab4d-c03e-4823-a89d-b8157e04f637", () => ReadDataAccount.NumberOfRecords);
			MetaPathParameterValues.Add("0481537e-1347-4a84-bc95-3f25b63bd2aa", () => ReadDataAccount.FunctionType);
			MetaPathParameterValues.Add("98fe3323-90ae-4f77-9698-90cb6049bb21", () => ReadDataAccount.AggregationColumnName);
			MetaPathParameterValues.Add("ab5fefa4-6698-4258-940b-0a2c6dd14a31", () => ReadDataAccount.OrderInfo);
			MetaPathParameterValues.Add("d3b28169-5be2-4f9c-97c0-eef28ed4f516", () => ReadDataAccount.ResultEntity);
			MetaPathParameterValues.Add("3bc1a643-8bc8-4d8c-96c9-19e0df86a151", () => ReadDataAccount.ResultCount);
			MetaPathParameterValues.Add("801aa1e5-b4cb-4d94-abad-0dfa07dffec6", () => ReadDataAccount.ResultIntegerFunction);
			MetaPathParameterValues.Add("f75452e6-8240-4d69-825e-90cd8847e099", () => ReadDataAccount.ResultFloatFunction);
			MetaPathParameterValues.Add("36ec811c-adc6-4e15-a536-d4bbcf966b71", () => ReadDataAccount.ResultDateTimeFunction);
			MetaPathParameterValues.Add("affd0b02-dbe8-4101-aeb3-b62e33160dd3", () => ReadDataAccount.ResultRowsCount);
			MetaPathParameterValues.Add("591a5668-a8e2-41dc-a509-888da5a63e1a", () => ReadDataAccount.CanReadUncommitedData);
			MetaPathParameterValues.Add("9cc3666e-b170-44af-a775-f6810f7e7250", () => ReadDataAccount.ResultEntityCollection);
			MetaPathParameterValues.Add("87a74108-882e-4315-a51f-706bae061c72", () => ReadDataAccount.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("e5436907-184b-4bae-b060-99c5407f2a22", () => ReadDataAccount.IgnoreDisplayValues);
			MetaPathParameterValues.Add("b8a1a3ac-537b-4e86-b7e6-dbbd319022a6", () => ReadDataAccount.ResultCompositeObjectList);
			MetaPathParameterValues.Add("1fad9e13-e56a-4fef-963e-9a2d69037ec1", () => ReadDataAccount.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("f3d16d53-5568-4d10-85f2-ecee93297c69", () => ReadDataContact.DataSourceFilters);
			MetaPathParameterValues.Add("6d0e3dc9-842e-46e7-8ec6-d71896474631", () => ReadDataContact.ResultType);
			MetaPathParameterValues.Add("01b2e31d-1d81-4b50-bc28-b8d8b4b60976", () => ReadDataContact.ReadSomeTopRecords);
			MetaPathParameterValues.Add("2fc79c56-2808-4e39-a3da-7b92d8218134", () => ReadDataContact.NumberOfRecords);
			MetaPathParameterValues.Add("4d312b88-dd01-43fa-a2cf-92d118789fc2", () => ReadDataContact.FunctionType);
			MetaPathParameterValues.Add("705dbcc7-95ff-47ba-a0de-e637092435f6", () => ReadDataContact.AggregationColumnName);
			MetaPathParameterValues.Add("0dfc2b7f-d9f0-4923-87e3-ce36e9fb5442", () => ReadDataContact.OrderInfo);
			MetaPathParameterValues.Add("daa09ed7-2a7d-4450-a30a-dd8ac16c0a06", () => ReadDataContact.ResultEntity);
			MetaPathParameterValues.Add("1c0aed0e-7343-442c-970e-e1e5c5a4ede4", () => ReadDataContact.ResultCount);
			MetaPathParameterValues.Add("957d85e9-6cea-4ba9-b671-6ff1d0faecee", () => ReadDataContact.ResultIntegerFunction);
			MetaPathParameterValues.Add("96aba7e1-c060-491b-a648-67b8fed13557", () => ReadDataContact.ResultFloatFunction);
			MetaPathParameterValues.Add("0afa84c8-ac3e-4b20-8ff2-a08e0f96f627", () => ReadDataContact.ResultDateTimeFunction);
			MetaPathParameterValues.Add("13f4af03-0d2b-4788-9a8d-f585fb5cfd13", () => ReadDataContact.ResultRowsCount);
			MetaPathParameterValues.Add("2c12c50b-6308-45df-becd-68952bb8177e", () => ReadDataContact.CanReadUncommitedData);
			MetaPathParameterValues.Add("adb4ba05-85d5-4736-a24e-94b25bcf8904", () => ReadDataContact.ResultEntityCollection);
			MetaPathParameterValues.Add("04d717aa-6962-480f-b56d-1be4aba03d1c", () => ReadDataContact.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("67a25d02-1e6e-46fc-bb0a-c9e2f19819ab", () => ReadDataContact.IgnoreDisplayValues);
			MetaPathParameterValues.Add("492f15c3-b34b-405e-8203-5e3baad4a84b", () => ReadDataContact.ResultCompositeObjectList);
			MetaPathParameterValues.Add("df1ebb1b-b68f-49a6-b9cd-88c2611a9fc6", () => ReadDataContact.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("a81724cd-f82e-401e-bdc4-1f4968318e58", () => PresentationTaskCreation.EntitySchemaId);
			MetaPathParameterValues.Add("dafab651-4b04-4a39-9ffa-a14a50789205", () => PresentationTaskCreation.DataSourceFilters);
			MetaPathParameterValues.Add("ff84282e-f6d0-4910-a414-28117fa48082", () => PresentationTaskCreation.RecordAddMode);
			MetaPathParameterValues.Add("5ad22c54-905a-451d-b9fd-76ff73069b58", () => PresentationTaskCreation.FilterEntitySchemaId);
			MetaPathParameterValues.Add("5cd8ef8c-6a8f-48a6-8cbb-13e448e5e606", () => PresentationTaskCreation.RecordDefValues);
			MetaPathParameterValues.Add("3b349266-cabe-4ac9-9bab-90e5a99b9312", () => PresentationTaskCreation.RecordId);
			MetaPathParameterValues.Add("e113eec9-67b0-4d53-8bd1-162890643787", () => ReadOppoortunityData2.DataSourceFilters);
			MetaPathParameterValues.Add("da79942f-8a30-4c0f-855d-60c2d9a24472", () => ReadOppoortunityData2.ResultType);
			MetaPathParameterValues.Add("314efddf-5361-477a-9ff8-a9cb5fab8b62", () => ReadOppoortunityData2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("06b753c1-0d8b-436b-8acc-ddf113106da6", () => ReadOppoortunityData2.NumberOfRecords);
			MetaPathParameterValues.Add("ad17e1dd-e357-4be2-be8e-37597e384cc1", () => ReadOppoortunityData2.FunctionType);
			MetaPathParameterValues.Add("9cb37f59-15e3-4146-8d7f-c8726fcb37d4", () => ReadOppoortunityData2.AggregationColumnName);
			MetaPathParameterValues.Add("6f41753d-91d4-4093-8fba-b44d89023e4c", () => ReadOppoortunityData2.OrderInfo);
			MetaPathParameterValues.Add("dfa2d329-fcfc-4412-bf5d-d4a9bda93dae", () => ReadOppoortunityData2.ResultEntity);
			MetaPathParameterValues.Add("820e9918-37b0-4611-aaf2-8d870ec7da7d", () => ReadOppoortunityData2.ResultCount);
			MetaPathParameterValues.Add("cb9c1fe1-8c58-4f12-89f1-7aae2156df27", () => ReadOppoortunityData2.ResultIntegerFunction);
			MetaPathParameterValues.Add("813a52d4-0e07-46b4-a63f-229d35aa56c6", () => ReadOppoortunityData2.ResultFloatFunction);
			MetaPathParameterValues.Add("a3dabfcb-04f6-4cea-92b9-d9ea7aee59b1", () => ReadOppoortunityData2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("fcd7d381-1523-402c-b1b8-ed682284f793", () => ReadOppoortunityData2.ResultRowsCount);
			MetaPathParameterValues.Add("e2a2ccd2-d26f-4f42-ae98-edf3516e1ea8", () => ReadOppoortunityData2.CanReadUncommitedData);
			MetaPathParameterValues.Add("b5926df2-7c95-4492-a867-2d430924a35b", () => ReadOppoortunityData2.ResultEntityCollection);
			MetaPathParameterValues.Add("701045a2-ff5b-4e90-ae4f-035211803404", () => ReadOppoortunityData2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("5402bebd-14b9-42b0-8196-579eb5bbe71e", () => ReadOppoortunityData2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("2d408867-c6e3-49e6-9b4f-4c5bcd0f5cb9", () => ReadOppoortunityData2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("1af5caff-1f48-4b94-b09b-14be7e354915", () => ReadOppoortunityData2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("6fbea50a-fcc9-45a8-9318-18aaea6960f4", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("054c4df5-87b5-404f-85c8-f5bb3e7c2694", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("85e3b80e-36f9-4932-88fd-521181901c0a", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("335d8956-0dcb-469d-90e9-ceef1f2c5ecf", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("d9f755be-cee7-464d-9e1b-b41958012cd7", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("ea0c6605-f519-48fc-a673-083c99411a6a", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("04c4106d-1c1b-4e36-adfa-2bde0c00cacb", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("ee89e1ce-8692-4233-94c8-45e2768973be", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("a73fd6bc-7349-44c8-9897-4cbf76d42e92", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("83effc4d-ad92-4d9f-8f5d-a8a8a9476b51", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("5877a9b3-2232-413f-bca4-841e0c74fcaf", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("e49f79ee-5843-4cf5-8054-c5513d2f9295", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("2bb22b1b-8777-4e67-bd6f-76818c3e0d4b", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("10b071ad-0944-459a-90cb-7bd9819ae222", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("35106250-8b54-4cad-8a40-45adb5f3cd75", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("c1ba2a29-f542-4078-94a5-6af41945ce12", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("9077d7fd-aab0-4d45-9d7d-e410dd871d90", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("6f483bcc-4e72-4895-8fb5-0758dffaddf9", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("c55ccbf1-80ac-4a05-a88e-1a3e7a779df4", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("07e87dc6-266d-4544-87cb-bfd58618dbfc", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("8e34ab8a-aae1-49fa-a036-0f0b0ae39983", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("b4c062c1-d149-4854-b95d-7d3101c49ba8", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("9b1e2c37-1ca0-4018-820c-534743d29771", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("3f57e619-c84a-40cd-a0f1-b5c0fad5c3c5", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("916d8dad-7673-427b-a065-b9d623107663", () => AddDataUserTask1.RecordId);
			MetaPathParameterValues.Add("06208806-e8cf-4d1b-b140-1bb619b9ed9d", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("c7f8a702-1219-42b2-bf9d-1f55c8264391", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("3792585d-cd7c-494c-b316-b160fa45ae28", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("faa46a7f-a96c-46cf-9a47-add578864b68", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("68383c19-2658-416e-958d-1489861993aa", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("80cefc71-5fc6-4296-b100-29c98156e0b1", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("35445f62-ccc0-4a74-94f0-9ec9ea65b343", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("6cba6276-dc6c-4940-803b-a32b756d2ebd", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("6d7147db-0aaa-41c5-8897-3ad2d88fd821", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("00aae8e4-4e62-4538-9bf7-d0b6178f7c93", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("e696780e-c260-4f1d-ac47-1890fdb6b840", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("da459109-1578-45d4-9510-627e44859262", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("05f93e88-b9f0-488c-b37f-c86bd5b8d920", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("1ddf79d1-87fa-413b-b322-71e34392312d", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("2f6fab91-5a02-44f1-9ea1-7012b00b2849", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("d5f43f08-08d2-4c1d-aae8-d8cddf1e99e0", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("b65917ae-2434-428b-b40e-92d5141b5034", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("3c28f35a-ad91-46a3-b3de-3cad5ffcf70b", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("89c2533d-f152-4c4a-8358-baa80bdaa10b", () => ReadDataUserTask2.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CurrentOpportunity":
					if (!hasValueToRead) break;
					CurrentOpportunity = reader.GetValue<System.Guid>();
				break;
				case "Presentation":
					if (!hasValueToRead) break;
					Presentation = reader.GetValue<System.Guid>();
				break;
				case "MainContact":
					if (!hasValueToRead) break;
					MainContact = reader.GetValue<System.Guid>();
				break;
				case "Account":
					if (!hasValueToRead) break;
					Account = reader.GetValue<System.Guid>();
				break;
				case "IsStageChangedByUser":
					if (!hasValueToRead) break;
					IsStageChangedByUser = reader.GetValue<System.Boolean>();
				break;
				case "ClientOpportunityCount":
					if (!hasValueToRead) break;
					ClientOpportunityCount = reader.GetValue<System.Int32>();
				break;
				case "OpportunityTitle":
					if (!hasValueToRead) break;
					OpportunityTitle = reader.GetValue<System.String>();
				break;
				case "Contact":
					if (!hasValueToRead) break;
					Contact = reader.GetValue<System.Guid>();
				break;
				case "ClientName":
					if (!hasValueToRead) break;
					ClientName = reader.GetValue<System.String>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool SavePresentationParameter2Execute(ProcessExecutingContext context) {
			var localPresentation = ((FindPresentation.ResultEntity.IsColumnValueLoaded(FindPresentation.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? FindPresentation.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty));
			Presentation = (System.Guid)localPresentation;
			return true;
		}

		public virtual bool SaveMainContactParameterExecute(ProcessExecutingContext context) {
			var localMainContact = (Guid.Empty == ((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty))) ? ((ReadOppMainContact.ResultEntity.IsColumnValueLoaded(ReadOppMainContact.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? ReadOppMainContact.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)) : ((ReadOppData.ResultEntity.IsColumnValueLoaded(ReadOppData.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? ReadOppData.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty));
			MainContact = (System.Guid)localMainContact;
			return true;
		}

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localCurrentOpportunity = (OpenEditPageUserTask1.RecordId);
			CurrentOpportunity = (System.Guid)localCurrentOpportunity;
			return true;
		}

		public virtual bool FormulaTask2Execute(ProcessExecutingContext context) {
			var localPresentation = Guid.Empty;
			Presentation = (System.Guid)localPresentation;
			return true;
		}

		public virtual bool StoreIsStageChangedByUserExecute(ProcessExecutingContext context) {
			var localIsStageChangedByUser = (Prospecting.OpportunityStageChanged) || (NeedsAnalysis.OpportunityStageChanged)|| (OppManagementValuePproposition.OpportunityStageChanged) || (IdDecisionMakers.OpportunityStageChanged) || (OppManagementPerceptionAnalysis.OpportunityStageChanged) || (OppManagementProposal.OpportunityStageChanged) || (OppManagementNegotiations.OpportunityStageChanged) || (OppManagementContractation.OpportunityStageChanged);
			IsStageChangedByUser = (System.Boolean)localIsStageChangedByUser;
			return true;
		}

		public virtual bool ResetIsStageChangedByUserExecute(ProcessExecutingContext context) {
			var localIsStageChangedByUser = false;
			IsStageChangedByUser = (System.Boolean)localIsStageChangedByUser;
			return true;
		}

		public virtual bool FormulaTaskAccountByLeadExecute(ProcessExecutingContext context) {
			var localAccount = ((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty));
			Account = (System.Guid)localAccount;
			return true;
		}

		public virtual bool SaveCurrOppParameterExecute(ProcessExecutingContext context) {
			var localCurrentOpportunity = (AddDataOpportunity.RecordId);
			CurrentOpportunity = (System.Guid)localCurrentOpportunity;
			return true;
		}

		public virtual bool SavePresentationParameterExecute(ProcessExecutingContext context) {
			var localPresentation = (PresentationTaskCreation.RecordId);
			Presentation = (System.Guid)localPresentation;
			return true;
		}

		public virtual bool FormulaTask3Execute(ProcessExecutingContext context) {
			var localClientOpportunityCount = (ReadDataUserTask2.ResultCount);
			ClientOpportunityCount = (System.Int32)localClientOpportunityCount;
			return true;
		}

		public virtual bool FormulaTask4Execute(ProcessExecutingContext context) {
			var localClientOpportunityCount = (ReadDataCountOpportunityByAccount.ResultCount);
			ClientOpportunityCount = (System.Int32)localClientOpportunityCount;
			return true;
		}

		public virtual bool FormulaTask5Execute(ProcessExecutingContext context) {
			var localOpportunityTitle = ((ReadDataAccount.ResultEntity.IsColumnValueLoaded(ReadDataAccount.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? ReadDataAccount.ResultEntity.GetTypedColumnValue<string>("Name") : null));
			OpportunityTitle = (System.String)localOpportunityTitle;
			return true;
		}

		public virtual bool FormulaTask6Execute(ProcessExecutingContext context) {
			var localOpportunityTitle = ((ReadDataContact.ResultEntity.IsColumnValueLoaded(ReadDataContact.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? ReadDataContact.ResultEntity.GetTypedColumnValue<string>("Name") : null));
			OpportunityTitle = (System.String)localOpportunityTitle;
			return true;
		}

		public virtual bool FormulaTask7Execute(ProcessExecutingContext context) {
			var localContact = ((ReadDataLead.ResultEntity.IsColumnValueLoaded(ReadDataLead.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? ReadDataLead.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty));
			Contact = (System.Guid)localContact;
			return true;
		}

		public virtual bool FormulaTask8Execute(ProcessExecutingContext context) {
			var localClientName = ((ReadDataContact.ResultEntity.IsColumnValueLoaded(ReadDataContact.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? ReadDataContact.ResultEntity.GetTypedColumnValue<string>("Name") : null));
			ClientName = (System.String)localClientName;
			return true;
		}

		public virtual bool FormulaTask9Execute(ProcessExecutingContext context) {
			var localClientName = ((ReadDataAccount.ResultEntity.IsColumnValueLoaded(ReadDataAccount.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? ReadDataAccount.ResultEntity.GetTypedColumnValue<string>("Name") : null));
			ClientName = (System.String)localClientName;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			if (Status == Core.Process.ProcessStatus.Inactive) {
				return;
			}
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer, writeFlowElements);
			WritePropertyValues(writer, false);
			writer.WriteFinishObject();
		}

		public override object CloneShallow() {
			var cloneItem = (OpportunityManagement)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

