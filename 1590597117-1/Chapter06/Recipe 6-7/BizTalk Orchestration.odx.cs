
#pragma warning disable 162

namespace SQL_Adapter_Stored_Procedure
{

    [System.SerializableAttribute]
    sealed public class __SQL_Adapter_Stored_Procedure_SQLService_Customer_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static SQL_Adapter_Stored_Procedure.SQLService.Customer_Request _schema = new SQL_Adapter_Stored_Procedure.SQLService.Customer_Request();

        public __SQL_Adapter_Stored_Procedure_SQLService_Customer_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(SQL_Adapter_Stored_Procedure.SQLService.Customer_Request)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__SQL_Adapter_Stored_Procedure_SQLService_Customer_Request__)
        },
        0,
        @"http://SQLAdapterStoredProcedure#Customer_Request"
    )]
    [System.SerializableAttribute]
    sealed internal class procedureRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __SQL_Adapter_Stored_Procedure_SQLService_Customer_Request__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __SQL_Adapter_Stored_Procedure_SQLService_Customer_Request__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public procedureRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __SQL_Adapter_Stored_Procedure_SQLService_Customer_Response__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static SQL_Adapter_Stored_Procedure.SQLService.Customer_Response _schema = new SQL_Adapter_Stored_Procedure.SQLService.Customer_Response();

        public __SQL_Adapter_Stored_Procedure_SQLService_Customer_Response__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(SQL_Adapter_Stored_Procedure.SQLService.Customer_Response)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__SQL_Adapter_Stored_Procedure_SQLService_Customer_Response__)
        },
        0,
        @"http://SQLAdapterStoredProcedure#Customer_Response"
    )]
    [System.SerializableAttribute]
    sealed internal class procedureResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __SQL_Adapter_Stored_Procedure_SQLService_Customer_Response__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __SQL_Adapter_Stored_Procedure_SQLService_Customer_Response__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public procedureResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "procedure",
        new System.Type[]{
            typeof(SQL_Adapter_Stored_Procedure.procedureRequest), 
            typeof(SQL_Adapter_Stored_Procedure.procedureResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SQLServiceExec : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SQLServiceExec(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SQLServiceExec(SQLServiceExec p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SQLServiceExec p = new SQLServiceExec(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo procedure = new Microsoft.XLANGs.Core.OperationInfo
        (
            "procedure",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(SQLServiceExec),
            typeof(procedureRequest),
            typeof(procedureResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "procedure" ] = procedure;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __SQL_Adapter_Stored_Procedure_schCustomer__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static SQL_Adapter_Stored_Procedure.schCustomer _schema = new SQL_Adapter_Stored_Procedure.schCustomer();

        public __SQL_Adapter_Stored_Procedure_schCustomer__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "SQL_Adapter_Stored_Procedure.schCustomer",
        new System.Type[]{
            typeof(SQL_Adapter_Stored_Procedure.schCustomer)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__SQL_Adapter_Stored_Procedure_schCustomer__)
        },
        0,
        @"http://SQLAdapterStoredProcedure.schCustomer#Customer"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_SQL_Adapter_Stored_Procedure_schCustomer : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __SQL_Adapter_Stored_Procedure_schCustomer__ part;

        private void __CreatePartWrappers()
        {
            part = new __SQL_Adapter_Stored_Procedure_schCustomer__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_SQL_Adapter_Stored_Procedure_schCustomer(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "SQL_Adapter_Stored_Procedure.SQLService.Customer_Request",
        new System.Type[]{
            typeof(SQL_Adapter_Stored_Procedure.SQLService.Customer_Request)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__SQL_Adapter_Stored_Procedure_SQLService_Customer_Request__)
        },
        0,
        @"http://SQLAdapterStoredProcedure#Customer_Request"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_SQL_Adapter_Stored_Procedure_SQLService_Customer_Request : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __SQL_Adapter_Stored_Procedure_SQLService_Customer_Request__ part;

        private void __CreatePartWrappers()
        {
            part = new __SQL_Adapter_Stored_Procedure_SQLService_Customer_Request__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_SQL_Adapter_Stored_Procedure_SQLService_Customer_Request(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(SQL_Adapter_Stored_Procedure.__messagetype_SQL_Adapter_Stored_Procedure_schCustomer)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class oprtReceiveCustomerType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public oprtReceiveCustomerType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public oprtReceiveCustomerType(oprtReceiveCustomerType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            oprtReceiveCustomerType p = new oprtReceiveCustomerType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(oprtReceiveCustomerType),
            typeof(__messagetype_SQL_Adapter_Stored_Procedure_schCustomer),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(SQL_Adapter_Stored_Procedure.__messagetype_SQL_Adapter_Stored_Procedure_SQLService_Customer_Request)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class oprtSendCustomerSQLType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public oprtSendCustomerSQLType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public oprtSendCustomerSQLType(oprtSendCustomerSQLType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            oprtSendCustomerSQLType p = new oprtSendCustomerSQLType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(oprtSendCustomerSQLType),
            typeof(__messagetype_SQL_Adapter_Stored_Procedure_SQLService_Customer_Request),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 246 "C:\Documents and Settings\Administrator\Desktop\BizTalk Book Solutions\SQL Adapter Stored Procedure\BizTalk Orchestration.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "oprtReceiveCustomer", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(SQL_Adapter_Stored_Procedure.oprtReceiveCustomerType),
            typeof(SQL_Adapter_Stored_Procedure.oprtSendCustomerSQLType)
        },
        new System.String[] {
            "oprtReceiveCustomer",
            "oprtSendCustomerSQL"
        },
        new System.Type[] {
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class Orchestration_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Orchestration_1));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static Orchestration_1()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __Orchestration_1_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Orchestration_1(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Orchestration_1", tracker)
        {
            ConstructorHelper();
        }

        public Orchestration_1(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Orchestration_1")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>22c71c82-6781-4ae8-beed-d68d1b444d59</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>46ce5b2f-455d-4970-a555-39f5b7760d2e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>51b293b4-da47-4d44-be7b-0cf272e5b8b2</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_Customer_Request</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>42562142-77f2-4acd-bd3d-8a11c188d9f9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_CustomerInToCustomerResponse</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>9f8ab213-3457-4d8e-9343-eafcf1667680</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>f872febe-1cd0-47ff-af0a-62051d48c1c4</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>b1a4c6bb-6cde-426c-9b36-5ba448216e04</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>22cac543-e597-4204-9c24-cb14ffe95fe8</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow>
<Metadata>

<TrkMetadata>
<ActionName>'Orchestration_1'</ActionName><IsAtomic>0</IsAtomic><Line>246</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>257</Line><Position>22</Position><ShapeID>'46ce5b2f-455d-4970-a555-39f5b7760d2e'</ShapeID>
<Messages>
	<MsgInfo><name>msgCustomerIn</name><part>part</part><schema>SQL_Adapter_Stored_Procedure.schCustomer</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>259</Line><Position>13</Position><ShapeID>'51b293b4-da47-4d44-be7b-0cf272e5b8b2'</ShapeID>
<Messages>
	<MsgInfo><name>msgCustomerOut</name><part>part</part><schema>SQL_Adapter_Stored_Procedure.SQLService+Customer_Request</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgCustomerIn</name><part>part</part><schema>SQL_Adapter_Stored_Procedure.schCustomer</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>265</Line><Position>13</Position><ShapeID>'22cac543-e597-4204-9c24-cb14ffe95fe8'</ShapeID>
<Messages>
	<MsgInfo><name>msgCustomerOut</name><part>part</part><schema>SQL_Adapter_Stored_Procedure.SQLService+Customer_Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='46326069-2545-49dc-84c4-e283350f6123' LowerBound='1.1' HigherBound='57.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='SQL_Adapter_Stored_Procedure' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='e378f506-da3e-46b7-9f1d-008cc47553c7' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata port type: ' />
            <om:Property Name='Name' Value='SQLServiceExec' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='2b1d42f6-d588-49e9-b8bf-0d2fcab35fc4' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata operation: ' />
                <om:Property Name='Name' Value='procedure' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='71412b9c-0553-4b57-ae9f-67134efc0c33' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.29'>
                    <om:Property Name='Ref' Value='SQL_Adapter_Stored_Procedure.procedureRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='f1729eb6-4557-4b2c-b50f-a0ceeaa15de2' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='16.31' HigherBound='16.48'>
                    <om:Property Name='Ref' Value='SQL_Adapter_Stored_Procedure.procedureResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='c8b90368-9ca7-4b4a-9783-2c87bf8f99a9' ParentLink='Module_PortType' LowerBound='19.1' HigherBound='26.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='oprtReceiveCustomerType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='2d7f8600-df5b-439e-a1b0-a4230102cbce' ParentLink='PortType_OperationDeclaration' LowerBound='21.1' HigherBound='25.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='af157c57-f6cd-4ecc-bccb-34ed614d652e' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='23.13' HigherBound='23.24'>
                    <om:Property Name='Ref' Value='SQL_Adapter_Stored_Procedure.schCustomer' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='083ef490-6e46-4e83-926b-e22e6e8b63f4' ParentLink='Module_PortType' LowerBound='26.1' HigherBound='33.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='oprtSendCustomerSQLType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='030a4065-24d5-40da-ad93-7880a259e7e7' ParentLink='PortType_OperationDeclaration' LowerBound='28.1' HigherBound='32.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='a68e03fa-e5a7-4320-abb2-98be5bb0fa37' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='30.13' HigherBound='30.40'>
                    <om:Property Name='Ref' Value='SQL_Adapter_Stored_Procedure.SQLService.Customer_Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='1baf6d3f-c741-41ae-940d-628f3f363a11' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='procedureRequest' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='a2ff5e79-c61c-41ad-8a55-07b3589e2984' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='SQL_Adapter_Stored_Procedure.SQLService.Customer_Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='e98ee0d0-7e55-47db-9ba8-1ec2c1cbf019' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='procedureResponse' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='ddc4cdfa-0087-460e-8df0-68e6851daa5c' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='SQL_Adapter_Stored_Procedure.SQLService.Customer_Response' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='f6a8bdd3-49c4-49e4-bd24-012e032fde60' ParentLink='Module_ServiceDeclaration' LowerBound='33.1' HigherBound='56.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Orchestration_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='22c71c82-6781-4ae8-beed-d68d1b444d59' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='46ce5b2f-455d-4970-a555-39f5b7760d2e' ParentLink='ServiceBody_Statement' LowerBound='44.1' HigherBound='46.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='oprtReceiveCustomer' />
                    <om:Property Name='MessageName' Value='msgCustomerIn' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='51b293b4-da47-4d44-be7b-0cf272e5b8b2' ParentLink='ServiceBody_Statement' LowerBound='46.1' HigherBound='52.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_Customer_Request' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='42562142-77f2-4acd-bd3d-8a11c188d9f9' ParentLink='ComplexStatement_Statement' LowerBound='49.1' HigherBound='51.1'>
                        <om:Property Name='ClassName' Value='SQL_Adapter_Stored_Procedure.MapCustomerInToSQLService' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_CustomerInToCustomerResponse' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='9f8ab213-3457-4d8e-9343-eafcf1667680' ParentLink='Transform_InputMessagePartRef' LowerBound='50.102' HigherBound='50.115'>
                            <om:Property Name='MessageRef' Value='msgCustomerIn' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='f872febe-1cd0-47ff-af0a-62051d48c1c4' ParentLink='Transform_OutputMessagePartRef' LowerBound='50.28' HigherBound='50.42'>
                            <om:Property Name='MessageRef' Value='msgCustomerOut' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='b1a4c6bb-6cde-426c-9b36-5ba448216e04' ParentLink='Construct_MessageRef' LowerBound='47.23' HigherBound='47.37'>
                        <om:Property Name='Ref' Value='msgCustomerOut' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='22cac543-e597-4204-9c24-cb14ffe95fe8' ParentLink='ServiceBody_Statement' LowerBound='52.1' HigherBound='54.1'>
                    <om:Property Name='PortName' Value='oprtSendCustomerSQL' />
                    <om:Property Name='MessageName' Value='msgCustomerOut' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='a118c0d4-73e6-452f-a761-bd8d3b6dfa5f' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='36.1' HigherBound='38.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='SQL_Adapter_Stored_Procedure.oprtReceiveCustomerType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='oprtReceiveCustomer' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='433c05a0-5f1b-4e51-8c81-103aea9b5ad4' ParentLink='PortDeclaration_CLRAttribute' LowerBound='36.1' HigherBound='37.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='344f3696-38c8-4f31-a1d2-14ef411b7f2a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='38.1' HigherBound='40.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='SQL_Adapter_Stored_Procedure.oprtSendCustomerSQLType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='oprtSendCustomerSQL' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='6ba47eaa-2b22-4283-916f-6d614f66f9af' ParentLink='PortDeclaration_CLRAttribute' LowerBound='38.1' HigherBound='39.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='63a75492-24fc-4773-b815-613227d9c927' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='40.1' HigherBound='41.1'>
                <om:Property Name='Type' Value='SQL_Adapter_Stored_Procedure.schCustomer' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgCustomerIn' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='69da8dd4-cf0d-4bc9-b248-933b0fcd09d2' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='41.1' HigherBound='42.1'>
                <om:Property Name='Type' Value='SQL_Adapter_Stored_Procedure.SQLService.Customer_Request' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgCustomerOut' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Orchestration_1_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Orchestration_1_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Orchestration_1")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                Orchestration_1 __svc__ = (Orchestration_1)_service;
                __Orchestration_1_root_0 __ctx0__ = (__Orchestration_1_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.oprtReceiveCustomer != null)
                {
                    __svc__.oprtReceiveCustomer.Close(this, null);
                    __svc__.oprtReceiveCustomer = null;
                }
                if (__svc__.oprtSendCustomerSQL != null)
                {
                    __svc__.oprtSendCustomerSQL.Close(this, null);
                    __svc__.oprtSendCustomerSQL = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __Orchestration_1_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Orchestration_1_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Orchestration_1")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                Orchestration_1 __svc__ = (Orchestration_1)_service;
                __Orchestration_1_1 __ctx1__ = (__Orchestration_1_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgCustomerIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerIn);
                    __ctx1__.__msgCustomerIn = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgCustomerOut != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerOut);
                    __ctx1__.__msgCustomerOut = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCustomerIn")]
            public __messagetype_SQL_Adapter_Stored_Procedure_schCustomer __msgCustomerIn;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCustomerOut")]
            public __messagetype_SQL_Adapter_Stored_Procedure_SQLService_Customer_Request __msgCustomerOut;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("oprtReceiveCustomer")]
        internal oprtReceiveCustomerType oprtReceiveCustomer;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("oprtSendCustomerSQL")]
        internal oprtSendCustomerSQLType oprtSendCustomerSQL;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {oprtReceiveCustomerType.Operation_1},
                                               typeof(Orchestration_1).GetField("oprtReceiveCustomer", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orchestration_1), "oprtReceiveCustomer"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {oprtSendCustomerSQLType.Operation_1},
                                               typeof(Orchestration_1).GetField("oprtSendCustomerSQL", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orchestration_1), "oprtSendCustomerSQL"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "46ce5b2f-455d-4970-a555-39f5b7760d2e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "46ce5b2f-455d-4970-a555-39f5b7760d2e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "51b293b4-da47-4d44-be7b-0cf272e5b8b2", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "51b293b4-da47-4d44-be7b-0cf272e5b8b2", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "22cac543-e597-4204-9c24-cb14ffe95fe8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "22cac543-e597-4204-9c24-cb14ffe95fe8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,7,7,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,7,7,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __Orchestration_1_root_0 __ctx0__ = (__Orchestration_1_root_0)_stateMgrs[0];
            __Orchestration_1_1 __ctx1__ = (__Orchestration_1_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                oprtReceiveCustomer = new oprtReceiveCustomerType(0, this);
                oprtSendCustomerSQL = new oprtSendCustomerSQLType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], oprtReceiveCustomer, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Orchestration_1_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __Orchestration_1_root_0 __ctx0__ = (__Orchestration_1_root_0)_stateMgrs[0];
            __Orchestration_1_1 __ctx1__ = (__Orchestration_1_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!oprtReceiveCustomer.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgCustomerIn != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerIn);
                __ctx1__.__msgCustomerIn = new __messagetype_SQL_Adapter_Stored_Procedure_schCustomer("msgCustomerIn", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgCustomerIn);
                oprtReceiveCustomer.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgCustomerIn, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (oprtReceiveCustomer != null)
                {
                    oprtReceiveCustomer.Close(__ctx1__, __seg__);
                    oprtReceiveCustomer = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgCustomerIn);
                    __edata.PortName = @"oprtReceiveCustomer";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_SQL_Adapter_Stored_Procedure_SQLService_Customer_Request __msgCustomerOut = new __messagetype_SQL_Adapter_Stored_Procedure_SQLService_Customer_Request("msgCustomerOut", __ctx1__);

                    ApplyTransform(typeof(SQL_Adapter_Stored_Procedure.MapCustomerInToSQLService), new object[] {__msgCustomerOut.part}, new object[] {__ctx1__.__msgCustomerIn.part});

                    if (__ctx1__.__msgCustomerOut != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgCustomerOut);
                    __ctx1__.__msgCustomerOut = __msgCustomerOut;
                    __ctx1__.RefMessage(__ctx1__.__msgCustomerOut);
                }
                __ctx1__.__msgCustomerOut.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgCustomerOut);
                    __edata.Messages.Add(__ctx1__.__msgCustomerIn);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgCustomerIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerIn);
                    __ctx1__.__msgCustomerIn = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                oprtSendCustomerSQL.SendMessage(0, __ctx1__.__msgCustomerOut, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (oprtSendCustomerSQL != null)
                {
                    oprtSendCustomerSQL.Close(__ctx1__, __seg__);
                    oprtSendCustomerSQL = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgCustomerOut);
                    __edata.PortName = @"oprtSendCustomerSQL";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgCustomerOut != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerOut);
                    __ctx1__.__msgCustomerOut = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 15;
            case 15:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
