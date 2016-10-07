
#pragma warning disable 162

namespace SQL_Receive_Adapter_Recipe
{

    [System.SerializableAttribute]
    sealed public class __SQL_Receive_Adapter_Recipe_SQLService__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static SQL_Receive_Adapter_Recipe.SQLService _schema = new SQL_Receive_Adapter_Recipe.SQLService();

        public __SQL_Receive_Adapter_Recipe_SQLService__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(SQL_Receive_Adapter_Recipe.SQLService)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__SQL_Receive_Adapter_Recipe_SQLService__)
        },
        0,
        @"http://SQLReceiveAdapter#Customer_Response"
    )]
    [System.SerializableAttribute]
    sealed internal class procedureRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __SQL_Receive_Adapter_Recipe_SQLService__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __SQL_Receive_Adapter_Recipe_SQLService__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public procedureRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "procedure",
        new System.Type[]{
            typeof(SQL_Receive_Adapter_Recipe.procedureRequest)
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
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SQLServiceExec),
            typeof(procedureRequest),
            null,
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

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "SQL_Receive_Adapter_Recipe.SQLService",
        new System.Type[]{
            typeof(SQL_Receive_Adapter_Recipe.SQLService)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__SQL_Receive_Adapter_Recipe_SQLService__)
        },
        0,
        @"http://SQLReceiveAdapter#Customer_Response"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_SQL_Receive_Adapter_Recipe_SQLService : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __SQL_Receive_Adapter_Recipe_SQLService__ part;

        private void __CreatePartWrappers()
        {
            part = new __SQL_Receive_Adapter_Recipe_SQLService__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_SQL_Receive_Adapter_Recipe_SQLService(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(SQL_Receive_Adapter_Recipe.__messagetype_SQL_Receive_Adapter_Recipe_SQLService)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class oprtReceiveCustomerSQLType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public oprtReceiveCustomerSQLType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public oprtReceiveCustomerSQLType(oprtReceiveCustomerSQLType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            oprtReceiveCustomerSQLType p = new oprtReceiveCustomerSQLType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(oprtReceiveCustomerSQLType),
            typeof(__messagetype_SQL_Receive_Adapter_Recipe_SQLService),
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
            typeof(SQL_Receive_Adapter_Recipe.__messagetype_SQL_Receive_Adapter_Recipe_SQLService)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class oprtSendCustomerType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public oprtSendCustomerType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public oprtSendCustomerType(oprtSendCustomerType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            oprtSendCustomerType p = new oprtSendCustomerType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(oprtSendCustomerType),
            typeof(__messagetype_SQL_Receive_Adapter_Recipe_SQLService),
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
    //#line 185 "C:\Documents and Settings\Administrator\Desktop\BizTalk Book Solutions\SQL Receive Adapter Recipe\BizTalk Orchestration.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "oprtReceiveSQLCustomer", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(SQL_Receive_Adapter_Recipe.oprtReceiveCustomerSQLType),
            typeof(SQL_Receive_Adapter_Recipe.oprtSendCustomerType)
        },
        new System.String[] {
            "oprtReceiveSQLCustomer",
            "oprtSendCustomer"
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
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>f72f98f7-5063-489c-ae4b-dc99e4f2d805</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>473c9d07-91a1-4859-81ec-b4046aeeed6e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>8a5ad9c5-ae24-40a9-bc77-028da201a8ac</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_Customer</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow>
<Metadata>

<TrkMetadata>
<ActionName>'Orchestration_1'</ActionName><IsAtomic>0</IsAtomic><Line>185</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>195</Line><Position>22</Position><ShapeID>'473c9d07-91a1-4859-81ec-b4046aeeed6e'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLCustomer</name><part>part</part><schema>SQL_Receive_Adapter_Recipe.SQLService</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>197</Line><Position>13</Position><ShapeID>'8a5ad9c5-ae24-40a9-bc77-028da201a8ac'</ShapeID>
<Messages>
	<MsgInfo><name>msgSQLCustomer</name><part>part</part><schema>SQL_Receive_Adapter_Recipe.SQLService</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='3893e09e-e024-450e-b175-62111dd1450b' LowerBound='1.1' HigherBound='46.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='SQL_Receive_Adapter_Recipe' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='ef871759-dfb7-439f-b53f-11fb311f56c4' ParentLink='Module_PortType' LowerBound='8.1' HigherBound='15.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata port type: ' />
            <om:Property Name='Name' Value='SQLServiceExec' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='ee1e1cca-e9de-4751-a854-4712b5e4eade' ParentLink='PortType_OperationDeclaration' LowerBound='10.1' HigherBound='14.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata operation: ' />
                <om:Property Name='Name' Value='procedure' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='e08c6b1d-8c32-489a-b5f5-e8b79f6615e8' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='12.13' HigherBound='12.29'>
                    <om:Property Name='Ref' Value='SQL_Receive_Adapter_Recipe.procedureRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='5fa311d5-d1ad-4061-96f5-902c32106950' ParentLink='Module_PortType' LowerBound='15.1' HigherBound='22.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='oprtReceiveCustomerSQLType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='eecbd655-0218-4e4d-8093-5375784b99f8' ParentLink='PortType_OperationDeclaration' LowerBound='17.1' HigherBound='21.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='0837d761-2980-4b82-b7d4-b6a069ada32e' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='19.13' HigherBound='19.23'>
                    <om:Property Name='Ref' Value='SQL_Receive_Adapter_Recipe.SQLService' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='e2ea0005-6729-4ecb-a6a1-f1e1094d4bbd' ParentLink='Module_PortType' LowerBound='22.1' HigherBound='29.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='oprtSendCustomerType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='af8a87d3-57d9-43d1-9007-f8d337588dad' ParentLink='PortType_OperationDeclaration' LowerBound='24.1' HigherBound='28.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='4c6f3ef3-196f-494f-9b2f-3530be0f0b1e' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='26.13' HigherBound='26.23'>
                    <om:Property Name='Ref' Value='SQL_Receive_Adapter_Recipe.SQLService' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='0437d7ce-4849-498d-9def-612536b8295f' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='procedureRequest' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='93508cb1-9284-4fa8-9fb8-41cda1c34e81' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='SQL_Receive_Adapter_Recipe.SQLService' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='090e98ae-96ec-4b58-8f36-2105a17b5c21' ParentLink='Module_ServiceDeclaration' LowerBound='29.1' HigherBound='45.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Orchestration_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='f72f98f7-5063-489c-ae4b-dc99e4f2d805' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='473c9d07-91a1-4859-81ec-b4046aeeed6e' ParentLink='ServiceBody_Statement' LowerBound='39.1' HigherBound='41.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='oprtReceiveSQLCustomer' />
                    <om:Property Name='MessageName' Value='msgSQLCustomer' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='8a5ad9c5-ae24-40a9-bc77-028da201a8ac' ParentLink='ServiceBody_Statement' LowerBound='41.1' HigherBound='43.1'>
                    <om:Property Name='PortName' Value='oprtSendCustomer' />
                    <om:Property Name='MessageName' Value='msgSQLCustomer' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_Customer' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e00a60d9-f7cf-43fe-87c6-4bc3c3ca51db' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='32.1' HigherBound='34.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='SQL_Receive_Adapter_Recipe.oprtReceiveCustomerSQLType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='oprtReceiveSQLCustomer' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='fc170ec0-4cf1-4ecc-a19d-9800f4909033' ParentLink='PortDeclaration_CLRAttribute' LowerBound='32.1' HigherBound='33.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='4ce83ea0-f454-45c3-9db9-62cce1f6c79e' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='34.1' HigherBound='36.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='SQL_Receive_Adapter_Recipe.oprtSendCustomerType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='oprtSendCustomer' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='eb94053a-758f-4dd1-b547-d38da995c7b5' ParentLink='PortDeclaration_CLRAttribute' LowerBound='34.1' HigherBound='35.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='e2392e8c-c55b-4525-8556-1a51917d8ad9' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='Type' Value='SQL_Receive_Adapter_Recipe.SQLService' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSQLCustomer' />
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

                if (__svc__.oprtReceiveSQLCustomer != null)
                {
                    __svc__.oprtReceiveSQLCustomer.Close(this, null);
                    __svc__.oprtReceiveSQLCustomer = null;
                }
                if (__svc__.oprtSendCustomer != null)
                {
                    __svc__.oprtSendCustomer.Close(this, null);
                    __svc__.oprtSendCustomer = null;
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

                if (__ctx1__ != null && __ctx1__.__msgSQLCustomer != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLCustomer);
                    __ctx1__.__msgSQLCustomer = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSQLCustomer")]
            public __messagetype_SQL_Receive_Adapter_Recipe_SQLService __msgSQLCustomer;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("oprtReceiveSQLCustomer")]
        internal oprtReceiveCustomerSQLType oprtReceiveSQLCustomer;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("oprtSendCustomer")]
        internal oprtSendCustomerType oprtSendCustomer;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {oprtReceiveCustomerSQLType.Operation_1},
                                               typeof(Orchestration_1).GetField("oprtReceiveSQLCustomer", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orchestration_1), "oprtReceiveSQLCustomer"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {oprtSendCustomerType.Operation_1},
                                               typeof(Orchestration_1).GetField("oprtSendCustomer", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orchestration_1), "oprtSendCustomer"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "473c9d07-91a1-4859-81ec-b4046aeeed6e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "473c9d07-91a1-4859-81ec-b4046aeeed6e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "8a5ad9c5-ae24-40a9-bc77-028da201a8ac", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "8a5ad9c5-ae24-40a9-bc77-028da201a8ac", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,5,5,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,3,4,5,5,5,5,};

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
                oprtReceiveSQLCustomer = new oprtReceiveCustomerSQLType(0, this);
                oprtSendCustomer = new oprtSendCustomerType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], oprtReceiveSQLCustomer, this);
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
                if (!oprtReceiveSQLCustomer.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgSQLCustomer != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLCustomer);
                __ctx1__.__msgSQLCustomer = new __messagetype_SQL_Receive_Adapter_Recipe_SQLService("msgSQLCustomer", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgSQLCustomer);
                oprtReceiveSQLCustomer.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgSQLCustomer, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (oprtReceiveSQLCustomer != null)
                {
                    oprtReceiveSQLCustomer.Close(__ctx1__, __seg__);
                    oprtReceiveSQLCustomer = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgSQLCustomer);
                    __edata.PortName = @"oprtReceiveSQLCustomer";
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
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                oprtSendCustomer.SendMessage(0, __ctx1__.__msgSQLCustomer, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (oprtSendCustomer != null)
                {
                    oprtSendCustomer.Close(__ctx1__, __seg__);
                    oprtSendCustomer = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgSQLCustomer);
                    __edata.PortName = @"oprtSendCustomer";
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgSQLCustomer != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSQLCustomer);
                    __ctx1__.__msgSQLCustomer = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 12;
            case 12:
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
