namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration.MandrillService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: UpdateEmailAnaliticsProcessSchema

	/// <exclude/>
	public class UpdateEmailAnaliticsProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public UpdateEmailAnaliticsProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public UpdateEmailAnaliticsProcessSchema(UpdateEmailAnaliticsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "UpdateEmailAnaliticsProcess";
			UId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41");
			CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.6.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = false;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,87,91,79,227,56,20,126,46,18,255,193,202,147,171,173,34,237,236,195,74,12,29,9,74,161,213,66,65,20,118,30,16,90,185,137,219,122,73,237,140,237,0,157,21,255,125,143,47,73,147,52,101,67,181,179,43,36,146,218,231,242,249,59,23,159,28,30,164,217,44,97,17,122,102,82,103,36,65,207,130,197,232,138,48,142,187,232,175,195,131,206,165,88,140,249,92,224,224,193,44,62,30,161,169,38,82,211,56,12,186,159,97,251,36,50,90,236,59,157,8,238,222,7,130,107,18,233,225,138,176,68,225,170,208,153,152,8,125,175,168,221,60,23,210,203,122,177,251,52,38,154,158,102,201,147,221,7,71,154,41,205,162,198,221,147,56,102,154,9,78,234,114,91,128,207,25,103,106,153,35,126,59,60,48,127,77,167,222,237,223,50,161,229,218,62,59,55,82,68,84,169,105,180,164,43,130,148,123,244,145,217,234,192,225,204,169,56,141,12,184,176,34,122,69,56,89,80,25,94,80,61,230,74,19,30,209,211,245,132,172,40,14,118,185,246,250,142,235,220,49,74,253,179,239,157,135,3,73,65,221,111,227,42,6,167,234,85,194,225,43,141,50,77,155,100,222,80,68,116,180,68,120,248,26,209,212,44,35,218,181,7,6,74,135,82,10,9,156,238,2,250,24,244,64,218,154,249,8,199,141,81,172,178,205,184,70,75,145,1,218,12,222,250,8,216,27,193,207,100,61,88,66,34,142,242,29,23,252,206,120,200,179,21,149,100,150,208,99,208,252,130,102,185,171,219,113,172,156,250,87,150,36,53,28,102,211,91,152,11,32,51,90,98,227,183,172,140,24,175,26,115,56,59,62,49,71,235,148,202,132,241,39,53,128,67,195,127,11,170,172,224,204,123,113,39,116,157,82,174,236,57,206,136,38,21,233,222,230,208,21,197,2,242,61,103,223,50,186,161,109,219,213,219,158,65,109,8,74,219,240,182,168,244,106,116,161,38,98,105,226,161,89,2,78,105,145,161,83,13,113,136,109,74,199,153,172,39,108,15,5,90,165,127,52,187,11,218,167,243,63,226,109,123,240,194,166,210,146,241,5,90,65,177,65,177,247,80,217,187,61,242,51,145,40,17,11,104,4,46,27,47,237,187,75,62,183,30,58,75,122,201,84,104,218,3,250,9,5,71,232,33,128,231,20,204,130,173,223,232,218,44,62,34,179,230,93,153,133,207,57,218,247,145,218,254,88,5,218,26,155,213,221,11,218,110,92,139,68,204,72,114,116,52,16,171,21,52,77,227,21,160,133,99,120,41,163,216,134,120,121,125,113,49,188,69,68,189,103,194,128,103,115,132,115,173,62,226,89,146,248,234,45,76,237,48,0,207,82,219,246,72,138,227,187,58,243,40,250,30,151,79,22,235,211,145,28,142,213,4,92,94,203,225,42,213,107,188,97,170,235,81,148,184,3,222,51,22,135,19,250,98,158,184,27,222,137,169,53,130,131,73,144,39,98,71,82,157,73,190,113,216,166,36,119,221,208,255,102,65,186,78,210,236,105,159,178,108,182,212,162,40,183,238,129,247,250,126,145,88,138,38,112,28,136,1,167,47,144,208,230,71,253,166,52,72,195,129,72,178,21,199,1,168,7,110,229,92,138,21,14,10,187,126,245,235,146,2,83,129,105,163,153,50,178,80,62,216,41,135,55,68,66,6,105,42,21,54,222,196,236,79,240,240,240,232,47,149,187,41,248,156,179,69,38,137,29,36,174,136,124,162,26,210,0,150,149,86,97,229,6,206,84,62,227,192,189,177,143,58,196,54,77,247,214,134,8,177,103,58,142,237,157,211,237,134,39,220,228,237,240,21,110,14,133,173,193,247,233,220,16,90,167,6,219,74,205,133,28,199,121,130,222,210,136,165,140,114,29,228,251,158,237,114,112,13,227,106,248,13,50,162,20,172,174,105,24,14,142,201,161,17,228,135,26,209,4,238,239,112,154,130,213,249,122,34,46,69,244,100,55,176,203,137,30,210,50,115,57,231,115,69,82,149,37,121,174,92,194,89,109,158,225,92,36,83,166,187,226,179,83,87,62,66,162,120,86,188,246,81,109,78,28,114,5,53,117,118,186,89,194,121,111,240,134,198,102,66,184,165,36,166,198,181,125,244,125,190,230,21,234,118,241,198,79,110,194,206,80,114,28,59,122,199,60,166,175,160,236,172,152,182,118,45,99,198,11,138,220,180,241,178,100,9,69,216,11,25,211,5,34,103,175,50,27,149,173,141,185,254,229,19,174,186,243,70,59,142,180,16,38,140,166,209,232,173,152,90,28,135,190,203,57,165,54,179,123,243,16,86,71,251,3,58,94,163,227,160,87,36,63,116,246,223,73,146,209,27,194,228,177,187,20,122,190,228,191,224,160,12,14,90,91,5,235,71,71,243,70,36,31,155,206,27,103,211,58,137,61,84,25,204,127,0,167,77,48,90,83,122,250,14,165,109,109,152,111,139,60,146,165,147,126,52,34,77,231,104,17,16,67,239,206,111,29,203,114,100,186,177,149,139,233,156,64,137,140,74,159,73,191,126,178,115,79,237,227,201,132,177,123,71,165,36,74,204,53,180,93,73,195,106,175,159,174,213,148,106,211,236,149,41,102,75,143,109,226,91,145,42,40,118,16,55,223,172,84,50,225,251,136,153,129,54,254,143,209,207,190,133,148,49,213,193,215,102,156,101,105,189,253,135,101,253,235,232,63,232,1,187,124,255,47,109,96,23,152,237,196,251,27,2,220,142,83,2,18,0,0 };
			RealUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41");
			Version = 0;
			PackageUId = new Guid("789c617e-760f-4576-a608-ee12728eae0a");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateLOGGERParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("231071ea-6643-4898-b33f-fe82c1526d35"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Name = @"LOGGER",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSessionKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("30944bf2-810c-4ad1-9ce6-01558b20047e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Name = @"SessionKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLOGGERParameter());
			Parameters.Add(CreateSessionKeyParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaScriptTask mainscripttask = CreateMainScriptTaskScriptTask();
			FlowElements.Add(mainscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("1418531f-a63d-4ad5-9116-b42ff97174f6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1fae9bb1-7179-4e6f-bc70-4fbd630d6a16"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b948883d-49cc-436b-9a6c-e02d5971d5ee"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("ce8c5fda-5c2a-4680-8509-b7549bfb29c1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b948883d-49cc-436b-9a6c-e02d5971d5ee"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("89d38304-7be6-4b99-9a47-f637b0ef69c4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4d4df1b5-735b-4be3-8f99-3bc85abc2611"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("1b46e01f-8c20-4efe-ab42-bc6bc456295d"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("4d4df1b5-735b-4be3-8f99-3bc85abc2611"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("1fae9bb1-7179-4e6f-bc70-4fbd630d6a16"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b46e01f-8c20-4efe-ab42-bc6bc456295d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("89d38304-7be6-4b99-9a47-f637b0ef69c4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b46e01f-8c20-4efe-ab42-bc6bc456295d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMainScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b948883d-49cc-436b-9a6c-e02d5971d5ee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b46e01f-8c20-4efe-ab42-bc6bc456295d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Name = @"MainScriptTask",
				Position = new Point(274, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,204,204,211,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,176,217,148,41,21,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3c147ea6-a9b7-4999-ba05-f1062ef362f0"),
				Name = "Terrasoft.Configuration.MandrillService",
				Alias = "",
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e8084a72-4766-41d9-877f-c004b422c728"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("99c65a0f-7413-4117-a3f0-a052941ee8eb"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new UpdateEmailAnaliticsProcess(userConnection);
		}

		public override object Clone() {
			return new UpdateEmailAnaliticsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"));
		}

		#endregion

	}

	#endregion

	#region Class: UpdateEmailAnaliticsProcess

	/// <exclude/>
	public class UpdateEmailAnaliticsProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, UpdateEmailAnaliticsProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public UpdateEmailAnaliticsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UpdateEmailAnaliticsProcess";
			SchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1dd85556-3227-499f-af34-bab27dfa7f41");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: UpdateEmailAnaliticsProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: UpdateEmailAnaliticsProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		private Func<string> _notificationCaption;
		public virtual string NotificationCaption {
			get {
				return (_notificationCaption ?? (_notificationCaption = () => null)).Invoke();
			}
			set {
				_notificationCaption = () => { return value; };
			}
		}

		public virtual Object LOGGER {
			get;
			set;
		}

		public virtual string SessionKey {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _start1;
		public ProcessFlowElement Start1 {
			get {
				return _start1 ?? (_start1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start1",
					SchemaElementUId = new Guid("1fae9bb1-7179-4e6f-bc70-4fbd630d6a16"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("89d38304-7be6-4b99-9a47-f637b0ef69c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _mainScriptTask;
		public ProcessScriptTask MainScriptTask {
			get {
				return _mainScriptTask ?? (_mainScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MainScriptTask",
					SchemaElementUId = new Guid("b948883d-49cc-436b-9a6c-e02d5971d5ee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = MainScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[MainScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MainScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("MainScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "MainScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (LOGGER != null) {
				if (LOGGER.GetType().IsSerializable ||
					LOGGER.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("LOGGER", LOGGER, null);
				}
			}
			if (!HasMapping("SessionKey")) {
				writer.WriteValue("SessionKey", SessionKey, null);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start1", string.Empty));
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
			MetaPathParameterValues.Add("231071ea-6643-4898-b33f-fe82c1526d35", () => LOGGER);
			MetaPathParameterValues.Add("30944bf2-810c-4ad1-9ce6-01558b20047e", () => SessionKey);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "LOGGER":
					if (!hasValueToRead) break;
					LOGGER = reader.GetSerializableObjectValue();
				break;
				case "SessionKey":
					if (!hasValueToRead) break;
					SessionKey = reader.GetValue<System.String>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool MainScriptTaskExecute(ProcessExecutingContext context) {
			Main();
			return true;
		}

			
			public virtual void Main() {
				LogInfo("[Main]: Started.");
				ActualizeNonActualContactEmails();
				ActualizeDoNotUseEmailForContacts();
				UpdateBulkEmailStatistic();
				UpdateBulkEmailAdditionalStatistic();
				LogInfo("[Main]: Finished.");
			}
			
			
			public virtual void UpdateBulkEmailStatistic() {
				try {
					ProcessSchema schema = 
						UserConnection.ProcessSchemaManager.GetInstanceByName("UpdateBulkEmailStatisticProcess");
					Process process = schema.CreateProcess(UserConnection);
					process.Execute(UserConnection);
				} catch (Exception e){
					LogError("[UpdateBulkEmailStatistic]", e);
				}
			}
			
			
			public virtual void UpdateBulkEmailAdditionalStatistic() {
				try {
					int hourCount = GetHourlyChartHourCount();
					IEnumerable<int> bulkEmailRIds = GetWillUpdateBulkEmailRIds();
					foreach(int bulkEmailRId in bulkEmailRIds) {
						UpdateHyperlinksClicksCount(bulkEmailRId);
						UpdateClicksOpensChartData(bulkEmailRId, hourCount);
						UpdateBulkEmailUniqueStatistic(bulkEmailRId);
					}
				} catch (Exception e){
					LogError("[UpdateBulkEmailAdditionalStatistic]", e);
				}
			}
			
			
			public virtual void ActualizeDoNotUseEmailForContacts() {
				try {
					MandrillUtilities.ExecuteStoredProcedure(UserConnection, "tsp_ActualizeDoNotUseEmail");
				} catch (Exception e){
					LogError("[ActualizeDoNotUseEmailForContacts]", e);
				}
			}
			
			
			public virtual void LogError(string message, Exception e) {
				var logger = GetLogger();
				logger.Error(this.Name + ": [" + SessionKey + "] " + message + ";", e);
			}
			
			
			public virtual void LogInfo(string message) {
				var logger = GetLogger();
				logger.Info(this.Name + ": [" + SessionKey + "] " + message + ";");
			}
			
			
			public virtual global::Common.Logging.ILog GetLogger() {
				var logger = LOGGER as global::Common.Logging.ILog;
				if (logger == null) {
					logger = global::Common.Logging.LogManager.GetLogger(this.Name);
					LOGGER = logger;
				}
				if (string.IsNullOrEmpty(SessionKey)) {
					SessionKey = Guid.NewGuid().ToString("N");
				}
				return logger;
			}
			
			
			public virtual void ActualizeNonActualContactEmails() {
				try {
					MandrillUtilities.ExecuteStoredProcedure(UserConnection, "tsp_UpdateNonActualContactEmails");
				} catch (Exception e){
					LogError("[ActualizeNonActualContactEmails]", e);
				}
			}
			
			
			public virtual IEnumerable<int> GetWillUpdateBulkEmailRIds() {
				var select = new Select(UserConnection)
					.Column("RId")
					.From("BulkEmail")
					.Where("StatusId").In(Column.Parameters(new object[] {
						TSConfiguration.MarketingConsts.BulkEmailStatusFinishedId,
						TSConfiguration.MarketingConsts.BulkEmailStatusStoppedId,
						TSConfiguration.MarketingConsts.BulkEmailStatusActiveId
					})).And().Exists(
						new Select(UserConnection)
							.Column(Column.Parameter(null))
							.From("MandrillRecipient")
							.Where("BulkEmailRId").IsEqual("RId")
					) as Select;
				HintsHelper.SpecifyNoLockHints(select, true);
				
				var result = new List<int>();
				
				using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
					using (IDataReader reader = select.ExecuteReader(dbExecutor)) {
						int rIdColumnIndex = reader.GetOrdinal("RId");
						while (reader.Read()) {
							int bulkEmailRId = reader.GetInt32(rIdColumnIndex);
							result.Add(bulkEmailRId);
						}
					}
				}
				
				return result;
			}
			
			
			public virtual void UpdateHyperlinksClicksCount(int bulkEmailRId) {
				try {
					MandrillUtilities.ExecuteStoredProcedure(UserConnection, "tsp_UpdateHyperlinksClicksCount",
						new KeyValuePair<string, object>("bulkEmailRId", bulkEmailRId));
				} catch (Exception e){
					LogError("[UpdateHyperlinksClicksCount]", e);
				}
			}
			
			
			public virtual void UpdateClicksOpensChartData(int bulkEmailRId, int hourCount) {
				try {
					MandrillUtilities.ExecuteStoredProcedure(UserConnection, "tsp_UpdateClicksOpensChartData",
						new KeyValuePair<string, object>("BulkEmailRId", bulkEmailRId),
						new KeyValuePair<string, object>("HoursCount", hourCount));
				} catch (Exception e){
					LogError("[UpdateClicksOpensChartData]", e);
				}
			}
			
			
			public virtual int GetHourlyChartHourCount() {
				const int defaultHourCount = 72;
				int hourCount = (int)Terrasoft.Core.Configuration.SysSettings.GetValue(
					UserConnection, "BulkEmailHourlyStatisticPeriod");
				if (hourCount < 1) {
					hourCount = defaultHourCount;
				}
				return hourCount;
			}
			
			
			public virtual void UpdateBulkEmailUniqueStatistic(int bulkEmailRId) {
				try {
					MandrillUtilities.ExecuteStoredProcedure(UserConnection, "tsp_UpdateBulkEmailUniqueStatistic",
						new KeyValuePair<string, object>("bulkEmailRId", bulkEmailRId));
				} catch (Exception e){
					LogError("[UpdateBulkEmailUniqueStatistic]", e);
				}
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
			var cloneItem = (UpdateEmailAnaliticsProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.LOGGER = LOGGER;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

