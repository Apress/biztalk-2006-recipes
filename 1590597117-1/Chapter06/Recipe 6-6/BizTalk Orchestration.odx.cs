
#pragma warning disable 162

namespace SQL_Adapter_Updategram
{

    [System.SerializableAttribute]
    sealed public class __SQL_Adapter_Updategram_InsertCustomerService_Customer_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static SQL_Adapter_Updategram.InsertCustomerService.Customer_Request _schema = new SQL_Adapter_Updategram.InsertCustomerService.Customer_Request();

        public __SQL_Adapter_Updategram_InsertCustomerService_Customer_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(SQL_Adapter_Updategram.InsertCustomerService.Customer_Request)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__SQL_Adapter_Updategram_InsertCustomerService_Customer_Request__)
        },
        0,
        @"http://SQLAdapterUpdategram#Customer_Request"
    )]
    [System.SerializableAttribute]
    sealed internal class InsertCustomerRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __SQL_Adapter_Updategram_InsertCustomerService_Customer_Request__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __SQL_Adapter_Updategram_InsertCustomerService_Customer_Request__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public InsertCustomerRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __SQL_Adapter_Updategram_InsertCustomerService_Customer_Response__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static SQL_Adapter_Updategram.InsertCustomerService.Customer_Response _schema = new SQL_Adapter_Updategram.InsertCustomerService.Customer_Response();

        public __SQL_Adapter_Updategram_InsertCustomerService_Customer_Response__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(SQL_Adapter_Updategram.InsertCustomerService.Customer_Response)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__SQL_Adapter_Updategram_InsertCustomerService_Customer_Response__)
        },
        0,
        @"http://SQLAdapterUpdategram#Customer_Response"
    )]
    [System.SerializableAttribute]
    sealed internal class InsertCustomerResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __SQL_Adapter_Updategram_InsertCustomerService_Customer_Response__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __SQL_Adapter_Updategram_InsertCustomerService_Customer_Response__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public InsertCustomerResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "InsertCustomer",
        new System.Type[]{
            typeof(SQL_Adapter_Updategram.InsertCustomerRequest), 
            typeof(SQL_Adapter_Updategram.InsertCustomerResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class InsertCustomerPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public InsertCustomerPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public InsertCustomerPortType(InsertCustomerPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            InsertCustomerPortType p = new InsertCustomerPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo InsertCustomer = new Microsoft.XLANGs.Core.OperationInfo
        (
            "InsertCustomer",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(InsertCustomerPortType),
            typeof(InsertCustomerRequest),
            typeof(InsertCustomerResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "InsertCustomer" ] = InsertCustomer;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "SQL_Adapter_Updategram.InsertCustomerService.Customer_Request",
        new System.Type[]{
            typeof(SQL_Adapter_Updategram.InsertCustomerService.Customer_Request)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__SQL_Adapter_Updategram_InsertCustomerService_Customer_Request__)
        },
        0,
        @"http://SQLAdapterUpdategram#Customer_Request"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_SQL_Adapter_Updategram_InsertCustomerService_Customer_Request : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __SQL_Adapter_Updategram_InsertCustomerService_Customer_Request__ part;

        private void __CreatePartWrappers()
        {
            part = new __SQL_Adapter_Updategram_InsertCustomerService_Customer_Request__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_SQL_Adapter_Updategram_InsertCustomerService_Customer_Request(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(SQL_Adapter_Updategram.__messagetype_SQL_Adapter_Updategram_InsertCustomerService_Customer_Request)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class oprtReceiveMessageType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public oprtReceiveMessageType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public oprtReceiveMessageType(oprtReceiveMessageType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            oprtReceiveMessageType p = new oprtReceiveMessageType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(oprtReceiveMessageType),
            typeof(__messagetype_SQL_Adapter_Updategram_InsertCustomerService_Customer_Request),
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
            typeof(SQL_Adapter_Updategram.__messagetype_SQL_Adapter_Updategram_InsertCustomerService_Customer_Request)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class oprtSendMessageType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public oprtSendMessageType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public oprtSendMessageType(oprtSendMessageType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            oprtSendMessageType p = new oprtSendMessageType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(oprtSendMessageType),
            typeof(__messagetype_SQL_Adapter_Updategram_InsertCustomerService_Customer_Request),
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
    //#line 211 "C:\Documents and Settings\Administrator\Desktop\BizTalk Book Solutions\SQL Adapter Updategram Solution\BizTalk Orchestration.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "oprtReceiveMessage", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(SQL_Adapter_Updategram.oprtReceiveMessageType),
            typeof(SQL_Adapter_Updategram.oprtSendMessageType)
        },
        new System.String[] {
            "oprtReceiveMessage",
            "oprtSendMessage"
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
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>4950a41f-674b-45b0-849e-7a285b140133</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>9046188f-ddef-469f-bf4a-32e2abbba8e9</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_Customer</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>484e1797-8593-4e9f-8ca2-38ec7d6b42eb</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_Customer</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow>
<Metadata>

<TrkMetadata>
<ActionName>'Orchestration_1'</ActionName><IsAtomic>0</IsAtomic><Line>211</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>221</Line><Position>22</Position><ShapeID>'9046188f-ddef-469f-bf4a-32e2abbba8e9'</ShapeID>
<Messages>
	<MsgInfo><name>msgCustomerUpdate</name><part>part</part><schema>SQL_Adapter_Updategram.InsertCustomerService+Customer_Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>223</Line><Position>13</Position><ShapeID>'484e1797-8593-4e9f-8ca2-38ec7d6b42eb'</ShapeID>
<Messages>
	<MsgInfo><name>msgCustomerUpdate</name><part>part</part><schema>SQL_Adapter_Updategram.InsertCustomerService+Customer_Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='83a0760c-3c5e-4540-bff6-1024739de1c1' LowerBound='1.1' HigherBound='50.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='SQL_Adapter_Updategram' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='9c5b6817-af34-44c0-9c20-aca810e9441f' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata port type: ' />
            <om:Property Name='Name' Value='InsertCustomerPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='b135327f-1921-48c7-9c25-09d2c26445eb' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata operation: ' />
                <om:Property Name='Name' Value='InsertCustomer' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='e60a9950-4ba7-4918-8381-f3bc8b3c0116' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.34'>
                    <om:Property Name='Ref' Value='SQL_Adapter_Updategram.InsertCustomerRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='f9524abf-4561-42a2-8ef9-8d70d2298591' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='16.36' HigherBound='16.58'>
                    <om:Property Name='Ref' Value='SQL_Adapter_Updategram.InsertCustomerResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='744ca54d-b56d-4621-92ac-ee816a9eded8' ParentLink='Module_PortType' LowerBound='19.1' HigherBound='26.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='oprtReceiveMessageType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='eab15917-4a9b-4271-ac41-6cfe3e94c756' ParentLink='PortType_OperationDeclaration' LowerBound='21.1' HigherBound='25.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='c03d6f81-9988-48f6-8278-576c1a061053' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='23.13' HigherBound='23.51'>
                    <om:Property Name='Ref' Value='SQL_Adapter_Updategram.InsertCustomerService.Customer_Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='98b6c6e0-1880-4c41-a1b7-5754d4f7be0e' ParentLink='Module_PortType' LowerBound='26.1' HigherBound='33.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='oprtSendMessageType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='43b7c498-d15c-4f80-a298-022c1bb87830' ParentLink='PortType_OperationDeclaration' LowerBound='28.1' HigherBound='32.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='97b1dcde-8503-48b1-adf4-01e745e957d3' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='30.13' HigherBound='30.51'>
                    <om:Property Name='Ref' Value='SQL_Adapter_Updategram.InsertCustomerService.Customer_Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='562a8766-712b-4220-8ad0-1aaf573e8259' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='InsertCustomerRequest' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='42fd9798-8f95-4d9f-80fb-28231459515a' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='SQL_Adapter_Updategram.InsertCustomerService.Customer_Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='9573c9c2-f07b-42ed-ae16-de6873e18bc9' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='InsertCustomerResponse' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='75c36d08-b034-4a14-bc6e-349a872dc57c' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='SQL_Adapter_Updategram.InsertCustomerService.Customer_Response' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='a29fa2f9-8bf8-44e5-b1f5-e96c004e47c7' ParentLink='Module_ServiceDeclaration' LowerBound='33.1' HigherBound='49.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Orchestration_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='4950a41f-674b-45b0-849e-7a285b140133' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='9046188f-ddef-469f-bf4a-32e2abbba8e9' ParentLink='ServiceBody_Statement' LowerBound='43.1' HigherBound='45.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='oprtReceiveMessage' />
                    <om:Property Name='MessageName' Value='msgCustomerUpdate' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_Customer' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='484e1797-8593-4e9f-8ca2-38ec7d6b42eb' ParentLink='ServiceBody_Statement' LowerBound='45.1' HigherBound='47.1'>
                    <om:Property Name='PortName' Value='oprtSendMessage' />
                    <om:Property Name='MessageName' Value='msgCustomerUpdate' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_Customer' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='c4482c09-7ebe-4252-857f-49b4f2ccfc25' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='36.1' HigherBound='38.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='SQL_Adapter_Updategram.oprtReceiveMessageType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='oprtReceiveMessage' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='e196d835-8763-4037-a170-3c69af25df53' ParentLink='PortDeclaration_CLRAttribute' LowerBound='36.1' HigherBound='37.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='9e7c42ef-68dc-4cac-a672-b5d79ab929a8' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='38.1' HigherBound='40.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='SQL_Adapter_Updategram.oprtSendMessageType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='oprtSendMessage' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='cd2136b5-a72f-4796-84b3-65e43cbcbafd' ParentLink='PortDeclaration_CLRAttribute' LowerBound='38.1' HigherBound='39.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='26bb7842-2473-45ce-8bc1-6c0e040473b0' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='40.1' HigherBound='41.1'>
                <om:Property Name='Type' Value='SQL_Adapter_Updategram.InsertCustomerService.Customer_Request' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgCustomerUpdate' />
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

                if (__svc__.oprtReceiveMessage != null)
                {
                    __svc__.oprtReceiveMessage.Close(this, null);
                    __svc__.oprtReceiveMessage = null;
                }
                if (__svc__.oprtSendMessage != null)
                {
                    __svc__.oprtSendMessage.Close(this, null);
                    __svc__.oprtSendMessage = null;
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

                if (__ctx1__ != null && __ctx1__.__msgCustomerUpdate != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerUpdate);
                    __ctx1__.__msgCustomerUpdate = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgCustomerUpdate")]
            public __messagetype_SQL_Adapter_Updategram_InsertCustomerService_Customer_Request __msgCustomerUpdate;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("oprtReceiveMessage")]
        internal oprtReceiveMessageType oprtReceiveMessage;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("oprtSendMessage")]
        internal oprtSendMessageType oprtSendMessage;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {oprtReceiveMessageType.Operation_1},
                                               typeof(Orchestration_1).GetField("oprtReceiveMessage", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orchestration_1), "oprtReceiveMessage"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {oprtSendMessageType.Operation_1},
                                               typeof(Orchestration_1).GetField("oprtSendMessage", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orchestration_1), "oprtSendMessage"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "9046188f-ddef-469f-bf4a-32e2abbba8e9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "9046188f-ddef-469f-bf4a-32e2abbba8e9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "484e1797-8593-4e9f-8ca2-38ec7d6b42eb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "484e1797-8593-4e9f-8ca2-38ec7d6b42eb", 1, false),
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
                oprtReceiveMessage = new oprtReceiveMessageType(0, this);
                oprtSendMessage = new oprtSendMessageType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], oprtReceiveMessage, this);
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
                if (!oprtReceiveMessage.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgCustomerUpdate != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerUpdate);
                __ctx1__.__msgCustomerUpdate = new __messagetype_SQL_Adapter_Updategram_InsertCustomerService_Customer_Request("msgCustomerUpdate", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgCustomerUpdate);
                oprtReceiveMessage.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgCustomerUpdate, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (oprtReceiveMessage != null)
                {
                    oprtReceiveMessage.Close(__ctx1__, __seg__);
                    oprtReceiveMessage = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgCustomerUpdate);
                    __edata.PortName = @"oprtReceiveMessage";
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
                oprtSendMessage.SendMessage(0, __ctx1__.__msgCustomerUpdate, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (oprtSendMessage != null)
                {
                    oprtSendMessage.Close(__ctx1__, __seg__);
                    oprtSendMessage = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgCustomerUpdate);
                    __edata.PortName = @"oprtSendMessage";
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgCustomerUpdate != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgCustomerUpdate);
                    __ctx1__.__msgCustomerUpdate = null;
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
