#pragma warning disable CS1591
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Core")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Core.Abstractions")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Serialization")]
[assembly: global::Orleans.Serialization.Configuration.TypeManifestProviderAttribute(typeof(OrleansCodeGen.OrleansCore.Metadata_OrleansCore))]
namespace OrleansCodeGen.Orleans.ClientObservers
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.ClientObservers.IClientGatewayObserver), "AFB768FD")]
    internal sealed class Invokable_IClientGatewayObserver_GrainReference_AFB768FD : global::Orleans.Runtime.VoidRequest
    {
        public global::Orleans.Runtime.SiloAddress arg0;
        global::Orleans.ClientObservers.IClientGatewayObserver target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.ClientObservers.IClientGatewayObserver), "StopSendingToGateway", null, new[] { typeof(global::Orleans.Runtime.SiloAddress) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "StopSendingToGateway";
        public override string GetInterfaceName() => "Orleans.ClientObservers.IClientGatewayObserver";
        public override string GetActivityName() => "IClientGatewayObserver/StopSendingToGateway";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.ClientObservers.IClientGatewayObserver);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.ClientObservers.IClientGatewayObserver>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.SiloAddress)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override void InvokeInner() => target.StopSendingToGateway(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IClientGatewayObserver : global::Orleans.Runtime.GrainReference, global::Orleans.ClientObservers.IClientGatewayObserver
    {
        public Proxy_IClientGatewayObserver(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }

        void global::Orleans.ClientObservers.IClientGatewayObserver.StopSendingToGateway(global::Orleans.Runtime.SiloAddress arg0)
        {
            var request = new OrleansCodeGen.Orleans.ClientObservers.Invokable_IClientGatewayObserver_GrainReference_AFB768FD();
            request.arg0 = arg0;
            base.Invoke(request);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IClientGatewayObserver_GrainReference_AFB768FD : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.ClientObservers.Invokable_IClientGatewayObserver_GrainReference_AFB768FD>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.ClientObservers.Invokable_IClientGatewayObserver_GrainReference_AFB768FD);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.SiloAddress);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress> _codec0;
        public Codec_Invokable_IClientGatewayObserver_GrainReference_AFB768FD(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.ClientObservers.Invokable_IClientGatewayObserver_GrainReference_AFB768FD instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.ClientObservers.Invokable_IClientGatewayObserver_GrainReference_AFB768FD instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.ClientObservers.Invokable_IClientGatewayObserver_GrainReference_AFB768FD @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.ClientObservers.Invokable_IClientGatewayObserver_GrainReference_AFB768FD ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.ClientObservers.Invokable_IClientGatewayObserver_GrainReference_AFB768FD, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.ClientObservers.Invokable_IClientGatewayObserver_GrainReference_AFB768FD();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IClientGatewayObserver_GrainReference_AFB768FD : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.ClientObservers.Invokable_IClientGatewayObserver_GrainReference_AFB768FD>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.ClientObservers.Invokable_IClientGatewayObserver_GrainReference_AFB768FD DeepCopy(OrleansCodeGen.Orleans.ClientObservers.Invokable_IClientGatewayObserver_GrainReference_AFB768FD original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.ClientObservers.Invokable_IClientGatewayObserver_GrainReference_AFB768FD();
            result.arg0 = original.arg0;
            return result;
        }
    }
}
#pragma warning restore CS1591

namespace OrleansCodeGen.Orleans.Runtime
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IClusterManifestSystemTarget), "40D39F85")]
    internal sealed class Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85 : global::Orleans.Runtime.Request<global::Orleans.Metadata.ClusterManifest>
    {
        global::Orleans.Runtime.IClusterManifestSystemTarget target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IClusterManifestSystemTarget), "GetClusterManifest", null, null);
        public override string GetMethodName() => "GetClusterManifest";
        public override string GetInterfaceName() => "Orleans.Runtime.IClusterManifestSystemTarget";
        public override string GetActivityName() => "IClusterManifestSystemTarget/GetClusterManifest";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IClusterManifestSystemTarget);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IClusterManifestSystemTarget>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.ValueTask<global::Orleans.Metadata.ClusterManifest> InvokeInner() => target.GetClusterManifest();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IClusterManifestSystemTarget), "4EFCA109")]
    internal sealed class Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109 : global::Orleans.Runtime.Request<global::Orleans.Runtime.ClusterManifestUpdate>
    {
        public global::Orleans.Metadata.MajorMinorVersion arg0;
        global::Orleans.Runtime.IClusterManifestSystemTarget target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IClusterManifestSystemTarget), "GetClusterManifestUpdate", null, new[] { typeof(global::Orleans.Metadata.MajorMinorVersion) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "GetClusterManifestUpdate";
        public override string GetInterfaceName() => "Orleans.Runtime.IClusterManifestSystemTarget";
        public override string GetActivityName() => "IClusterManifestSystemTarget/GetClusterManifestUpdate";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IClusterManifestSystemTarget);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IClusterManifestSystemTarget>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Metadata.MajorMinorVersion)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.ValueTask<global::Orleans.Runtime.ClusterManifestUpdate> InvokeInner() => target.GetClusterManifestUpdate(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IClusterManifestSystemTarget : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IClusterManifestSystemTarget
    {
        public Proxy_IClusterManifestSystemTarget(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.ValueTask<global::Orleans.Metadata.ClusterManifest> global::Orleans.Runtime.IClusterManifestSystemTarget.GetClusterManifest()
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85();
            return base.InvokeAsync<global::Orleans.Metadata.ClusterManifest>(request);
        }

        global::System.Threading.Tasks.ValueTask<global::Orleans.Runtime.ClusterManifestUpdate> global::Orleans.Runtime.IClusterManifestSystemTarget.GetClusterManifestUpdate(global::Orleans.Metadata.MajorMinorVersion arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109();
            request.arg0 = arg0;
            return base.InvokeAsync<global::Orleans.Runtime.ClusterManifestUpdate>(request);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.ICatalog), "C4A56D7C")]
    internal sealed class Invokable_ICatalog_GrainReference_C4A56D7C : global::Orleans.Runtime.TaskRequest
    {
        public global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress> arg0;
        public global::Orleans.DeactivationReasonCode arg1;
        public string arg2;
        global::Orleans.Runtime.ICatalog target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.ICatalog), "DeleteActivations", null, new[] { typeof(global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress>), typeof(global::Orleans.DeactivationReasonCode), typeof(string) });
        public override int GetArgumentCount() => 3;
        public override string GetMethodName() => "DeleteActivations";
        public override string GetInterfaceName() => "Orleans.Runtime.ICatalog";
        public override string GetActivityName() => "ICatalog/DeleteActivations";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.ICatalog);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.ICatalog>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                case 1:
                    return arg1;
                case 2:
                    return arg2;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress>)value;
                    return;
                case 1:
                    arg1 = (global::Orleans.DeactivationReasonCode)value;
                    return;
                case 2:
                    arg2 = (string)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.DeleteActivations(arg0, arg1, arg2);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_ICatalog : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.ICatalog
    {
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Runtime.GrainAddress> _copier0;
        public Proxy_ICatalog(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Runtime.GrainAddress>>(this, CodecProvider);
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.ICatalog.DeleteActivations(global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress> arg0, global::Orleans.DeactivationReasonCode arg1, string arg2)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_ICatalog_GrainReference_C4A56D7C();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            request.arg1 = arg1;
            request.arg2 = arg2;
            return base.InvokeAsync(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IDeploymentLoadPublisher), "C5255F0C")]
    internal sealed class Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.Runtime.SiloAddress arg0;
        public global::Orleans.Runtime.SiloRuntimeStatistics arg1;
        global::Orleans.Runtime.IDeploymentLoadPublisher target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IDeploymentLoadPublisher), "UpdateRuntimeStatistics", null, new[] { typeof(global::Orleans.Runtime.SiloAddress), typeof(global::Orleans.Runtime.SiloRuntimeStatistics) });
        public Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C() : base()
        {
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.OneWay);
        }

        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "UpdateRuntimeStatistics";
        public override string GetInterfaceName() => "Orleans.Runtime.IDeploymentLoadPublisher";
        public override string GetActivityName() => "IDeploymentLoadPublisher/UpdateRuntimeStatistics";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IDeploymentLoadPublisher);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IDeploymentLoadPublisher>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                case 1:
                    return arg1;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.SiloAddress)value;
                    return;
                case 1:
                    arg1 = (global::Orleans.Runtime.SiloRuntimeStatistics)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.UpdateRuntimeStatistics(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IDeploymentLoadPublisher : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IDeploymentLoadPublisher
    {
        public Proxy_IDeploymentLoadPublisher(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.IDeploymentLoadPublisher.UpdateRuntimeStatistics(global::Orleans.Runtime.SiloAddress arg0, global::Orleans.Runtime.SiloRuntimeStatistics arg1)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C();
            request.arg0 = arg0;
            request.arg1 = arg1;
            return base.InvokeAsync(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "4C0864C2")]
    public sealed class Invokable_IManagementGrain_GrainReference_4C0864C2 : global::Orleans.Runtime.TaskRequest<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloStatus>>
    {
        public bool arg0;
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "GetHosts", null, new[] { typeof(bool) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "GetHosts";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/GetHosts";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (bool)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloStatus>> InvokeInner() => target.GetHosts(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "CC6CCBC3")]
    public sealed class Invokable_IManagementGrain_GrainReference_CC6CCBC3 : global::Orleans.Runtime.TaskRequest<global::Orleans.MembershipEntry[]>
    {
        public bool arg0;
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "GetDetailedHosts", null, new[] { typeof(bool) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "GetDetailedHosts";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/GetDetailedHosts";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (bool)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.MembershipEntry[]> InvokeInner() => target.GetDetailedHosts(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "5922EB76")]
    public sealed class Invokable_IManagementGrain_GrainReference_5922EB76 : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.Runtime.SiloAddress[] arg0;
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "ForceGarbageCollection", null, new[] { typeof(global::Orleans.Runtime.SiloAddress[]) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "ForceGarbageCollection";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/ForceGarbageCollection";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.SiloAddress[])value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.ForceGarbageCollection(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "329F9A1B")]
    public sealed class Invokable_IManagementGrain_GrainReference_329F9A1B : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.Runtime.SiloAddress[] arg0;
        public global::System.TimeSpan arg1;
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "ForceActivationCollection", null, new[] { typeof(global::Orleans.Runtime.SiloAddress[]), typeof(global::System.TimeSpan) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "ForceActivationCollection";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/ForceActivationCollection";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                case 1:
                    return arg1;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.SiloAddress[])value;
                    return;
                case 1:
                    arg1 = (global::System.TimeSpan)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.ForceActivationCollection(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "54E6D1D1")]
    public sealed class Invokable_IManagementGrain_GrainReference_54E6D1D1 : global::Orleans.Runtime.TaskRequest
    {
        public global::System.TimeSpan arg0;
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "ForceActivationCollection", null, new[] { typeof(global::System.TimeSpan) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "ForceActivationCollection";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/ForceActivationCollection";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::System.TimeSpan)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.ForceActivationCollection(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "B761B345")]
    public sealed class Invokable_IManagementGrain_GrainReference_B761B345 : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.Runtime.SiloAddress[] arg0;
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "ForceRuntimeStatisticsCollection", null, new[] { typeof(global::Orleans.Runtime.SiloAddress[]) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "ForceRuntimeStatisticsCollection";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/ForceRuntimeStatisticsCollection";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.SiloAddress[])value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.ForceRuntimeStatisticsCollection(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "2D761B36")]
    public sealed class Invokable_IManagementGrain_GrainReference_2D761B36 : global::Orleans.Runtime.TaskRequest<global::Orleans.Runtime.SiloRuntimeStatistics[]>
    {
        public global::Orleans.Runtime.SiloAddress[] arg0;
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "GetRuntimeStatistics", null, new[] { typeof(global::Orleans.Runtime.SiloAddress[]) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "GetRuntimeStatistics";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/GetRuntimeStatistics";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.SiloAddress[])value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.Runtime.SiloRuntimeStatistics[]> InvokeInner() => target.GetRuntimeStatistics(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "3CFF788C")]
    public sealed class Invokable_IManagementGrain_GrainReference_3CFF788C : global::Orleans.Runtime.TaskRequest<global::Orleans.Runtime.SimpleGrainStatistic[]>
    {
        public global::Orleans.Runtime.SiloAddress[] arg0;
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "GetSimpleGrainStatistics", null, new[] { typeof(global::Orleans.Runtime.SiloAddress[]) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "GetSimpleGrainStatistics";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/GetSimpleGrainStatistics";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.SiloAddress[])value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.Runtime.SimpleGrainStatistic[]> InvokeInner() => target.GetSimpleGrainStatistics(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "ACCE9D6A")]
    public sealed class Invokable_IManagementGrain_GrainReference_ACCE9D6A : global::Orleans.Runtime.TaskRequest<global::Orleans.Runtime.SimpleGrainStatistic[]>
    {
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "GetSimpleGrainStatistics", null, null);
        public override string GetMethodName() => "GetSimpleGrainStatistics";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/GetSimpleGrainStatistics";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.Runtime.SimpleGrainStatistic[]> InvokeInner() => target.GetSimpleGrainStatistics();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "0A1C0D82")]
    public sealed class Invokable_IManagementGrain_GrainReference_0A1C0D82 : global::Orleans.Runtime.TaskRequest<global::Orleans.Runtime.DetailedGrainStatistic[]>
    {
        public string[] arg0;
        public global::Orleans.Runtime.SiloAddress[] arg1;
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "GetDetailedGrainStatistics", null, new[] { typeof(string[]), typeof(global::Orleans.Runtime.SiloAddress[]) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "GetDetailedGrainStatistics";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/GetDetailedGrainStatistics";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                case 1:
                    return arg1;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (string[])value;
                    return;
                case 1:
                    arg1 = (global::Orleans.Runtime.SiloAddress[])value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.Runtime.DetailedGrainStatistic[]> InvokeInner() => target.GetDetailedGrainStatistics(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "AEDE93F6")]
    public sealed class Invokable_IManagementGrain_GrainReference_AEDE93F6 : global::Orleans.Runtime.TaskRequest<int>
    {
        public global::Orleans.Runtime.GrainReference arg0;
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "GetGrainActivationCount", null, new[] { typeof(global::Orleans.Runtime.GrainReference) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "GetGrainActivationCount";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/GetGrainActivationCount";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.GrainReference)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<int> InvokeInner() => target.GetGrainActivationCount(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "D7365B43")]
    public sealed class Invokable_IManagementGrain_GrainReference_D7365B43 : global::Orleans.Runtime.TaskRequest<int>
    {
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "GetTotalActivationCount", null, null);
        public override string GetMethodName() => "GetTotalActivationCount";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/GetTotalActivationCount";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task<int> InvokeInner() => target.GetTotalActivationCount();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "F67965CC")]
    public sealed class Invokable_IManagementGrain_GrainReference_F67965CC_1<T> : global::Orleans.Runtime.TaskRequest<global::System.Object[]> where T : global::Orleans.Providers.IControllable
    {
        public global::System.String arg0;
        public global::System.Int32 arg1;
        public global::System.Object arg2;
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "SendControlCommandToProvider", new[] { typeof(T) }, new[] { typeof(global::System.String), typeof(global::System.Int32), typeof(global::System.Object) });
        public override int GetArgumentCount() => 3;
        public override string GetMethodName() => "SendControlCommandToProvider<T>";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/SendControlCommandToProvider<T>";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                case 1:
                    return arg1;
                case 2:
                    return arg2;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::System.String)value;
                    return;
                case 1:
                    arg1 = (global::System.Int32)value;
                    return;
                case 2:
                    arg2 = (global::System.Object)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::System.Object[]> InvokeInner() => target.SendControlCommandToProvider<T>(arg0, arg1, arg2);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "317D82B6")]
    public sealed class Invokable_IManagementGrain_GrainReference_317D82B6 : global::Orleans.Runtime.Request<global::Orleans.Runtime.SiloAddress>
    {
        public global::Orleans.Runtime.IAddressable arg0;
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "GetActivationAddress", null, new[] { typeof(global::Orleans.Runtime.IAddressable) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "GetActivationAddress";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/GetActivationAddress";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.IAddressable)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.ValueTask<global::Orleans.Runtime.SiloAddress> InvokeInner() => target.GetActivationAddress(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "3DB7923B")]
    public sealed class Invokable_IManagementGrain_GrainReference_3DB7923B : global::Orleans.Runtime.Request<global::System.Collections.Generic.List<global::Orleans.Runtime.GrainId>>
    {
        public global::Orleans.Runtime.GrainType arg0;
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "GetActiveGrains", null, new[] { typeof(global::Orleans.Runtime.GrainType) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "GetActiveGrains";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/GetActiveGrains";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.GrainType)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.ValueTask<global::System.Collections.Generic.List<global::Orleans.Runtime.GrainId>> InvokeInner() => target.GetActiveGrains(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "0F06E027")]
    public sealed class Invokable_IManagementGrain_GrainReference_0F06E027 : global::Orleans.Runtime.TaskRequest<global::System.Collections.Generic.List<global::Orleans.Runtime.GrainCallFrequency>>
    {
        public global::Orleans.Runtime.SiloAddress[] arg0;
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "GetGrainCallFrequencies", null, new[] { typeof(global::Orleans.Runtime.SiloAddress[]) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "GetGrainCallFrequencies";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/GetGrainCallFrequencies";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.SiloAddress[])value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.Runtime.GrainCallFrequency>> InvokeInner() => target.GetGrainCallFrequencies(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IManagementGrain), "54FE0FEC")]
    public sealed class Invokable_IManagementGrain_GrainReference_54FE0FEC : global::Orleans.Runtime.Request
    {
        public global::Orleans.Runtime.SiloAddress[] arg0;
        global::Orleans.Runtime.IManagementGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IManagementGrain), "ResetGrainCallFrequencies", null, new[] { typeof(global::Orleans.Runtime.SiloAddress[]) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "ResetGrainCallFrequencies";
        public override string GetInterfaceName() => "Orleans.Runtime.IManagementGrain";
        public override string GetActivityName() => "IManagementGrain/ResetGrainCallFrequencies";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IManagementGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IManagementGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.SiloAddress[])value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.ValueTask InvokeInner() => target.ResetGrainCallFrequencies(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IManagementGrain : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IManagementGrain
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress> _copier0;
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<string> _copier1;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Runtime.GrainReference> _copier2;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Runtime.IAddressable> _copier3;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy> _copier4;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy> _copier5;
        public Proxy_IManagementGrain(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress>>(this, CodecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<string>>(this, CodecProvider);
            _copier2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Runtime.GrainReference>>(this, CodecProvider);
            _copier3 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Runtime.IAddressable>>(this, CodecProvider);
            _copier4 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(this, CodecProvider);
            _copier5 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy>>(this, CodecProvider);
        }

        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloStatus>> global::Orleans.Runtime.IManagementGrain.GetHosts(bool arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_4C0864C2();
            request.arg0 = arg0;
            return base.InvokeAsync<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloStatus>>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.MembershipEntry[]> global::Orleans.Runtime.IManagementGrain.GetDetailedHosts(bool arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_CC6CCBC3();
            request.arg0 = arg0;
            return base.InvokeAsync<global::Orleans.MembershipEntry[]>(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.IManagementGrain.ForceGarbageCollection(global::Orleans.Runtime.SiloAddress[] arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_5922EB76();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.IManagementGrain.ForceActivationCollection(global::Orleans.Runtime.SiloAddress[] arg0, global::System.TimeSpan arg1)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_329F9A1B();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            request.arg1 = arg1;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.IManagementGrain.ForceActivationCollection(global::System.TimeSpan arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54E6D1D1();
            request.arg0 = arg0;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.IManagementGrain.ForceRuntimeStatisticsCollection(global::Orleans.Runtime.SiloAddress[] arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_B761B345();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.Runtime.SiloRuntimeStatistics[]> global::Orleans.Runtime.IManagementGrain.GetRuntimeStatistics(global::Orleans.Runtime.SiloAddress[] arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_2D761B36();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            return base.InvokeAsync<global::Orleans.Runtime.SiloRuntimeStatistics[]>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.Runtime.SimpleGrainStatistic[]> global::Orleans.Runtime.IManagementGrain.GetSimpleGrainStatistics(global::Orleans.Runtime.SiloAddress[] arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3CFF788C();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            return base.InvokeAsync<global::Orleans.Runtime.SimpleGrainStatistic[]>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.Runtime.SimpleGrainStatistic[]> global::Orleans.Runtime.IManagementGrain.GetSimpleGrainStatistics()
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_ACCE9D6A();
            return base.InvokeAsync<global::Orleans.Runtime.SimpleGrainStatistic[]>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.Runtime.DetailedGrainStatistic[]> global::Orleans.Runtime.IManagementGrain.GetDetailedGrainStatistics(string[] arg0, global::Orleans.Runtime.SiloAddress[] arg1)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0A1C0D82();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier1.DeepCopy(arg0, copyContext);
            request.arg1 = _copier0.DeepCopy(arg1, copyContext);
            return base.InvokeAsync<global::Orleans.Runtime.DetailedGrainStatistic[]>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<int> global::Orleans.Runtime.IManagementGrain.GetGrainActivationCount(global::Orleans.Runtime.GrainReference arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_AEDE93F6();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier2.DeepCopy(arg0, copyContext);
            return base.InvokeAsync<int>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<int> global::Orleans.Runtime.IManagementGrain.GetTotalActivationCount()
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_D7365B43();
            return base.InvokeAsync<int>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::System.Object[]> global::Orleans.Runtime.IManagementGrain.SendControlCommandToProvider<T>(global::System.String arg0, global::System.Int32 arg1, global::System.Object arg2)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_F67965CC_1<T>();
            request.arg0 = arg0;
            request.arg1 = arg1;
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg2 = global::Orleans.Serialization.Codecs.ObjectCopier.DeepCopy(arg2, copyContext);
            return base.InvokeAsync<global::System.Object[]>(request).AsTask();
        }

        global::System.Threading.Tasks.ValueTask<global::Orleans.Runtime.SiloAddress> global::Orleans.Runtime.IManagementGrain.GetActivationAddress(global::Orleans.Runtime.IAddressable arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_317D82B6();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier3.DeepCopy(arg0, copyContext);
            return base.InvokeAsync<global::Orleans.Runtime.SiloAddress>(request);
        }

        global::System.Threading.Tasks.ValueTask<global::System.Collections.Generic.List<global::Orleans.Runtime.GrainId>> global::Orleans.Runtime.IManagementGrain.GetActiveGrains(global::Orleans.Runtime.GrainType arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3DB7923B();
            request.arg0 = arg0;
            return base.InvokeAsync<global::System.Collections.Generic.List<global::Orleans.Runtime.GrainId>>(request);
        }

        global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.Runtime.GrainCallFrequency>> global::Orleans.Runtime.IManagementGrain.GetGrainCallFrequencies(global::Orleans.Runtime.SiloAddress[] arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0F06E027();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            return base.InvokeAsync<global::System.Collections.Generic.List<global::Orleans.Runtime.GrainCallFrequency>>(request).AsTask();
        }

        global::System.Threading.Tasks.ValueTask global::Orleans.Runtime.IManagementGrain.ResetGrainCallFrequencies(global::Orleans.Runtime.SiloAddress[] arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54FE0FEC();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            return base.InvokeAsync(request);
        }

        global::System.Threading.Tasks.Task global::Orleans.IVersionManager.SetCompatibilityStrategy(global::Orleans.Versions.Compatibility.CompatibilityStrategy arg0)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_8F5C15A9();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier4.DeepCopy(arg0, copyContext);
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.IVersionManager.SetSelectorStrategy(global::Orleans.Versions.Selector.VersionSelectorStrategy arg0)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_4AAEAFCE();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier5.DeepCopy(arg0, copyContext);
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.IVersionManager.SetCompatibilityStrategy(global::Orleans.Runtime.GrainInterfaceType arg0, global::Orleans.Versions.Compatibility.CompatibilityStrategy arg1)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_C01C4EE8();
            request.arg0 = arg0;
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg1 = _copier4.DeepCopy(arg1, copyContext);
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.IVersionManager.SetSelectorStrategy(global::Orleans.Runtime.GrainInterfaceType arg0, global::Orleans.Versions.Selector.VersionSelectorStrategy arg1)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_90AB9D5E();
            request.arg0 = arg0;
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg1 = _copier5.DeepCopy(arg1, copyContext);
            return base.InvokeAsync(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IMembershipService), "22A02D46")]
    internal sealed class Invokable_IMembershipService_GrainReference_22A02D46 : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.Runtime.MembershipTableSnapshot arg0;
        global::Orleans.Runtime.IMembershipService target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IMembershipService), "MembershipChangeNotification", null, new[] { typeof(global::Orleans.Runtime.MembershipTableSnapshot) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "MembershipChangeNotification";
        public override string GetInterfaceName() => "Orleans.Runtime.IMembershipService";
        public override string GetActivityName() => "IMembershipService/MembershipChangeNotification";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IMembershipService);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IMembershipService>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.MembershipTableSnapshot)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.MembershipChangeNotification(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IMembershipService), "39AB7071")]
    internal sealed class Invokable_IMembershipService_GrainReference_39AB7071 : global::Orleans.Runtime.TaskRequest
    {
        public int arg0;
        global::Orleans.Runtime.IMembershipService target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IMembershipService), "Ping", null, new[] { typeof(int) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "Ping";
        public override string GetInterfaceName() => "Orleans.Runtime.IMembershipService";
        public override string GetActivityName() => "IMembershipService/Ping";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IMembershipService);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IMembershipService>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (int)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.Ping(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IMembershipService), "0F85FAAF")]
    internal sealed class Invokable_IMembershipService_GrainReference_0F85FAAF : global::Orleans.Runtime.TaskRequest<global::Orleans.Runtime.IndirectProbeResponse>
    {
        public global::Orleans.Runtime.SiloAddress arg0;
        public global::System.TimeSpan arg1;
        public int arg2;
        global::Orleans.Runtime.IMembershipService target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IMembershipService), "ProbeIndirectly", null, new[] { typeof(global::Orleans.Runtime.SiloAddress), typeof(global::System.TimeSpan), typeof(int) });
        public override int GetArgumentCount() => 3;
        public override string GetMethodName() => "ProbeIndirectly";
        public override string GetInterfaceName() => "Orleans.Runtime.IMembershipService";
        public override string GetActivityName() => "IMembershipService/ProbeIndirectly";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IMembershipService);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IMembershipService>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                case 1:
                    return arg1;
                case 2:
                    return arg2;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.SiloAddress)value;
                    return;
                case 1:
                    arg1 = (global::System.TimeSpan)value;
                    return;
                case 2:
                    arg2 = (int)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.Runtime.IndirectProbeResponse> InvokeInner() => target.ProbeIndirectly(arg0, arg1, arg2);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IMembershipService : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IMembershipService
    {
        public Proxy_IMembershipService(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.IMembershipService.MembershipChangeNotification(global::Orleans.Runtime.MembershipTableSnapshot arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_22A02D46();
            request.arg0 = arg0;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.IMembershipService.Ping(int arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_39AB7071();
            request.arg0 = arg0;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.Runtime.IndirectProbeResponse> global::Orleans.Runtime.IMembershipService.ProbeIndirectly(global::Orleans.Runtime.SiloAddress arg0, global::System.TimeSpan arg1, int arg2)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_0F85FAAF();
            request.arg0 = arg0;
            request.arg1 = arg1;
            request.arg2 = arg2;
            return base.InvokeAsync<global::Orleans.Runtime.IndirectProbeResponse>(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_InvalidSchedulingContextException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.InvalidSchedulingContextException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.InvalidSchedulingContextException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.InvalidSchedulingContextException> _activator;
        public Codec_InvalidSchedulingContextException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.InvalidSchedulingContextException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.InvalidSchedulingContextException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.InvalidSchedulingContextException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.InvalidSchedulingContextException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.InvalidSchedulingContextException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.InvalidSchedulingContextException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_InvalidSchedulingContextException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.InvalidSchedulingContextException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_InvalidSchedulingContextException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_MigrationContext : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.MigrationContext>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.MigrationContext);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.MigrationContext> _activator;
        private readonly global::System.Type _type0 = typeof(global::Orleans.Serialization.Buffers.PooledBuffer);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Buffers.PooledBuffer> _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Generic.Dictionary<string, (int Offset, int Length)>);
        private readonly global::Orleans.Serialization.Codecs.DictionaryCodec<string, (int Offset, int Length)> _codec1;
        private static readonly global::System.Func<global::Orleans.Runtime.MigrationContext, global::Orleans.Serialization.Buffers.PooledBuffer> getField0 = (global::System.Func<global::Orleans.Runtime.MigrationContext, global::Orleans.Serialization.Buffers.PooledBuffer>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.MigrationContext), "_buffer");
        private static readonly global::System.Action<global::Orleans.Runtime.MigrationContext, global::Orleans.Serialization.Buffers.PooledBuffer> setField0 = (global::System.Action<global::Orleans.Runtime.MigrationContext, global::Orleans.Serialization.Buffers.PooledBuffer>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.MigrationContext), "_buffer");
        private static readonly global::System.Func<global::Orleans.Runtime.MigrationContext, global::System.Collections.Generic.Dictionary<string, (int Offset, int Length)>> getField1 = (global::System.Func<global::Orleans.Runtime.MigrationContext, global::System.Collections.Generic.Dictionary<string, (int Offset, int Length)>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.MigrationContext), "_indices");
        private static readonly global::System.Action<global::Orleans.Runtime.MigrationContext, global::System.Collections.Generic.Dictionary<string, (int Offset, int Length)>> setField1 = (global::System.Action<global::Orleans.Runtime.MigrationContext, global::System.Collections.Generic.Dictionary<string, (int Offset, int Length)>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.MigrationContext), "_indices");
        private readonly global::Orleans.Runtime.MigrationContext.SerializationHooks _hook0;
        public Codec_MigrationContext(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.MigrationContext> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Runtime.MigrationContext.SerializationHooks _hook0)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Buffers.PooledBuffer>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCodec<string, (int Offset, int Length)>>(this, codecProvider);
            this._hook0 = OrleansGeneratedCodeHelper.UnwrapService(this, _hook0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.MigrationContext instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, getField1(instance));
            _codec0.WriteField(ref writer, 1U, _type0, getField0(instance));
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.MigrationContext instance)
        {
            _hook0.OnDeserializing(instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField1(instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField0(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.MigrationContext @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.MigrationContext ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.MigrationContext, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Metadata.MajorMinorVersion);
        private readonly OrleansCodeGen.Orleans.Metadata.Codec_MajorMinorVersion _codec0;
        public Codec_Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Metadata.Codec_MajorMinorVersion>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ClusterManifestUpdate : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.ClusterManifestUpdate>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Runtime.ClusterManifestUpdate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.ClusterManifestUpdate);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.ClusterManifestUpdate> _activator;
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Metadata.GrainManifest>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Metadata.GrainManifest>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Metadata.MajorMinorVersion);
        private readonly OrleansCodeGen.Orleans.Metadata.Codec_MajorMinorVersion _codec1;
        private static readonly global::System.Action<global::Orleans.Runtime.ClusterManifestUpdate, bool> setField0 = (global::System.Action<global::Orleans.Runtime.ClusterManifestUpdate, bool>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.ClusterManifestUpdate), "<IncludesAllActiveServers>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.ClusterManifestUpdate, global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Metadata.GrainManifest>> setField1 = (global::System.Action<global::Orleans.Runtime.ClusterManifestUpdate, global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Metadata.GrainManifest>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.ClusterManifestUpdate), "<SiloManifests>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.ClusterManifestUpdate, global::Orleans.Metadata.MajorMinorVersion> setField2 = (global::System.Action<global::Orleans.Runtime.ClusterManifestUpdate, global::Orleans.Metadata.MajorMinorVersion>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.ClusterManifestUpdate), "<Version>k__BackingField");
        public Codec_ClusterManifestUpdate(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.ClusterManifestUpdate> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Metadata.GrainManifest>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Metadata.Codec_MajorMinorVersion>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.ClusterManifestUpdate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, instance.Version);
            _codec0.WriteField(ref writer, 1U, _type0, instance.SiloManifests);
            global::Orleans.Serialization.Codecs.BoolCodec.WriteField(ref writer, 1U, instance.IncludesAllActiveServers);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.ClusterManifestUpdate instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField2(instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.BoolCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.ClusterManifestUpdate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Runtime.ClusterManifestUpdate))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.ClusterManifestUpdate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.ClusterManifestUpdate, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Runtime.ClusterManifestUpdate>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ClusterManifestUpdate : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Runtime.ClusterManifestUpdate>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Runtime.ClusterManifestUpdate>
    {
        private static readonly global::System.Action<global::Orleans.Runtime.ClusterManifestUpdate, bool> setField0 = (global::System.Action<global::Orleans.Runtime.ClusterManifestUpdate, bool>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.ClusterManifestUpdate), "<IncludesAllActiveServers>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.ClusterManifestUpdate, global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Metadata.GrainManifest>> setField1 = (global::System.Action<global::Orleans.Runtime.ClusterManifestUpdate, global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Metadata.GrainManifest>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.ClusterManifestUpdate), "<SiloManifests>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.ClusterManifestUpdate, global::Orleans.Metadata.MajorMinorVersion> setField2 = (global::System.Action<global::Orleans.Runtime.ClusterManifestUpdate, global::Orleans.Metadata.MajorMinorVersion>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.ClusterManifestUpdate), "<Version>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.ClusterManifestUpdate DeepCopy(global::Orleans.Runtime.ClusterManifestUpdate original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return original is null || original.GetType() == typeof(global::Orleans.Runtime.ClusterManifestUpdate) ? original : context.DeepCopy(original);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Runtime.ClusterManifestUpdate input, global::Orleans.Runtime.ClusterManifestUpdate output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            setField2(output, input.Version);
            setField1(output, input.SiloManifests);
            setField0(output, input.IncludesAllActiveServers);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_CorrelationId : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.CorrelationId>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Runtime.CorrelationId>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.CorrelationId);
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Runtime.CorrelationId, long> getField0 = (global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Runtime.CorrelationId, long>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueGetter(typeof(global::Orleans.Runtime.CorrelationId), "id");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.CorrelationId, long> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.CorrelationId, long>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Runtime.CorrelationId), "id");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Runtime.CorrelationId instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 0U, getField0(ref instance));
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Runtime.CorrelationId instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(ref instance, global::Orleans.Serialization.Codecs.Int64Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.CorrelationId @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.CorrelationId ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Runtime.CorrelationId);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_RejectionResponse : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.RejectionResponse>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.RejectionResponse);
        private readonly global::System.Type _type0 = typeof(global::System.Exception);
        private readonly global::Orleans.Serialization.ExceptionCodec _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.Message.RejectionTypes);
        private readonly OrleansCodeGen.Orleans.Runtime.Message.Codec_RejectionTypes _codec1;
        private static readonly global::System.Action<global::Orleans.Runtime.RejectionResponse, global::System.Exception> setField0 = (global::System.Action<global::Orleans.Runtime.RejectionResponse, global::System.Exception>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.RejectionResponse), "<Exception>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.RejectionResponse, string> setField1 = (global::System.Action<global::Orleans.Runtime.RejectionResponse, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.RejectionResponse), "<RejectionInfo>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.RejectionResponse, global::Orleans.Runtime.Message.RejectionTypes> setField2 = (global::System.Action<global::Orleans.Runtime.RejectionResponse, global::Orleans.Runtime.Message.RejectionTypes>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.RejectionResponse), "<RejectionType>k__BackingField");
        public Codec_RejectionResponse(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.ExceptionCodec>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Message.Codec_RejectionTypes>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.RejectionResponse instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.RejectionInfo);
            _codec1.WriteField(ref writer, 1U, _type1, instance.RejectionType);
            _codec0.WriteField(ref writer, 1U, _type0, instance.Exception);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.RejectionResponse instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField2(instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField0(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.RejectionResponse @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.RejectionResponse ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.RejectionResponse, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.RejectionResponse();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_RejectionResponse : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.RejectionResponse>
    {
        public global::Orleans.Runtime.RejectionResponse Create() => new global::Orleans.Runtime.RejectionResponse();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_StatusResponse : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.StatusResponse>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.StatusResponse);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.StatusResponse> _activator;
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.List<string>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<string> _codec0;
        private static readonly global::System.Func<global::Orleans.Runtime.StatusResponse, uint> getField0 = (global::System.Func<global::Orleans.Runtime.StatusResponse, uint>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.StatusResponse), "_statusFlags");
        private static readonly global::System.Action<global::Orleans.Runtime.StatusResponse, uint> setField0 = (global::System.Action<global::Orleans.Runtime.StatusResponse, uint>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.StatusResponse), "_statusFlags");
        private static readonly global::System.Action<global::Orleans.Runtime.StatusResponse, global::System.Collections.Generic.List<string>> setField1 = (global::System.Action<global::Orleans.Runtime.StatusResponse, global::System.Collections.Generic.List<string>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.StatusResponse), "<Diagnostics>k__BackingField");
        public Codec_StatusResponse(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.StatusResponse> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<string>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.StatusResponse instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.UInt32Codec.WriteField(ref writer, 0U, getField0(instance));
            _codec0.WriteField(ref writer, 1U, _type0, instance.Diagnostics);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.StatusResponse instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.UInt32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.StatusResponse @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.StatusResponse ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.StatusResponse, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_GrainCancellationTokenSurrogate : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GrainCancellationTokenSurrogate>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Runtime.GrainCancellationTokenSurrogate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.GrainCancellationTokenSurrogate);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Runtime.GrainCancellationTokenSurrogate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.BoolCodec.WriteField(ref writer, 0U, instance.IsCancellationRequested);
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 1U, instance.TokenId);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Runtime.GrainCancellationTokenSurrogate instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.IsCancellationRequested = global::Orleans.Serialization.Codecs.BoolCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.TokenId = global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.GrainCancellationTokenSurrogate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.GrainCancellationTokenSurrogate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Runtime.GrainCancellationTokenSurrogate);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_MembershipTableSnapshot : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.MembershipTableSnapshot>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.MembershipTableSnapshot);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.MembershipTableSnapshot> _activator;
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.MembershipEntry>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.MembershipEntry>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.MembershipVersion);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_MembershipVersion _codec1;
        private static readonly global::System.Action<global::Orleans.Runtime.MembershipTableSnapshot, global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.MembershipEntry>> setField0 = (global::System.Action<global::Orleans.Runtime.MembershipTableSnapshot, global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.MembershipEntry>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.MembershipTableSnapshot), "<Entries>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.MembershipTableSnapshot, global::Orleans.Runtime.MembershipVersion> setField1 = (global::System.Action<global::Orleans.Runtime.MembershipTableSnapshot, global::Orleans.Runtime.MembershipVersion>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.MembershipTableSnapshot), "<Version>k__BackingField");
        public Codec_MembershipTableSnapshot(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.MembershipTableSnapshot> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.MembershipEntry>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_MembershipVersion>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.MembershipTableSnapshot instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, instance.Version);
            _codec0.WriteField(ref writer, 1U, _type0, instance.Entries);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.MembershipTableSnapshot instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField1(instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField0(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.MembershipTableSnapshot @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.MembershipTableSnapshot ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.MembershipTableSnapshot, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_SingleRange : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SingleRange>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.SingleRange);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.SingleRange> _activator;
        private static readonly global::System.Func<global::Orleans.Runtime.SingleRange, uint> getField0 = (global::System.Func<global::Orleans.Runtime.SingleRange, uint>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.SingleRange), "begin");
        private static readonly global::System.Action<global::Orleans.Runtime.SingleRange, uint> setField0 = (global::System.Action<global::Orleans.Runtime.SingleRange, uint>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SingleRange), "begin");
        private static readonly global::System.Func<global::Orleans.Runtime.SingleRange, uint> getField1 = (global::System.Func<global::Orleans.Runtime.SingleRange, uint>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.SingleRange), "end");
        private static readonly global::System.Action<global::Orleans.Runtime.SingleRange, uint> setField1 = (global::System.Action<global::Orleans.Runtime.SingleRange, uint>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SingleRange), "end");
        public Codec_SingleRange(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.SingleRange> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.SingleRange instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.UInt32Codec.WriteField(ref writer, 0U, getField0(instance));
            global::Orleans.Serialization.Codecs.UInt32Codec.WriteField(ref writer, 1U, getField1(instance));
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.SingleRange instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.UInt32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.UInt32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.SingleRange @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.SingleRange ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.SingleRange, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_GeneralMultiRange : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GeneralMultiRange>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.GeneralMultiRange);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.GeneralMultiRange> _activator;
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.List<global::Orleans.Runtime.SingleRange>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Runtime.SingleRange> _codec0;
        private static readonly global::System.Func<global::Orleans.Runtime.GeneralMultiRange, global::System.Collections.Generic.List<global::Orleans.Runtime.SingleRange>> getField0 = (global::System.Func<global::Orleans.Runtime.GeneralMultiRange, global::System.Collections.Generic.List<global::Orleans.Runtime.SingleRange>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.GeneralMultiRange), "ranges");
        private static readonly global::System.Action<global::Orleans.Runtime.GeneralMultiRange, global::System.Collections.Generic.List<global::Orleans.Runtime.SingleRange>> setField0 = (global::System.Action<global::Orleans.Runtime.GeneralMultiRange, global::System.Collections.Generic.List<global::Orleans.Runtime.SingleRange>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.GeneralMultiRange), "ranges");
        private static readonly global::System.Func<global::Orleans.Runtime.GeneralMultiRange, long> getField1 = (global::System.Func<global::Orleans.Runtime.GeneralMultiRange, long>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.GeneralMultiRange), "rangeSize");
        private static readonly global::System.Action<global::Orleans.Runtime.GeneralMultiRange, long> setField1 = (global::System.Action<global::Orleans.Runtime.GeneralMultiRange, long>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.GeneralMultiRange), "rangeSize");
        public Codec_GeneralMultiRange(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.GeneralMultiRange> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Runtime.SingleRange>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.GeneralMultiRange instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, getField0(instance));
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 1U, getField1(instance));
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.GeneralMultiRange instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.Int64Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.GeneralMultiRange @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.GeneralMultiRange ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.GeneralMultiRange, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_SiloStatus : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloStatus>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.SiloStatus);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.SiloStatus @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, fieldIdDelta, expectedType, (int)@value, _codecFieldType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.SiloStatus ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            return (global::Orleans.Runtime.SiloStatus)global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_SiloRuntimeStatistics : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloRuntimeStatistics>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.SiloRuntimeStatistics);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.SiloRuntimeStatistics> _activator;
        private readonly global::System.Type _type0 = typeof(float? );
        private readonly global::Orleans.Serialization.Codecs.NullableCodec<float> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Statistics.EnvironmentStatistics);
        private readonly OrleansCodeGen.Orleans.Statistics.Codec_EnvironmentStatistics _codec1;
        private readonly global::System.Type _type2 = typeof(long? );
        private readonly global::Orleans.Serialization.Codecs.NullableCodec<long> _codec2;
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, int> setField0 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<ActivationCount>k__BackingField");
        private static readonly global::System.Func<global::Orleans.Runtime.SiloRuntimeStatistics, float?> getField1 = (global::System.Func<global::Orleans.Runtime.SiloRuntimeStatistics, float?>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<AvailableMemory>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, float?> setField1 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, float?>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<AvailableMemory>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, long> setField2 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, long>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<ClientCount>k__BackingField");
        private static readonly global::System.Func<global::Orleans.Runtime.SiloRuntimeStatistics, float?> getField3 = (global::System.Func<global::Orleans.Runtime.SiloRuntimeStatistics, float?>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<CpuUsage>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, float?> setField3 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, float?>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<CpuUsage>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.DateTime> setField4 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::System.DateTime>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<DateTime>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::Orleans.Statistics.EnvironmentStatistics> setField5 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, global::Orleans.Statistics.EnvironmentStatistics>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<EnvironmentStatistics>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, bool> setField6 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, bool>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<IsOverloaded>k__BackingField");
        private static readonly global::System.Func<global::Orleans.Runtime.SiloRuntimeStatistics, long?> getField7 = (global::System.Func<global::Orleans.Runtime.SiloRuntimeStatistics, long?>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<MemoryUsage>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, long?> setField7 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, long?>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<MemoryUsage>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, long> setField8 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, long>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<ReceivedMessages>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, int> setField9 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<RecentlyUsedActivationCount>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, long> setField10 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, long>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<SentMessages>k__BackingField");
        private static readonly global::System.Func<global::Orleans.Runtime.SiloRuntimeStatistics, long?> getField11 = (global::System.Func<global::Orleans.Runtime.SiloRuntimeStatistics, long?>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<TotalPhysicalMemory>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, long?> setField11 = (global::System.Action<global::Orleans.Runtime.SiloRuntimeStatistics, long?>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SiloRuntimeStatistics), "<TotalPhysicalMemory>k__BackingField");
        public Codec_SiloRuntimeStatistics(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.SiloRuntimeStatistics> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.NullableCodec<float>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Statistics.Codec_EnvironmentStatistics>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.NullableCodec<long>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.SiloRuntimeStatistics instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.ActivationCount);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.RecentlyUsedActivationCount);
            _codec0.WriteField(ref writer, 1U, _type0, getField3(instance));
            _codec0.WriteField(ref writer, 1U, _type0, getField1(instance));
            _codec2.WriteField(ref writer, 1U, _type2, getField7(instance));
            _codec2.WriteField(ref writer, 1U, _type2, getField11(instance));
            global::Orleans.Serialization.Codecs.BoolCodec.WriteField(ref writer, 1U, instance.IsOverloaded);
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 1U, instance.ClientCount);
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 1U, instance.ReceivedMessages);
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 1U, instance.SentMessages);
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 1U, instance.DateTime);
            _codec1.WriteField(ref writer, 1U, _type1, instance.EnvironmentStatistics);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.SiloRuntimeStatistics instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField9(instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField3(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    setField1(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 4U)
                {
                    setField7(instance, _codec2.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 5U)
                {
                    setField11(instance, _codec2.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 6U)
                {
                    setField6(instance, global::Orleans.Serialization.Codecs.BoolCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 7U)
                {
                    setField2(instance, global::Orleans.Serialization.Codecs.Int64Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 8U)
                {
                    setField8(instance, global::Orleans.Serialization.Codecs.Int64Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 9U)
                {
                    setField10(instance, global::Orleans.Serialization.Codecs.Int64Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 10U)
                {
                    setField4(instance, global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 11U)
                {
                    setField5(instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.SiloRuntimeStatistics @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.SiloRuntimeStatistics ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.SiloRuntimeStatistics, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_SimpleGrainStatistic : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SimpleGrainStatistic>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.SimpleGrainStatistic);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.SiloAddress);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress> _codec0;
        private static readonly global::System.Action<global::Orleans.Runtime.SimpleGrainStatistic, int> setField0 = (global::System.Action<global::Orleans.Runtime.SimpleGrainStatistic, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SimpleGrainStatistic), "<ActivationCount>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.SimpleGrainStatistic, string> setField1 = (global::System.Action<global::Orleans.Runtime.SimpleGrainStatistic, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SimpleGrainStatistic), "<GrainType>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.SimpleGrainStatistic, global::Orleans.Runtime.SiloAddress> setField2 = (global::System.Action<global::Orleans.Runtime.SimpleGrainStatistic, global::Orleans.Runtime.SiloAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.SimpleGrainStatistic), "<SiloAddress>k__BackingField");
        public Codec_SimpleGrainStatistic(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.SimpleGrainStatistic instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.GrainType);
            _codec0.WriteField(ref writer, 1U, _type0, instance.SiloAddress);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.ActivationCount);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.SimpleGrainStatistic instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField2(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.SimpleGrainStatistic @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.SimpleGrainStatistic ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.SimpleGrainStatistic, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.SimpleGrainStatistic();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_SimpleGrainStatistic : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.SimpleGrainStatistic>
    {
        public global::Orleans.Runtime.SimpleGrainStatistic Create() => new global::Orleans.Runtime.SimpleGrainStatistic();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_DetailedGrainStatistic : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.DetailedGrainStatistic>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.DetailedGrainStatistic);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainId _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.SiloAddress);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress> _codec1;
        private static readonly global::System.Action<global::Orleans.Runtime.DetailedGrainStatistic, global::Orleans.Runtime.GrainId> setField0 = (global::System.Action<global::Orleans.Runtime.DetailedGrainStatistic, global::Orleans.Runtime.GrainId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.DetailedGrainStatistic), "<GrainId>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.DetailedGrainStatistic, string> setField1 = (global::System.Action<global::Orleans.Runtime.DetailedGrainStatistic, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.DetailedGrainStatistic), "<GrainType>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.DetailedGrainStatistic, global::Orleans.Runtime.SiloAddress> setField2 = (global::System.Action<global::Orleans.Runtime.DetailedGrainStatistic, global::Orleans.Runtime.SiloAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.DetailedGrainStatistic), "<SiloAddress>k__BackingField");
        public Codec_DetailedGrainStatistic(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainId>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.DetailedGrainStatistic instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.GrainType);
            _codec1.WriteField(ref writer, 1U, _type1, instance.SiloAddress);
            _codec0.WriteField(ref writer, 1U, _type0, instance.GrainId);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.DetailedGrainStatistic instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField2(instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField0(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.DetailedGrainStatistic @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.DetailedGrainStatistic ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.DetailedGrainStatistic, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.DetailedGrainStatistic();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_DetailedGrainStatistic : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.DetailedGrainStatistic>
    {
        public global::Orleans.Runtime.DetailedGrainStatistic Create() => new global::Orleans.Runtime.DetailedGrainStatistic();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_DetailedGrainReport : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.DetailedGrainReport>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.DetailedGrainReport);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainId _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.GrainAddress);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainAddress _codec1;
        private readonly global::System.Type _type2 = typeof(global::Orleans.Runtime.SiloAddress);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress> _codec2;
        private static readonly global::System.Action<global::Orleans.Runtime.DetailedGrainReport, global::Orleans.Runtime.GrainId> setField0 = (global::System.Action<global::Orleans.Runtime.DetailedGrainReport, global::Orleans.Runtime.GrainId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.DetailedGrainReport), "<Grain>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.DetailedGrainReport, string> setField1 = (global::System.Action<global::Orleans.Runtime.DetailedGrainReport, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.DetailedGrainReport), "<GrainClassTypeName>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.DetailedGrainReport, string> setField2 = (global::System.Action<global::Orleans.Runtime.DetailedGrainReport, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.DetailedGrainReport), "<LocalActivation>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.DetailedGrainReport, global::Orleans.Runtime.GrainAddress> setField3 = (global::System.Action<global::Orleans.Runtime.DetailedGrainReport, global::Orleans.Runtime.GrainAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.DetailedGrainReport), "<LocalCacheActivationAddress>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.DetailedGrainReport, global::Orleans.Runtime.GrainAddress> setField4 = (global::System.Action<global::Orleans.Runtime.DetailedGrainReport, global::Orleans.Runtime.GrainAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.DetailedGrainReport), "<LocalDirectoryActivationAddress>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.DetailedGrainReport, global::Orleans.Runtime.SiloAddress> setField5 = (global::System.Action<global::Orleans.Runtime.DetailedGrainReport, global::Orleans.Runtime.SiloAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.DetailedGrainReport), "<PrimaryForGrain>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.DetailedGrainReport, global::Orleans.Runtime.SiloAddress> setField6 = (global::System.Action<global::Orleans.Runtime.DetailedGrainReport, global::Orleans.Runtime.SiloAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.DetailedGrainReport), "<SiloAddress>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.DetailedGrainReport, string> setField7 = (global::System.Action<global::Orleans.Runtime.DetailedGrainReport, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.DetailedGrainReport), "<SiloName>k__BackingField");
        public Codec_DetailedGrainReport(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainId>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainAddress>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.DetailedGrainReport instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Grain);
            _codec2.WriteField(ref writer, 1U, _type2, instance.SiloAddress);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.SiloName);
            _codec1.WriteField(ref writer, 1U, _type1, instance.LocalCacheActivationAddress);
            _codec1.WriteField(ref writer, 1U, _type1, instance.LocalDirectoryActivationAddress);
            _codec2.WriteField(ref writer, 1U, _type2, instance.PrimaryForGrain);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.GrainClassTypeName);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.LocalActivation);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.DetailedGrainReport instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField6(instance, _codec2.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField7(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    setField3(instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 4U)
                {
                    setField4(instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 5U)
                {
                    setField5(instance, _codec2.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 6U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 7U)
                {
                    setField2(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.DetailedGrainReport @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.DetailedGrainReport ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.DetailedGrainReport, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.DetailedGrainReport();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_DetailedGrainReport : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.DetailedGrainReport>
    {
        public global::Orleans.Runtime.DetailedGrainReport Create() => new global::Orleans.Runtime.DetailedGrainReport();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ICatalog_GrainReference_C4A56D7C : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_ICatalog_GrainReference_C4A56D7C>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_ICatalog_GrainReference_C4A56D7C);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Runtime.GrainAddress> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.DeactivationReasonCode);
        private readonly OrleansCodeGen.Orleans.Codec_DeactivationReasonCode _codec1;
        public Codec_Invokable_ICatalog_GrainReference_C4A56D7C(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Runtime.GrainAddress>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Codec_DeactivationReasonCode>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_ICatalog_GrainReference_C4A56D7C instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg1);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.arg2);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_ICatalog_GrainReference_C4A56D7C instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.arg2 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_ICatalog_GrainReference_C4A56D7C @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_ICatalog_GrainReference_C4A56D7C ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_ICatalog_GrainReference_C4A56D7C, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_ICatalog_GrainReference_C4A56D7C();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ICatalog_GrainReference_C4A56D7C : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_ICatalog_GrainReference_C4A56D7C>
    {
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Runtime.GrainAddress> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_ICatalog_GrainReference_C4A56D7C DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_ICatalog_GrainReference_C4A56D7C original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_ICatalog_GrainReference_C4A56D7C();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            result.arg1 = original.arg1;
            result.arg2 = original.arg2;
            return result;
        }

        public Copier_Invokable_ICatalog_GrainReference_C4A56D7C(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Runtime.GrainAddress>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.SiloAddress);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.SiloRuntimeStatistics);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_SiloRuntimeStatistics _codec1;
        public Codec_Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_SiloRuntimeStatistics>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C();
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_4C0864C2 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_4C0864C2>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_4C0864C2);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_4C0864C2 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.BoolCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_4C0864C2 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.BoolCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_4C0864C2 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_4C0864C2 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_4C0864C2, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_4C0864C2();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_4C0864C2 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_4C0864C2>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_4C0864C2 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_4C0864C2 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_4C0864C2();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_CC6CCBC3 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_CC6CCBC3>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_CC6CCBC3);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_CC6CCBC3 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.BoolCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_CC6CCBC3 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.BoolCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_CC6CCBC3 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_CC6CCBC3 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_CC6CCBC3, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_CC6CCBC3();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_CC6CCBC3 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_CC6CCBC3>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_CC6CCBC3 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_CC6CCBC3 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_CC6CCBC3();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_5922EB76 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_5922EB76>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_5922EB76);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.SiloAddress[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress> _codec0;
        public Codec_Invokable_IManagementGrain_GrainReference_5922EB76(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_5922EB76 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_5922EB76 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_5922EB76 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_5922EB76 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_5922EB76, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_5922EB76();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_5922EB76 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_5922EB76>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_5922EB76 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_5922EB76 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_5922EB76();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IManagementGrain_GrainReference_5922EB76(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_329F9A1B : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_329F9A1B>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_329F9A1B);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.SiloAddress[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress> _codec0;
        public Codec_Invokable_IManagementGrain_GrainReference_329F9A1B(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_329F9A1B instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            global::Orleans.Serialization.Codecs.TimeSpanCodec.WriteField(ref writer, 1U, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_329F9A1B instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = global::Orleans.Serialization.Codecs.TimeSpanCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_329F9A1B @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_329F9A1B ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_329F9A1B, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_329F9A1B();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_329F9A1B : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_329F9A1B>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_329F9A1B DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_329F9A1B original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_329F9A1B();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            result.arg1 = original.arg1;
            return result;
        }

        public Copier_Invokable_IManagementGrain_GrainReference_329F9A1B(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_54E6D1D1 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54E6D1D1>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54E6D1D1);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54E6D1D1 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.TimeSpanCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54E6D1D1 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.TimeSpanCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54E6D1D1 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54E6D1D1 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54E6D1D1, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54E6D1D1();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_54E6D1D1 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54E6D1D1>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54E6D1D1 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54E6D1D1 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54E6D1D1();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_B761B345 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_B761B345>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_B761B345);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.SiloAddress[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress> _codec0;
        public Codec_Invokable_IManagementGrain_GrainReference_B761B345(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_B761B345 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_B761B345 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_B761B345 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_B761B345 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_B761B345, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_B761B345();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_B761B345 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_B761B345>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_B761B345 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_B761B345 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_B761B345();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IManagementGrain_GrainReference_B761B345(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_2D761B36 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_2D761B36>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_2D761B36);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.SiloAddress[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress> _codec0;
        public Codec_Invokable_IManagementGrain_GrainReference_2D761B36(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_2D761B36 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_2D761B36 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_2D761B36 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_2D761B36 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_2D761B36, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_2D761B36();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_2D761B36 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_2D761B36>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_2D761B36 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_2D761B36 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_2D761B36();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IManagementGrain_GrainReference_2D761B36(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_3CFF788C : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3CFF788C>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3CFF788C);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.SiloAddress[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress> _codec0;
        public Codec_Invokable_IManagementGrain_GrainReference_3CFF788C(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3CFF788C instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3CFF788C instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3CFF788C @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3CFF788C ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3CFF788C, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3CFF788C();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_3CFF788C : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3CFF788C>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3CFF788C DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3CFF788C original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3CFF788C();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IManagementGrain_GrainReference_3CFF788C(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_ACCE9D6A : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_ACCE9D6A>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_ACCE9D6A);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_ACCE9D6A instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_ACCE9D6A instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_ACCE9D6A @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_ACCE9D6A ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_ACCE9D6A, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_ACCE9D6A();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_ACCE9D6A : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_ACCE9D6A>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_ACCE9D6A DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_ACCE9D6A original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_ACCE9D6A();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_0A1C0D82 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0A1C0D82>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0A1C0D82);
        private readonly global::System.Type _type0 = typeof(string[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<string> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.SiloAddress[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress> _codec1;
        public Codec_Invokable_IManagementGrain_GrainReference_0A1C0D82(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<string>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0A1C0D82 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0A1C0D82 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0A1C0D82 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0A1C0D82 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0A1C0D82, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0A1C0D82();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_0A1C0D82 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0A1C0D82>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<string> _copier0;
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress> _copier1;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0A1C0D82 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0A1C0D82 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0A1C0D82();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            result.arg1 = _copier1.DeepCopy(original.arg1, context);
            return result;
        }

        public Copier_Invokable_IManagementGrain_GrainReference_0A1C0D82(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<string>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_AEDE93F6 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_AEDE93F6>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_AEDE93F6);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainReference);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GrainReference> _codec0;
        public Codec_Invokable_IManagementGrain_GrainReference_AEDE93F6(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GrainReference>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_AEDE93F6 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_AEDE93F6 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_AEDE93F6 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_AEDE93F6 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_AEDE93F6, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_AEDE93F6();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_AEDE93F6 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_AEDE93F6>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Runtime.GrainReference> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_AEDE93F6 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_AEDE93F6 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_AEDE93F6();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IManagementGrain_GrainReference_AEDE93F6(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Runtime.GrainReference>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_D7365B43 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_D7365B43>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_D7365B43);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_D7365B43 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_D7365B43 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_D7365B43 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_D7365B43 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_D7365B43, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_D7365B43();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_D7365B43 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_D7365B43>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_D7365B43 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_D7365B43 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_D7365B43();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_F67965CC_1<T> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_F67965CC_1<T>> where T : global::Orleans.Providers.IControllable
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_F67965CC_1<T>);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_F67965CC_1<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.arg1);
            global::Orleans.Serialization.Codecs.ObjectCodec.WriteField(ref writer, 1U, instance.arg2);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_F67965CC_1<T> instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.arg2 = global::Orleans.Serialization.Codecs.ObjectCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_F67965CC_1<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_F67965CC_1<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_F67965CC_1<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_F67965CC_1<T>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_F67965CC_1<T> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_F67965CC_1<T>> where T : global::Orleans.Providers.IControllable
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_F67965CC_1<T> DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_F67965CC_1<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_F67965CC_1<T>();
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            result.arg2 = global::Orleans.Serialization.Codecs.ObjectCopier.DeepCopy(original.arg2, context);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_317D82B6 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_317D82B6>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_317D82B6);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.IAddressable);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.IAddressable> _codec0;
        public Codec_Invokable_IManagementGrain_GrainReference_317D82B6(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.IAddressable>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_317D82B6 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_317D82B6 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_317D82B6 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_317D82B6 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_317D82B6, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_317D82B6();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_317D82B6 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_317D82B6>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Runtime.IAddressable> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_317D82B6 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_317D82B6 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_317D82B6();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IManagementGrain_GrainReference_317D82B6(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Runtime.IAddressable>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_3DB7923B : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3DB7923B>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3DB7923B);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainType);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainType _codec0;
        public Codec_Invokable_IManagementGrain_GrainReference_3DB7923B(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainType>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3DB7923B instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3DB7923B instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3DB7923B @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3DB7923B ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3DB7923B, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3DB7923B();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_3DB7923B : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3DB7923B>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3DB7923B DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3DB7923B original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3DB7923B();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_0F06E027 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0F06E027>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0F06E027);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.SiloAddress[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress> _codec0;
        public Codec_Invokable_IManagementGrain_GrainReference_0F06E027(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0F06E027 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0F06E027 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0F06E027 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0F06E027 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0F06E027, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0F06E027();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_0F06E027 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0F06E027>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0F06E027 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0F06E027 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0F06E027();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IManagementGrain_GrainReference_0F06E027(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IManagementGrain_GrainReference_54FE0FEC : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54FE0FEC>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54FE0FEC);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.SiloAddress[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress> _codec0;
        public Codec_Invokable_IManagementGrain_GrainReference_54FE0FEC(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54FE0FEC instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54FE0FEC instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54FE0FEC @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54FE0FEC ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54FE0FEC, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54FE0FEC();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IManagementGrain_GrainReference_54FE0FEC : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54FE0FEC>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54FE0FEC DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54FE0FEC original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54FE0FEC();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IManagementGrain_GrainReference_54FE0FEC(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_GrainCallFrequency : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GrainCallFrequency>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Runtime.GrainCallFrequency>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.GrainCallFrequency);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainId _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.SiloAddress);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress> _codec1;
        public Codec_GrainCallFrequency(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainId>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Runtime.GrainCallFrequency instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.SourceGrain);
            _codec0.WriteField(ref writer, 1U, _type0, instance.TargetGrain);
            _codec1.WriteField(ref writer, 1U, _type1, instance.SourceHost);
            _codec1.WriteField(ref writer, 1U, _type1, instance.TargetHost);
            global::Orleans.Serialization.Codecs.UInt64Codec.WriteField(ref writer, 1U, instance.CallCount);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Runtime.GrainCallFrequency instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.SourceGrain = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.TargetGrain = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.SourceHost = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.TargetHost = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 4U)
                {
                    instance.CallCount = global::Orleans.Serialization.Codecs.UInt64Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.GrainCallFrequency @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.GrainCallFrequency ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Runtime.GrainCallFrequency);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IMembershipService_GrainReference_22A02D46 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_22A02D46>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_22A02D46);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.MembershipTableSnapshot);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_MembershipTableSnapshot _codec0;
        public Codec_Invokable_IMembershipService_GrainReference_22A02D46(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_MembershipTableSnapshot>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_22A02D46 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_22A02D46 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_22A02D46 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_22A02D46 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_22A02D46, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_22A02D46();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IMembershipService_GrainReference_22A02D46 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_22A02D46>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_22A02D46 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_22A02D46 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_22A02D46();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IMembershipService_GrainReference_39AB7071 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_39AB7071>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_39AB7071);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_39AB7071 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_39AB7071 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_39AB7071 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_39AB7071 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_39AB7071, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_39AB7071();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IMembershipService_GrainReference_39AB7071 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_39AB7071>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_39AB7071 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_39AB7071 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_39AB7071();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IMembershipService_GrainReference_0F85FAAF : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_0F85FAAF>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_0F85FAAF);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.SiloAddress);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress> _codec0;
        public Codec_Invokable_IMembershipService_GrainReference_0F85FAAF(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_0F85FAAF instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            global::Orleans.Serialization.Codecs.TimeSpanCodec.WriteField(ref writer, 1U, instance.arg1);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.arg2);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_0F85FAAF instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = global::Orleans.Serialization.Codecs.TimeSpanCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.arg2 = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_0F85FAAF @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_0F85FAAF ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_0F85FAAF, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_0F85FAAF();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IMembershipService_GrainReference_0F85FAAF : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_0F85FAAF>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_0F85FAAF DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_0F85FAAF original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_0F85FAAF();
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            result.arg2 = original.arg2;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_IndirectProbeResponse : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.IndirectProbeResponse>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Runtime.IndirectProbeResponse>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.IndirectProbeResponse);
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.IndirectProbeResponse, string> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.IndirectProbeResponse, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Runtime.IndirectProbeResponse), "<FailureMessage>k__BackingField");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.IndirectProbeResponse, int> setField1 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.IndirectProbeResponse, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Runtime.IndirectProbeResponse), "<IntermediaryHealthScore>k__BackingField");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.IndirectProbeResponse, global::System.TimeSpan> setField2 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.IndirectProbeResponse, global::System.TimeSpan>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Runtime.IndirectProbeResponse), "<ProbeResponseTime>k__BackingField");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.IndirectProbeResponse, bool> setField3 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.IndirectProbeResponse, bool>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Runtime.IndirectProbeResponse), "<Succeeded>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Runtime.IndirectProbeResponse instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.IntermediaryHealthScore);
            global::Orleans.Serialization.Codecs.BoolCodec.WriteField(ref writer, 1U, instance.Succeeded);
            global::Orleans.Serialization.Codecs.TimeSpanCodec.WriteField(ref writer, 1U, instance.ProbeResponseTime);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.FailureMessage);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Runtime.IndirectProbeResponse instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField1(ref instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField3(ref instance, global::Orleans.Serialization.Codecs.BoolCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField2(ref instance, global::Orleans.Serialization.Codecs.TimeSpanCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    setField0(ref instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.IndirectProbeResponse @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.IndirectProbeResponse ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Runtime.IndirectProbeResponse);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }
}

namespace OrleansCodeGen.Orleans
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.IVersionManager), "8F5C15A9")]
    public sealed class Invokable_IVersionManager_GrainReference_8F5C15A9 : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.Versions.Compatibility.CompatibilityStrategy arg0;
        global::Orleans.IVersionManager target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.IVersionManager), "SetCompatibilityStrategy", null, new[] { typeof(global::Orleans.Versions.Compatibility.CompatibilityStrategy) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "SetCompatibilityStrategy";
        public override string GetInterfaceName() => "Orleans.IVersionManager";
        public override string GetActivityName() => "IVersionManager/SetCompatibilityStrategy";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.IVersionManager);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.IVersionManager>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Versions.Compatibility.CompatibilityStrategy)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.SetCompatibilityStrategy(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.IVersionManager), "4AAEAFCE")]
    public sealed class Invokable_IVersionManager_GrainReference_4AAEAFCE : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.Versions.Selector.VersionSelectorStrategy arg0;
        global::Orleans.IVersionManager target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.IVersionManager), "SetSelectorStrategy", null, new[] { typeof(global::Orleans.Versions.Selector.VersionSelectorStrategy) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "SetSelectorStrategy";
        public override string GetInterfaceName() => "Orleans.IVersionManager";
        public override string GetActivityName() => "IVersionManager/SetSelectorStrategy";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.IVersionManager);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.IVersionManager>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Versions.Selector.VersionSelectorStrategy)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.SetSelectorStrategy(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.IVersionManager), "C01C4EE8")]
    public sealed class Invokable_IVersionManager_GrainReference_C01C4EE8 : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.Runtime.GrainInterfaceType arg0;
        public global::Orleans.Versions.Compatibility.CompatibilityStrategy arg1;
        global::Orleans.IVersionManager target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.IVersionManager), "SetCompatibilityStrategy", null, new[] { typeof(global::Orleans.Runtime.GrainInterfaceType), typeof(global::Orleans.Versions.Compatibility.CompatibilityStrategy) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "SetCompatibilityStrategy";
        public override string GetInterfaceName() => "Orleans.IVersionManager";
        public override string GetActivityName() => "IVersionManager/SetCompatibilityStrategy";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.IVersionManager);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.IVersionManager>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                case 1:
                    return arg1;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.GrainInterfaceType)value;
                    return;
                case 1:
                    arg1 = (global::Orleans.Versions.Compatibility.CompatibilityStrategy)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.SetCompatibilityStrategy(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.IVersionManager), "90AB9D5E")]
    public sealed class Invokable_IVersionManager_GrainReference_90AB9D5E : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.Runtime.GrainInterfaceType arg0;
        public global::Orleans.Versions.Selector.VersionSelectorStrategy arg1;
        global::Orleans.IVersionManager target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.IVersionManager), "SetSelectorStrategy", null, new[] { typeof(global::Orleans.Runtime.GrainInterfaceType), typeof(global::Orleans.Versions.Selector.VersionSelectorStrategy) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "SetSelectorStrategy";
        public override string GetInterfaceName() => "Orleans.IVersionManager";
        public override string GetActivityName() => "IVersionManager/SetSelectorStrategy";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.IVersionManager);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.IVersionManager>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                case 1:
                    return arg1;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.GrainInterfaceType)value;
                    return;
                case 1:
                    arg1 = (global::Orleans.Versions.Selector.VersionSelectorStrategy)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.SetSelectorStrategy(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.IMembershipTable), "FB89E5E9")]
    public sealed class Invokable_IMembershipTable_GrainReference_FB89E5E9 : global::Orleans.Runtime.TaskRequest
    {
        public bool arg0;
        global::Orleans.IMembershipTable target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.IMembershipTable), "InitializeMembershipTable", null, new[] { typeof(bool) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "InitializeMembershipTable";
        public override string GetInterfaceName() => "Orleans.IMembershipTable";
        public override string GetActivityName() => "IMembershipTable/InitializeMembershipTable";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.IMembershipTable);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.IMembershipTable>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (bool)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.InitializeMembershipTable(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.IMembershipTable), "BF899C85")]
    public sealed class Invokable_IMembershipTable_GrainReference_BF899C85 : global::Orleans.Runtime.TaskRequest
    {
        public string arg0;
        global::Orleans.IMembershipTable target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.IMembershipTable), "DeleteMembershipTableEntries", null, new[] { typeof(string) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "DeleteMembershipTableEntries";
        public override string GetInterfaceName() => "Orleans.IMembershipTable";
        public override string GetActivityName() => "IMembershipTable/DeleteMembershipTableEntries";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.IMembershipTable);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.IMembershipTable>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (string)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.DeleteMembershipTableEntries(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.IMembershipTable), "7A519C2E")]
    public sealed class Invokable_IMembershipTable_GrainReference_7A519C2E : global::Orleans.Runtime.TaskRequest
    {
        public global::System.DateTimeOffset arg0;
        global::Orleans.IMembershipTable target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.IMembershipTable), "CleanupDefunctSiloEntries", null, new[] { typeof(global::System.DateTimeOffset) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "CleanupDefunctSiloEntries";
        public override string GetInterfaceName() => "Orleans.IMembershipTable";
        public override string GetActivityName() => "IMembershipTable/CleanupDefunctSiloEntries";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.IMembershipTable);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.IMembershipTable>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::System.DateTimeOffset)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.CleanupDefunctSiloEntries(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.IMembershipTable), "D851FB33")]
    public sealed class Invokable_IMembershipTable_GrainReference_D851FB33 : global::Orleans.Runtime.TaskRequest<global::Orleans.MembershipTableData>
    {
        public global::Orleans.Runtime.SiloAddress arg0;
        global::Orleans.IMembershipTable target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.IMembershipTable), "ReadRow", null, new[] { typeof(global::Orleans.Runtime.SiloAddress) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "ReadRow";
        public override string GetInterfaceName() => "Orleans.IMembershipTable";
        public override string GetActivityName() => "IMembershipTable/ReadRow";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.IMembershipTable);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.IMembershipTable>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.SiloAddress)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.MembershipTableData> InvokeInner() => target.ReadRow(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.IMembershipTable), "00BCE16F")]
    public sealed class Invokable_IMembershipTable_GrainReference_00BCE16F : global::Orleans.Runtime.TaskRequest<global::Orleans.MembershipTableData>
    {
        global::Orleans.IMembershipTable target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.IMembershipTable), "ReadAll", null, null);
        public override string GetMethodName() => "ReadAll";
        public override string GetInterfaceName() => "Orleans.IMembershipTable";
        public override string GetActivityName() => "IMembershipTable/ReadAll";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.IMembershipTable);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.IMembershipTable>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.MembershipTableData> InvokeInner() => target.ReadAll();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.IMembershipTable), "FEF3AC5A")]
    public sealed class Invokable_IMembershipTable_GrainReference_FEF3AC5A : global::Orleans.Runtime.TaskRequest<bool>
    {
        public global::Orleans.MembershipEntry arg0;
        public global::Orleans.TableVersion arg1;
        global::Orleans.IMembershipTable target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.IMembershipTable), "InsertRow", null, new[] { typeof(global::Orleans.MembershipEntry), typeof(global::Orleans.TableVersion) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "InsertRow";
        public override string GetInterfaceName() => "Orleans.IMembershipTable";
        public override string GetActivityName() => "IMembershipTable/InsertRow";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.IMembershipTable);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.IMembershipTable>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                case 1:
                    return arg1;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.MembershipEntry)value;
                    return;
                case 1:
                    arg1 = (global::Orleans.TableVersion)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<bool> InvokeInner() => target.InsertRow(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.IMembershipTable), "E06D3DBC")]
    public sealed class Invokable_IMembershipTable_GrainReference_E06D3DBC : global::Orleans.Runtime.TaskRequest<bool>
    {
        public global::Orleans.MembershipEntry arg0;
        public string arg1;
        public global::Orleans.TableVersion arg2;
        global::Orleans.IMembershipTable target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.IMembershipTable), "UpdateRow", null, new[] { typeof(global::Orleans.MembershipEntry), typeof(string), typeof(global::Orleans.TableVersion) });
        public override int GetArgumentCount() => 3;
        public override string GetMethodName() => "UpdateRow";
        public override string GetInterfaceName() => "Orleans.IMembershipTable";
        public override string GetActivityName() => "IMembershipTable/UpdateRow";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.IMembershipTable);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.IMembershipTable>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                case 1:
                    return arg1;
                case 2:
                    return arg2;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.MembershipEntry)value;
                    return;
                case 1:
                    arg1 = (string)value;
                    return;
                case 2:
                    arg2 = (global::Orleans.TableVersion)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<bool> InvokeInner() => target.UpdateRow(arg0, arg1, arg2);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.IMembershipTable), "B1A52D2B")]
    public sealed class Invokable_IMembershipTable_GrainReference_B1A52D2B : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.MembershipEntry arg0;
        global::Orleans.IMembershipTable target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.IMembershipTable), "UpdateIAmAlive", null, new[] { typeof(global::Orleans.MembershipEntry) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "UpdateIAmAlive";
        public override string GetInterfaceName() => "Orleans.IMembershipTable";
        public override string GetActivityName() => "IMembershipTable/UpdateIAmAlive";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.IMembershipTable);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.IMembershipTable>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.MembershipEntry)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.UpdateIAmAlive(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IMembershipTableSystemTarget : global::Orleans.Runtime.GrainReference, global::Orleans.IMembershipTableSystemTarget
    {
        private readonly OrleansCodeGen.Orleans.Copier_MembershipEntry _copier0;
        public Proxy_IMembershipTableSystemTarget(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Copier_MembershipEntry>(this, CodecProvider);
        }

        global::System.Threading.Tasks.Task global::Orleans.IMembershipTable.InitializeMembershipTable(bool arg0)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FB89E5E9();
            request.arg0 = arg0;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.IMembershipTable.DeleteMembershipTableEntries(string arg0)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_BF899C85();
            request.arg0 = arg0;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.IMembershipTable.CleanupDefunctSiloEntries(global::System.DateTimeOffset arg0)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_7A519C2E();
            request.arg0 = arg0;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.MembershipTableData> global::Orleans.IMembershipTable.ReadRow(global::Orleans.Runtime.SiloAddress arg0)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_D851FB33();
            request.arg0 = arg0;
            return base.InvokeAsync<global::Orleans.MembershipTableData>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.MembershipTableData> global::Orleans.IMembershipTable.ReadAll()
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_00BCE16F();
            return base.InvokeAsync<global::Orleans.MembershipTableData>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<bool> global::Orleans.IMembershipTable.InsertRow(global::Orleans.MembershipEntry arg0, global::Orleans.TableVersion arg1)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FEF3AC5A();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            request.arg1 = arg1;
            return base.InvokeAsync<bool>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<bool> global::Orleans.IMembershipTable.UpdateRow(global::Orleans.MembershipEntry arg0, string arg1, global::Orleans.TableVersion arg2)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_E06D3DBC();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            request.arg1 = arg1;
            request.arg2 = arg2;
            return base.InvokeAsync<bool>(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.IMembershipTable.UpdateIAmAlive(global::Orleans.MembershipEntry arg0)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_B1A52D2B();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            return base.InvokeAsync(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.ISiloControl), "1422B0B7")]
    internal sealed class Invokable_ISiloControl_GrainReference_1422B0B7 : global::Orleans.Runtime.TaskRequest
    {
        public string arg0;
        global::Orleans.ISiloControl target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.ISiloControl), "Ping", null, new[] { typeof(string) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "Ping";
        public override string GetInterfaceName() => "Orleans.ISiloControl";
        public override string GetActivityName() => "ISiloControl/Ping";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.ISiloControl);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.ISiloControl>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (string)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.Ping(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.ISiloControl), "F388CED1")]
    internal sealed class Invokable_ISiloControl_GrainReference_F388CED1 : global::Orleans.Runtime.TaskRequest
    {
        global::Orleans.ISiloControl target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.ISiloControl), "ForceGarbageCollection", null, null);
        public override string GetMethodName() => "ForceGarbageCollection";
        public override string GetInterfaceName() => "Orleans.ISiloControl";
        public override string GetActivityName() => "ISiloControl/ForceGarbageCollection";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.ISiloControl);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.ISiloControl>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.ForceGarbageCollection();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.ISiloControl), "45D07D09")]
    internal sealed class Invokable_ISiloControl_GrainReference_45D07D09 : global::Orleans.Runtime.TaskRequest
    {
        public global::System.TimeSpan arg0;
        global::Orleans.ISiloControl target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.ISiloControl), "ForceActivationCollection", null, new[] { typeof(global::System.TimeSpan) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "ForceActivationCollection";
        public override string GetInterfaceName() => "Orleans.ISiloControl";
        public override string GetActivityName() => "ISiloControl/ForceActivationCollection";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.ISiloControl);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.ISiloControl>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::System.TimeSpan)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.ForceActivationCollection(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.ISiloControl), "0C7DBD0C")]
    internal sealed class Invokable_ISiloControl_GrainReference_0C7DBD0C : global::Orleans.Runtime.TaskRequest
    {
        global::Orleans.ISiloControl target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.ISiloControl), "ForceRuntimeStatisticsCollection", null, null);
        public override string GetMethodName() => "ForceRuntimeStatisticsCollection";
        public override string GetInterfaceName() => "Orleans.ISiloControl";
        public override string GetActivityName() => "ISiloControl/ForceRuntimeStatisticsCollection";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.ISiloControl);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.ISiloControl>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.ForceRuntimeStatisticsCollection();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.ISiloControl), "F18EAF24")]
    internal sealed class Invokable_ISiloControl_GrainReference_F18EAF24 : global::Orleans.Runtime.TaskRequest<global::Orleans.Runtime.SiloRuntimeStatistics>
    {
        global::Orleans.ISiloControl target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.ISiloControl), "GetRuntimeStatistics", null, null);
        public override string GetMethodName() => "GetRuntimeStatistics";
        public override string GetInterfaceName() => "Orleans.ISiloControl";
        public override string GetActivityName() => "ISiloControl/GetRuntimeStatistics";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.ISiloControl);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.ISiloControl>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.Runtime.SiloRuntimeStatistics> InvokeInner() => target.GetRuntimeStatistics();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.ISiloControl), "FF707A30")]
    internal sealed class Invokable_ISiloControl_GrainReference_FF707A30 : global::Orleans.Runtime.TaskRequest<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, string, int>>>
    {
        global::Orleans.ISiloControl target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.ISiloControl), "GetGrainStatistics", null, null);
        public override string GetMethodName() => "GetGrainStatistics";
        public override string GetInterfaceName() => "Orleans.ISiloControl";
        public override string GetActivityName() => "ISiloControl/GetGrainStatistics";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.ISiloControl);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.ISiloControl>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, string, int>>> InvokeInner() => target.GetGrainStatistics();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.ISiloControl), "B0F4C24B")]
    internal sealed class Invokable_ISiloControl_GrainReference_B0F4C24B : global::Orleans.Runtime.TaskRequest<global::System.Collections.Generic.List<global::Orleans.Runtime.DetailedGrainStatistic>>
    {
        public string[] arg0;
        global::Orleans.ISiloControl target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.ISiloControl), "GetDetailedGrainStatistics", null, new[] { typeof(string[]) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "GetDetailedGrainStatistics";
        public override string GetInterfaceName() => "Orleans.ISiloControl";
        public override string GetActivityName() => "ISiloControl/GetDetailedGrainStatistics";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.ISiloControl);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.ISiloControl>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (string[])value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.Runtime.DetailedGrainStatistic>> InvokeInner() => target.GetDetailedGrainStatistics(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.ISiloControl), "6DE16EF7")]
    internal sealed class Invokable_ISiloControl_GrainReference_6DE16EF7 : global::Orleans.Runtime.TaskRequest<global::Orleans.Runtime.SimpleGrainStatistic[]>
    {
        global::Orleans.ISiloControl target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.ISiloControl), "GetSimpleGrainStatistics", null, null);
        public override string GetMethodName() => "GetSimpleGrainStatistics";
        public override string GetInterfaceName() => "Orleans.ISiloControl";
        public override string GetActivityName() => "ISiloControl/GetSimpleGrainStatistics";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.ISiloControl);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.ISiloControl>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.Runtime.SimpleGrainStatistic[]> InvokeInner() => target.GetSimpleGrainStatistics();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.ISiloControl), "45172562")]
    internal sealed class Invokable_ISiloControl_GrainReference_45172562 : global::Orleans.Runtime.TaskRequest<global::Orleans.Runtime.DetailedGrainReport>
    {
        public global::Orleans.Runtime.GrainId arg0;
        global::Orleans.ISiloControl target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.ISiloControl), "GetDetailedGrainReport", null, new[] { typeof(global::Orleans.Runtime.GrainId) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "GetDetailedGrainReport";
        public override string GetInterfaceName() => "Orleans.ISiloControl";
        public override string GetActivityName() => "ISiloControl/GetDetailedGrainReport";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.ISiloControl);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.ISiloControl>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.GrainId)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.Runtime.DetailedGrainReport> InvokeInner() => target.GetDetailedGrainReport(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.ISiloControl), "C4C370A5")]
    internal sealed class Invokable_ISiloControl_GrainReference_C4C370A5 : global::Orleans.Runtime.TaskRequest<int>
    {
        global::Orleans.ISiloControl target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.ISiloControl), "GetActivationCount", null, null);
        public override string GetMethodName() => "GetActivationCount";
        public override string GetInterfaceName() => "Orleans.ISiloControl";
        public override string GetActivityName() => "ISiloControl/GetActivationCount";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.ISiloControl);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.ISiloControl>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task<int> InvokeInner() => target.GetActivationCount();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.ISiloControl), "355CA3FA")]
    internal sealed class Invokable_ISiloControl_GrainReference_355CA3FA_1<T> : global::Orleans.Runtime.TaskRequest<global::System.Object> where T : global::Orleans.Providers.IControllable
    {
        public global::System.String arg0;
        public global::System.Int32 arg1;
        public global::System.Object arg2;
        global::Orleans.ISiloControl target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.ISiloControl), "SendControlCommandToProvider", new[] { typeof(T) }, new[] { typeof(global::System.String), typeof(global::System.Int32), typeof(global::System.Object) });
        public override int GetArgumentCount() => 3;
        public override string GetMethodName() => "SendControlCommandToProvider<T>";
        public override string GetInterfaceName() => "Orleans.ISiloControl";
        public override string GetActivityName() => "ISiloControl/SendControlCommandToProvider<T>";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.ISiloControl);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.ISiloControl>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                case 1:
                    return arg1;
                case 2:
                    return arg2;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::System.String)value;
                    return;
                case 1:
                    arg1 = (global::System.Int32)value;
                    return;
                case 2:
                    arg2 = (global::System.Object)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::System.Object> InvokeInner() => target.SendControlCommandToProvider<T>(arg0, arg1, arg2);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.ISiloControl), "85797C87")]
    internal sealed class Invokable_ISiloControl_GrainReference_85797C87 : global::Orleans.Runtime.TaskRequest<global::System.Collections.Generic.List<global::Orleans.Runtime.GrainId>>
    {
        public global::Orleans.Runtime.GrainType arg0;
        global::Orleans.ISiloControl target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.ISiloControl), "GetActiveGrains", null, new[] { typeof(global::Orleans.Runtime.GrainType) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "GetActiveGrains";
        public override string GetInterfaceName() => "Orleans.ISiloControl";
        public override string GetActivityName() => "ISiloControl/GetActiveGrains";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.ISiloControl);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.ISiloControl>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Runtime.GrainType)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.Runtime.GrainId>> InvokeInner() => target.GetActiveGrains(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_ISiloControl : global::Orleans.Runtime.GrainReference, global::Orleans.ISiloControl
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<string> _copier0;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy> _copier1;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy> _copier2;
        public Proxy_ISiloControl(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<string>>(this, CodecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(this, CodecProvider);
            _copier2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy>>(this, CodecProvider);
        }

        global::System.Threading.Tasks.Task global::Orleans.ISiloControl.Ping(string arg0)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_1422B0B7();
            request.arg0 = arg0;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.ISiloControl.ForceGarbageCollection()
        {
            var request = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F388CED1();
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.ISiloControl.ForceActivationCollection(global::System.TimeSpan arg0)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45D07D09();
            request.arg0 = arg0;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.ISiloControl.ForceRuntimeStatisticsCollection()
        {
            var request = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_0C7DBD0C();
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.Runtime.SiloRuntimeStatistics> global::Orleans.ISiloControl.GetRuntimeStatistics()
        {
            var request = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F18EAF24();
            return base.InvokeAsync<global::Orleans.Runtime.SiloRuntimeStatistics>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, string, int>>> global::Orleans.ISiloControl.GetGrainStatistics()
        {
            var request = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_FF707A30();
            return base.InvokeAsync<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, string, int>>>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.Runtime.DetailedGrainStatistic>> global::Orleans.ISiloControl.GetDetailedGrainStatistics(string[] arg0)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_B0F4C24B();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            return base.InvokeAsync<global::System.Collections.Generic.List<global::Orleans.Runtime.DetailedGrainStatistic>>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.Runtime.SimpleGrainStatistic[]> global::Orleans.ISiloControl.GetSimpleGrainStatistics()
        {
            var request = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_6DE16EF7();
            return base.InvokeAsync<global::Orleans.Runtime.SimpleGrainStatistic[]>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.Runtime.DetailedGrainReport> global::Orleans.ISiloControl.GetDetailedGrainReport(global::Orleans.Runtime.GrainId arg0)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45172562();
            request.arg0 = arg0;
            return base.InvokeAsync<global::Orleans.Runtime.DetailedGrainReport>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<int> global::Orleans.ISiloControl.GetActivationCount()
        {
            var request = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_C4C370A5();
            return base.InvokeAsync<int>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::System.Object> global::Orleans.ISiloControl.SendControlCommandToProvider<T>(global::System.String arg0, global::System.Int32 arg1, global::System.Object arg2)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_355CA3FA_1<T>();
            request.arg0 = arg0;
            request.arg1 = arg1;
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg2 = global::Orleans.Serialization.Codecs.ObjectCopier.DeepCopy(arg2, copyContext);
            return base.InvokeAsync<global::System.Object>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.Runtime.GrainId>> global::Orleans.ISiloControl.GetActiveGrains(global::Orleans.Runtime.GrainType arg0)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_85797C87();
            request.arg0 = arg0;
            return base.InvokeAsync<global::System.Collections.Generic.List<global::Orleans.Runtime.GrainId>>(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.IVersionManager.SetCompatibilityStrategy(global::Orleans.Versions.Compatibility.CompatibilityStrategy arg0)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_8F5C15A9();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier1.DeepCopy(arg0, copyContext);
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.IVersionManager.SetSelectorStrategy(global::Orleans.Versions.Selector.VersionSelectorStrategy arg0)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_4AAEAFCE();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier2.DeepCopy(arg0, copyContext);
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.IVersionManager.SetCompatibilityStrategy(global::Orleans.Runtime.GrainInterfaceType arg0, global::Orleans.Versions.Compatibility.CompatibilityStrategy arg1)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_C01C4EE8();
            request.arg0 = arg0;
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg1 = _copier1.DeepCopy(arg1, copyContext);
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.IVersionManager.SetSelectorStrategy(global::Orleans.Runtime.GrainInterfaceType arg0, global::Orleans.Versions.Selector.VersionSelectorStrategy arg1)
        {
            var request = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_90AB9D5E();
            request.arg0 = arg0;
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg1 = _copier2.DeepCopy(arg1, copyContext);
            return base.InvokeAsync(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_GrainState<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.GrainState<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.GrainState<T>);
        private readonly global::System.Type _type0 = typeof(T);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T> _codec0;
        public Codec_GrainState(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.GrainState<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.State);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.ETag);
            global::Orleans.Serialization.Codecs.BoolCodec.WriteField(ref writer, 1U, instance.RecordExists);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.GrainState<T> instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.State = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.ETag = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.RecordExists = global::Orleans.Serialization.Codecs.BoolCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.GrainState<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.GrainState<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.GrainState<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.GrainState<T>();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_GrainState<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.GrainState<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.GrainState<T> DeepCopy(global::Orleans.GrainState<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.GrainState<T> existing))
                return existing;
            var result = new global::Orleans.GrainState<T>();
            context.RecordCopy(original, result);
            result.State = _copier0.DeepCopy(original.State, context);
            result.ETag = original.ETag;
            result.RecordExists = original.RecordExists;
            return result;
        }

        public Copier_GrainState(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_GrainState<T> : global::Orleans.Serialization.Activators.IActivator<global::Orleans.GrainState<T>>
    {
        public global::Orleans.GrainState<T> Create() => new global::Orleans.GrainState<T>();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IVersionManager_GrainReference_8F5C15A9 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_8F5C15A9>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_8F5C15A9);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Versions.Compatibility.CompatibilityStrategy);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Compatibility.CompatibilityStrategy> _codec0;
        public Codec_Invokable_IVersionManager_GrainReference_8F5C15A9(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_8F5C15A9 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_8F5C15A9 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_8F5C15A9 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_8F5C15A9 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_8F5C15A9, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_8F5C15A9();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IVersionManager_GrainReference_8F5C15A9 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_8F5C15A9>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_8F5C15A9 DeepCopy(OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_8F5C15A9 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_8F5C15A9();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IVersionManager_GrainReference_8F5C15A9(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IVersionManager_GrainReference_4AAEAFCE : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_4AAEAFCE>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_4AAEAFCE);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Versions.Selector.VersionSelectorStrategy);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Selector.VersionSelectorStrategy> _codec0;
        public Codec_Invokable_IVersionManager_GrainReference_4AAEAFCE(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Selector.VersionSelectorStrategy>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_4AAEAFCE instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_4AAEAFCE instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_4AAEAFCE @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_4AAEAFCE ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_4AAEAFCE, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_4AAEAFCE();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IVersionManager_GrainReference_4AAEAFCE : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_4AAEAFCE>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_4AAEAFCE DeepCopy(OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_4AAEAFCE original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_4AAEAFCE();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IVersionManager_GrainReference_4AAEAFCE(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IVersionManager_GrainReference_C01C4EE8 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_C01C4EE8>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_C01C4EE8);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainInterfaceType);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainInterfaceType _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Versions.Compatibility.CompatibilityStrategy);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Compatibility.CompatibilityStrategy> _codec1;
        public Codec_Invokable_IVersionManager_GrainReference_C01C4EE8(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainInterfaceType>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_C01C4EE8 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_C01C4EE8 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_C01C4EE8 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_C01C4EE8 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_C01C4EE8, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_C01C4EE8();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IVersionManager_GrainReference_C01C4EE8 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_C01C4EE8>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_C01C4EE8 DeepCopy(OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_C01C4EE8 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_C01C4EE8();
            result.arg0 = original.arg0;
            result.arg1 = _copier0.DeepCopy(original.arg1, context);
            return result;
        }

        public Copier_Invokable_IVersionManager_GrainReference_C01C4EE8(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IVersionManager_GrainReference_90AB9D5E : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_90AB9D5E>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_90AB9D5E);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainInterfaceType);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainInterfaceType _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Versions.Selector.VersionSelectorStrategy);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Selector.VersionSelectorStrategy> _codec1;
        public Codec_Invokable_IVersionManager_GrainReference_90AB9D5E(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainInterfaceType>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Selector.VersionSelectorStrategy>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_90AB9D5E instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_90AB9D5E instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_90AB9D5E @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_90AB9D5E ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_90AB9D5E, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_90AB9D5E();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IVersionManager_GrainReference_90AB9D5E : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_90AB9D5E>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_90AB9D5E DeepCopy(OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_90AB9D5E original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_90AB9D5E();
            result.arg0 = original.arg0;
            result.arg1 = _copier0.DeepCopy(original.arg1, context);
            return result;
        }

        public Copier_Invokable_IVersionManager_GrainReference_90AB9D5E(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IMembershipTable_GrainReference_FB89E5E9 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FB89E5E9>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FB89E5E9);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FB89E5E9 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.BoolCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FB89E5E9 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.BoolCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FB89E5E9 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FB89E5E9 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FB89E5E9, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FB89E5E9();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IMembershipTable_GrainReference_FB89E5E9 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FB89E5E9>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FB89E5E9 DeepCopy(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FB89E5E9 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FB89E5E9();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IMembershipTable_GrainReference_BF899C85 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_BF899C85>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_BF899C85);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_BF899C85 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_BF899C85 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_BF899C85 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_BF899C85 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_BF899C85, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_BF899C85();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IMembershipTable_GrainReference_BF899C85 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_BF899C85>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_BF899C85 DeepCopy(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_BF899C85 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_BF899C85();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IMembershipTable_GrainReference_7A519C2E : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_7A519C2E>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_7A519C2E);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_7A519C2E instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.DateTimeOffsetCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_7A519C2E instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.DateTimeOffsetCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_7A519C2E @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_7A519C2E ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_7A519C2E, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_7A519C2E();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IMembershipTable_GrainReference_7A519C2E : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_7A519C2E>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_7A519C2E DeepCopy(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_7A519C2E original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_7A519C2E();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IMembershipTable_GrainReference_D851FB33 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_D851FB33>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_D851FB33);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.SiloAddress);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress> _codec0;
        public Codec_Invokable_IMembershipTable_GrainReference_D851FB33(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_D851FB33 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_D851FB33 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_D851FB33 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_D851FB33 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_D851FB33, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_D851FB33();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IMembershipTable_GrainReference_D851FB33 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_D851FB33>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_D851FB33 DeepCopy(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_D851FB33 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_D851FB33();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IMembershipTable_GrainReference_00BCE16F : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_00BCE16F>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_00BCE16F);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_00BCE16F instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_00BCE16F instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_00BCE16F @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_00BCE16F ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_00BCE16F, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_00BCE16F();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IMembershipTable_GrainReference_00BCE16F : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_00BCE16F>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_00BCE16F DeepCopy(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_00BCE16F original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_00BCE16F();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IMembershipTable_GrainReference_FEF3AC5A : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FEF3AC5A>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FEF3AC5A);
        private readonly global::System.Type _type0 = typeof(global::Orleans.MembershipEntry);
        private readonly OrleansCodeGen.Orleans.Codec_MembershipEntry _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.TableVersion);
        private readonly OrleansCodeGen.Orleans.Codec_TableVersion _codec1;
        public Codec_Invokable_IMembershipTable_GrainReference_FEF3AC5A(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Codec_MembershipEntry>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Codec_TableVersion>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FEF3AC5A instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FEF3AC5A instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FEF3AC5A @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FEF3AC5A ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FEF3AC5A, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FEF3AC5A();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IMembershipTable_GrainReference_FEF3AC5A : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FEF3AC5A>
    {
        private readonly OrleansCodeGen.Orleans.Copier_MembershipEntry _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FEF3AC5A DeepCopy(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FEF3AC5A original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FEF3AC5A();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            result.arg1 = original.arg1;
            return result;
        }

        public Copier_Invokable_IMembershipTable_GrainReference_FEF3AC5A(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Copier_MembershipEntry>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IMembershipTable_GrainReference_E06D3DBC : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_E06D3DBC>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_E06D3DBC);
        private readonly global::System.Type _type0 = typeof(global::Orleans.MembershipEntry);
        private readonly OrleansCodeGen.Orleans.Codec_MembershipEntry _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.TableVersion);
        private readonly OrleansCodeGen.Orleans.Codec_TableVersion _codec1;
        public Codec_Invokable_IMembershipTable_GrainReference_E06D3DBC(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Codec_MembershipEntry>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Codec_TableVersion>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_E06D3DBC instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.arg1);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg2);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_E06D3DBC instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.arg2 = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_E06D3DBC @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_E06D3DBC ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_E06D3DBC, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_E06D3DBC();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IMembershipTable_GrainReference_E06D3DBC : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_E06D3DBC>
    {
        private readonly OrleansCodeGen.Orleans.Copier_MembershipEntry _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_E06D3DBC DeepCopy(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_E06D3DBC original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_E06D3DBC();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            result.arg1 = original.arg1;
            result.arg2 = original.arg2;
            return result;
        }

        public Copier_Invokable_IMembershipTable_GrainReference_E06D3DBC(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Copier_MembershipEntry>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IMembershipTable_GrainReference_B1A52D2B : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_B1A52D2B>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_B1A52D2B);
        private readonly global::System.Type _type0 = typeof(global::Orleans.MembershipEntry);
        private readonly OrleansCodeGen.Orleans.Codec_MembershipEntry _codec0;
        public Codec_Invokable_IMembershipTable_GrainReference_B1A52D2B(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Codec_MembershipEntry>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_B1A52D2B instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_B1A52D2B instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_B1A52D2B @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_B1A52D2B ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_B1A52D2B, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_B1A52D2B();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IMembershipTable_GrainReference_B1A52D2B : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_B1A52D2B>
    {
        private readonly OrleansCodeGen.Orleans.Copier_MembershipEntry _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_B1A52D2B DeepCopy(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_B1A52D2B original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_B1A52D2B();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IMembershipTable_GrainReference_B1A52D2B(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Copier_MembershipEntry>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_TableVersion : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.TableVersion>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.TableVersion);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.TableVersion> _activator;
        private static readonly global::System.Action<global::Orleans.TableVersion, int> setField0 = (global::System.Action<global::Orleans.TableVersion, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.TableVersion), "<Version>k__BackingField");
        private static readonly global::System.Action<global::Orleans.TableVersion, string> setField1 = (global::System.Action<global::Orleans.TableVersion, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.TableVersion), "<VersionEtag>k__BackingField");
        public Codec_TableVersion(global::Orleans.Serialization.Activators.IActivator<global::Orleans.TableVersion> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.TableVersion instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.Version);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.VersionEtag);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.TableVersion instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.TableVersion @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.TableVersion ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.TableVersion, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_MembershipTableData : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.MembershipTableData>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.MembershipTableData);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.MembershipTableData> _activator;
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, string>>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, string>>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.TableVersion);
        private readonly OrleansCodeGen.Orleans.Codec_TableVersion _codec1;
        private static readonly global::System.Action<global::Orleans.MembershipTableData, global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, string>>> setField0 = (global::System.Action<global::Orleans.MembershipTableData, global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, string>>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.MembershipTableData), "<Members>k__BackingField");
        private static readonly global::System.Action<global::Orleans.MembershipTableData, global::Orleans.TableVersion> setField1 = (global::System.Action<global::Orleans.MembershipTableData, global::Orleans.TableVersion>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.MembershipTableData), "<Version>k__BackingField");
        public Codec_MembershipTableData(global::Orleans.Serialization.Activators.IActivator<global::Orleans.MembershipTableData> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, string>>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Codec_TableVersion>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.MembershipTableData instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Members);
            _codec1.WriteField(ref writer, 1U, _type1, instance.Version);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.MembershipTableData instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.MembershipTableData @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.MembershipTableData ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.MembershipTableData, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_MembershipTableData : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.MembershipTableData>
    {
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.MembershipTableData> _activator;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, string>>> _copier0;
        private static readonly global::System.Action<global::Orleans.MembershipTableData, global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, string>>> setField0 = (global::System.Action<global::Orleans.MembershipTableData, global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, string>>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.MembershipTableData), "<Members>k__BackingField");
        private static readonly global::System.Action<global::Orleans.MembershipTableData, global::Orleans.TableVersion> setField1 = (global::System.Action<global::Orleans.MembershipTableData, global::Orleans.TableVersion>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.MembershipTableData), "<Version>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.MembershipTableData DeepCopy(global::Orleans.MembershipTableData original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.MembershipTableData existing))
                return existing;
            var result = _activator.Create();
            context.RecordCopy(original, result);
            setField0(result, _copier0.DeepCopy(original.Members, context));
            setField1(result, original.Version);
            return result;
        }

        public Copier_MembershipTableData(global::Orleans.Serialization.Activators.IActivator<global::Orleans.MembershipTableData> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IReadOnlyList<global::System.Tuple<global::Orleans.MembershipEntry, string>>>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_MembershipEntry : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.MembershipEntry>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.MembershipEntry);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.SiloAddress);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.SiloStatus);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_SiloStatus _codec1;
        private readonly global::System.Type _type2 = typeof(global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>> _codec2;
        public Codec_MembershipEntry(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_SiloStatus>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.MembershipEntry instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.SiloAddress);
            _codec1.WriteField(ref writer, 1U, _type1, instance.Status);
            _codec2.WriteField(ref writer, 1U, _type2, instance.SuspectTimes);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.ProxyPort);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.HostName);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.SiloName);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.RoleName);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.UpdateZone);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.FaultZone);
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 1U, instance.StartTime);
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 1U, instance.IAmAliveTime);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.MembershipEntry instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.SiloAddress = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.Status = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.SuspectTimes = _codec2.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.ProxyPort = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 4U)
                {
                    instance.HostName = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 5U)
                {
                    instance.SiloName = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 6U)
                {
                    instance.RoleName = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 7U)
                {
                    instance.UpdateZone = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 8U)
                {
                    instance.FaultZone = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 9U)
                {
                    instance.StartTime = global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 10U)
                {
                    instance.IAmAliveTime = global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.MembershipEntry @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.MembershipEntry ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.MembershipEntry, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.MembershipEntry();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_MembershipEntry : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.MembershipEntry>
    {
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.MembershipEntry DeepCopy(global::Orleans.MembershipEntry original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.MembershipEntry existing))
                return existing;
            var result = new global::Orleans.MembershipEntry();
            context.RecordCopy(original, result);
            result.SiloAddress = original.SiloAddress;
            result.Status = original.Status;
            result.SuspectTimes = _copier0.DeepCopy(original.SuspectTimes, context);
            result.ProxyPort = original.ProxyPort;
            result.HostName = original.HostName;
            result.SiloName = original.SiloName;
            result.RoleName = original.RoleName;
            result.UpdateZone = original.UpdateZone;
            result.FaultZone = original.FaultZone;
            result.StartTime = original.StartTime;
            result.IAmAliveTime = original.IAmAliveTime;
            return result;
        }

        public Copier_MembershipEntry(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_MembershipEntry : global::Orleans.Serialization.Activators.IActivator<global::Orleans.MembershipEntry>
    {
        public global::Orleans.MembershipEntry Create() => new global::Orleans.MembershipEntry();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ISiloControl_GrainReference_1422B0B7 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_1422B0B7>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_1422B0B7);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_1422B0B7 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_1422B0B7 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_1422B0B7 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_1422B0B7 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_1422B0B7, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_1422B0B7();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ISiloControl_GrainReference_1422B0B7 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_1422B0B7>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_1422B0B7 DeepCopy(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_1422B0B7 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_1422B0B7();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ISiloControl_GrainReference_F388CED1 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F388CED1>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F388CED1);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F388CED1 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F388CED1 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F388CED1 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F388CED1 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F388CED1, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F388CED1();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ISiloControl_GrainReference_F388CED1 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F388CED1>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F388CED1 DeepCopy(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F388CED1 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F388CED1();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ISiloControl_GrainReference_45D07D09 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45D07D09>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45D07D09);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45D07D09 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.TimeSpanCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45D07D09 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.TimeSpanCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45D07D09 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45D07D09 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45D07D09, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45D07D09();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ISiloControl_GrainReference_45D07D09 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45D07D09>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45D07D09 DeepCopy(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45D07D09 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45D07D09();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ISiloControl_GrainReference_0C7DBD0C : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_0C7DBD0C>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_0C7DBD0C);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_0C7DBD0C instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_0C7DBD0C instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_0C7DBD0C @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_0C7DBD0C ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_0C7DBD0C, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_0C7DBD0C();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ISiloControl_GrainReference_0C7DBD0C : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_0C7DBD0C>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_0C7DBD0C DeepCopy(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_0C7DBD0C original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_0C7DBD0C();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ISiloControl_GrainReference_F18EAF24 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F18EAF24>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F18EAF24);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F18EAF24 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F18EAF24 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F18EAF24 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F18EAF24 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F18EAF24, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F18EAF24();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ISiloControl_GrainReference_F18EAF24 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F18EAF24>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F18EAF24 DeepCopy(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F18EAF24 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F18EAF24();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ISiloControl_GrainReference_FF707A30 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_FF707A30>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_FF707A30);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_FF707A30 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_FF707A30 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_FF707A30 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_FF707A30 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_FF707A30, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_FF707A30();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ISiloControl_GrainReference_FF707A30 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_FF707A30>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_FF707A30 DeepCopy(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_FF707A30 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_FF707A30();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ISiloControl_GrainReference_B0F4C24B : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_B0F4C24B>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_B0F4C24B);
        private readonly global::System.Type _type0 = typeof(string[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<string> _codec0;
        public Codec_Invokable_ISiloControl_GrainReference_B0F4C24B(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<string>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_B0F4C24B instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_B0F4C24B instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_B0F4C24B @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_B0F4C24B ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_B0F4C24B, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_B0F4C24B();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ISiloControl_GrainReference_B0F4C24B : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_B0F4C24B>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<string> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_B0F4C24B DeepCopy(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_B0F4C24B original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_B0F4C24B();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_ISiloControl_GrainReference_B0F4C24B(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<string>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ISiloControl_GrainReference_6DE16EF7 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_6DE16EF7>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_6DE16EF7);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_6DE16EF7 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_6DE16EF7 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_6DE16EF7 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_6DE16EF7 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_6DE16EF7, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_6DE16EF7();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ISiloControl_GrainReference_6DE16EF7 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_6DE16EF7>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_6DE16EF7 DeepCopy(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_6DE16EF7 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_6DE16EF7();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ISiloControl_GrainReference_45172562 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45172562>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45172562);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainId _codec0;
        public Codec_Invokable_ISiloControl_GrainReference_45172562(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainId>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45172562 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45172562 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45172562 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45172562 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45172562, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45172562();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ISiloControl_GrainReference_45172562 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45172562>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45172562 DeepCopy(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45172562 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45172562();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ISiloControl_GrainReference_C4C370A5 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_C4C370A5>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_C4C370A5);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_C4C370A5 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_C4C370A5 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_C4C370A5 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_C4C370A5 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_C4C370A5, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_C4C370A5();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ISiloControl_GrainReference_C4C370A5 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_C4C370A5>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_C4C370A5 DeepCopy(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_C4C370A5 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_C4C370A5();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ISiloControl_GrainReference_355CA3FA_1<T> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_355CA3FA_1<T>> where T : global::Orleans.Providers.IControllable
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_355CA3FA_1<T>);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_355CA3FA_1<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.arg1);
            global::Orleans.Serialization.Codecs.ObjectCodec.WriteField(ref writer, 1U, instance.arg2);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_355CA3FA_1<T> instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.arg2 = global::Orleans.Serialization.Codecs.ObjectCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_355CA3FA_1<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_355CA3FA_1<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_355CA3FA_1<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_355CA3FA_1<T>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ISiloControl_GrainReference_355CA3FA_1<T> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_355CA3FA_1<T>> where T : global::Orleans.Providers.IControllable
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_355CA3FA_1<T> DeepCopy(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_355CA3FA_1<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_355CA3FA_1<T>();
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            result.arg2 = global::Orleans.Serialization.Codecs.ObjectCopier.DeepCopy(original.arg2, context);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ISiloControl_GrainReference_85797C87 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_85797C87>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_85797C87);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainType);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainType _codec0;
        public Codec_Invokable_ISiloControl_GrainReference_85797C87(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainType>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_85797C87 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_85797C87 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_85797C87 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_85797C87 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_85797C87, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_85797C87();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ISiloControl_GrainReference_85797C87 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_85797C87>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_85797C87 DeepCopy(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_85797C87 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_85797C87();
            result.arg0 = original.arg0;
            return result;
        }
    }
}

namespace OrleansCodeGen.Orleans.Placement.Repartitioning
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget), "A6EE4757")]
    internal sealed class Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757 : global::Orleans.Runtime.Request
    {
        global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget), "TriggerExchangeRequest", null, null);
        private static readonly global::System.TimeSpan _responseTimeoutValue = global::System.TimeSpan.FromTicks(6000000000L);
        public override global::System.TimeSpan? GetDefaultResponseTimeout() => _responseTimeoutValue;
        public override string GetMethodName() => "TriggerExchangeRequest";
        public override string GetInterfaceName() => "Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget";
        public override string GetActivityName() => "IActivationRepartitionerSystemTarget/TriggerExchangeRequest";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.ValueTask InvokeInner() => target.TriggerExchangeRequest();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget), "9D8EDC44")]
    internal sealed class Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44 : global::Orleans.Runtime.Request<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse>
    {
        public global::Orleans.Placement.Repartitioning.AcceptExchangeRequest arg0;
        global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget), "AcceptExchangeRequest", null, new[] { typeof(global::Orleans.Placement.Repartitioning.AcceptExchangeRequest) });
        private static readonly global::System.TimeSpan _responseTimeoutValue = global::System.TimeSpan.FromTicks(6000000000L);
        public override global::System.TimeSpan? GetDefaultResponseTimeout() => _responseTimeoutValue;
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "AcceptExchangeRequest";
        public override string GetInterfaceName() => "Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget";
        public override string GetActivityName() => "IActivationRepartitionerSystemTarget/AcceptExchangeRequest";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Placement.Repartitioning.AcceptExchangeRequest)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.ValueTask<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse> InvokeInner() => target.AcceptExchangeRequest(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget), "21852A09")]
    internal sealed class Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09 : global::Orleans.Runtime.Request
    {
        global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget), "ResetCounters", null, null);
        public override string GetMethodName() => "ResetCounters";
        public override string GetInterfaceName() => "Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget";
        public override string GetActivityName() => "IActivationRepartitionerSystemTarget/ResetCounters";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.ValueTask InvokeInner() => target.ResetCounters();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget), "9FB525F3")]
    internal sealed class Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3 : global::Orleans.Runtime.Request<int>
    {
        global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget), "GetActivationCount", null, null);
        public override string GetMethodName() => "GetActivationCount";
        public override string GetInterfaceName() => "Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget";
        public override string GetActivityName() => "IActivationRepartitionerSystemTarget/GetActivationCount";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.ValueTask<int> InvokeInner() => target.GetActivationCount();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget), "135356E5")]
    internal sealed class Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5 : global::Orleans.Runtime.Request
    {
        public int arg0;
        global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget), "SetActivationCountOffset", null, new[] { typeof(int) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "SetActivationCountOffset";
        public override string GetInterfaceName() => "Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget";
        public override string GetActivityName() => "IActivationRepartitionerSystemTarget/SetActivationCountOffset";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (int)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.ValueTask InvokeInner() => target.SetActivationCountOffset(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget), "C4497899")]
    internal sealed class Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899 : global::Orleans.Runtime.Request<global::System.Collections.Immutable.ImmutableArray<(global::Orleans.Placement.Repartitioning.Edge, ulong)>>
    {
        global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget), "GetGrainCallFrequencies", null, null);
        public override string GetMethodName() => "GetGrainCallFrequencies";
        public override string GetInterfaceName() => "Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget";
        public override string GetActivityName() => "IActivationRepartitionerSystemTarget/GetGrainCallFrequencies";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.ValueTask<global::System.Collections.Immutable.ImmutableArray<(global::Orleans.Placement.Repartitioning.Edge, ulong)>> InvokeInner() => target.GetGrainCallFrequencies();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget), "11731652")]
    internal sealed class Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652 : global::Orleans.Runtime.Request
    {
        global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget), "FlushBuffers", null, null);
        public override string GetMethodName() => "FlushBuffers";
        public override string GetInterfaceName() => "Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget";
        public override string GetActivityName() => "IActivationRepartitionerSystemTarget/FlushBuffers";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.ValueTask InvokeInner() => target.FlushBuffers();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IActivationRepartitionerSystemTarget : global::Orleans.Runtime.GrainReference, global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget
    {
        public Proxy_IActivationRepartitionerSystemTarget(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.ValueTask global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget.TriggerExchangeRequest()
        {
            var request = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757();
            return base.InvokeAsync(request);
        }

        global::System.Threading.Tasks.ValueTask<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse> global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget.AcceptExchangeRequest(global::Orleans.Placement.Repartitioning.AcceptExchangeRequest arg0)
        {
            var request = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44();
            request.arg0 = arg0;
            return base.InvokeAsync<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse>(request);
        }

        global::System.Threading.Tasks.ValueTask global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget.ResetCounters()
        {
            var request = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09();
            return base.InvokeAsync(request);
        }

        global::System.Threading.Tasks.ValueTask<int> global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget.GetActivationCount()
        {
            var request = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3();
            return base.InvokeAsync<int>(request);
        }

        global::System.Threading.Tasks.ValueTask global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget.SetActivationCountOffset(int arg0)
        {
            var request = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5();
            request.arg0 = arg0;
            return base.InvokeAsync(request);
        }

        global::System.Threading.Tasks.ValueTask<global::System.Collections.Immutable.ImmutableArray<(global::Orleans.Placement.Repartitioning.Edge, ulong)>> global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget.GetGrainCallFrequencies()
        {
            var request = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899();
            return base.InvokeAsync<global::System.Collections.Immutable.ImmutableArray<(global::Orleans.Placement.Repartitioning.Edge, ulong)>>(request);
        }

        global::System.Threading.Tasks.ValueTask global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget.FlushBuffers()
        {
            var request = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652();
            return base.InvokeAsync(request);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757 DeepCopy(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Placement.Repartitioning.AcceptExchangeRequest);
        private readonly OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_AcceptExchangeRequest _codec0;
        public Codec_Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_AcceptExchangeRequest>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44 DeepCopy(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09 DeepCopy(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3 DeepCopy(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5 DeepCopy(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899 DeepCopy(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652 DeepCopy(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Edge : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Placement.Repartitioning.Edge>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Placement.Repartitioning.Edge>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Placement.Repartitioning.Edge);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Placement.Repartitioning.EdgeVertex);
        private readonly OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_EdgeVertex _codec0;
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Placement.Repartitioning.Edge, global::Orleans.Placement.Repartitioning.EdgeVertex> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Placement.Repartitioning.Edge, global::Orleans.Placement.Repartitioning.EdgeVertex>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Placement.Repartitioning.Edge), "<Source>k__BackingField");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Placement.Repartitioning.Edge, global::Orleans.Placement.Repartitioning.EdgeVertex> setField1 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Placement.Repartitioning.Edge, global::Orleans.Placement.Repartitioning.EdgeVertex>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Placement.Repartitioning.Edge), "<Target>k__BackingField");
        public Codec_Edge(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_EdgeVertex>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Placement.Repartitioning.Edge instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Source);
            _codec0.WriteField(ref writer, 1U, _type0, instance.Target);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Placement.Repartitioning.Edge instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(ref instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(ref instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Placement.Repartitioning.Edge @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Placement.Repartitioning.Edge ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Placement.Repartitioning.Edge);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_EdgeVertex : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Placement.Repartitioning.EdgeVertex>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Placement.Repartitioning.EdgeVertex>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Placement.Repartitioning.EdgeVertex);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainId _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.SiloAddress);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress> _codec1;
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Placement.Repartitioning.EdgeVertex, global::Orleans.Runtime.GrainId> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Placement.Repartitioning.EdgeVertex, global::Orleans.Runtime.GrainId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Placement.Repartitioning.EdgeVertex), "Id");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Placement.Repartitioning.EdgeVertex, bool> setField1 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Placement.Repartitioning.EdgeVertex, bool>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Placement.Repartitioning.EdgeVertex), "IsMigratable");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Placement.Repartitioning.EdgeVertex, global::Orleans.Runtime.SiloAddress> setField2 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Placement.Repartitioning.EdgeVertex, global::Orleans.Runtime.SiloAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Placement.Repartitioning.EdgeVertex), "Silo");
        public Codec_EdgeVertex(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainId>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Placement.Repartitioning.EdgeVertex instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Id);
            _codec1.WriteField(ref writer, 1U, _type1, instance.Silo);
            global::Orleans.Serialization.Codecs.BoolCodec.WriteField(ref writer, 1U, instance.IsMigratable);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Placement.Repartitioning.EdgeVertex instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(ref instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField2(ref instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField1(ref instance, global::Orleans.Serialization.Codecs.BoolCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Placement.Repartitioning.EdgeVertex @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Placement.Repartitioning.EdgeVertex ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Placement.Repartitioning.EdgeVertex);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_CandidateVertex : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Placement.Repartitioning.CandidateVertex>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Placement.Repartitioning.CandidateVertex);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Immutable.ImmutableArray<global::Orleans.Placement.Repartitioning.CandidateConnectedVertex>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableArray<global::Orleans.Placement.Repartitioning.CandidateConnectedVertex>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.GrainId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainId _codec1;
        private static readonly global::System.Action<global::Orleans.Placement.Repartitioning.CandidateVertex, global::System.Collections.Immutable.ImmutableArray<global::Orleans.Placement.Repartitioning.CandidateConnectedVertex>> setField1 = (global::System.Action<global::Orleans.Placement.Repartitioning.CandidateVertex, global::System.Collections.Immutable.ImmutableArray<global::Orleans.Placement.Repartitioning.CandidateConnectedVertex>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Placement.Repartitioning.CandidateVertex), "<ConnectedVertices>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Placement.Repartitioning.CandidateVertex, global::Orleans.Runtime.GrainId> setField2 = (global::System.Action<global::Orleans.Placement.Repartitioning.CandidateVertex, global::Orleans.Runtime.GrainId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Placement.Repartitioning.CandidateVertex), "<Id>k__BackingField");
        public Codec_CandidateVertex(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableArray<global::Orleans.Placement.Repartitioning.CandidateConnectedVertex>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainId>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Placement.Repartitioning.CandidateVertex instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, instance.Id);
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 1U, instance.AccumulatedTransferScore);
            _codec0.WriteField(ref writer, 1U, _type0, instance.ConnectedVertices);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Placement.Repartitioning.CandidateVertex instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField2(instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.AccumulatedTransferScore = global::Orleans.Serialization.Codecs.Int64Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField1(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Placement.Repartitioning.CandidateVertex @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Placement.Repartitioning.CandidateVertex ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Placement.Repartitioning.CandidateVertex, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Placement.Repartitioning.CandidateVertex();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_CandidateVertex : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Placement.Repartitioning.CandidateVertex>
    {
        private static readonly global::System.Action<global::Orleans.Placement.Repartitioning.CandidateVertex, global::System.Collections.Immutable.ImmutableArray<global::Orleans.Placement.Repartitioning.CandidateConnectedVertex>> setField1 = (global::System.Action<global::Orleans.Placement.Repartitioning.CandidateVertex, global::System.Collections.Immutable.ImmutableArray<global::Orleans.Placement.Repartitioning.CandidateConnectedVertex>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Placement.Repartitioning.CandidateVertex), "<ConnectedVertices>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Placement.Repartitioning.CandidateVertex, global::Orleans.Runtime.GrainId> setField2 = (global::System.Action<global::Orleans.Placement.Repartitioning.CandidateVertex, global::Orleans.Runtime.GrainId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Placement.Repartitioning.CandidateVertex), "<Id>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Placement.Repartitioning.CandidateVertex DeepCopy(global::Orleans.Placement.Repartitioning.CandidateVertex original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Placement.Repartitioning.CandidateVertex existing))
                return existing;
            var result = new global::Orleans.Placement.Repartitioning.CandidateVertex();
            context.RecordCopy(original, result);
            setField2(result, original.Id);
            result.AccumulatedTransferScore = original.AccumulatedTransferScore;
            setField1(result, original.ConnectedVertices);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_CandidateVertex : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Placement.Repartitioning.CandidateVertex>
    {
        public global::Orleans.Placement.Repartitioning.CandidateVertex Create() => new global::Orleans.Placement.Repartitioning.CandidateVertex();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_CandidateConnectedVertex : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Placement.Repartitioning.CandidateConnectedVertex>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Placement.Repartitioning.CandidateConnectedVertex>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Placement.Repartitioning.CandidateConnectedVertex);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainId _codec0;
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Placement.Repartitioning.CandidateConnectedVertex, global::Orleans.Runtime.GrainId> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Placement.Repartitioning.CandidateConnectedVertex, global::Orleans.Runtime.GrainId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Placement.Repartitioning.CandidateConnectedVertex), "<Id>k__BackingField");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Placement.Repartitioning.CandidateConnectedVertex, long> setField1 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Placement.Repartitioning.CandidateConnectedVertex, long>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Placement.Repartitioning.CandidateConnectedVertex), "<TransferScore>k__BackingField");
        public Codec_CandidateConnectedVertex(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainId>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Placement.Repartitioning.CandidateConnectedVertex instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Id);
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 1U, instance.TransferScore);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Placement.Repartitioning.CandidateConnectedVertex instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(ref instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(ref instance, global::Orleans.Serialization.Codecs.Int64Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Placement.Repartitioning.CandidateConnectedVertex @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Placement.Repartitioning.CandidateConnectedVertex ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Placement.Repartitioning.CandidateConnectedVertex);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_AcceptExchangeRequest : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Placement.Repartitioning.AcceptExchangeRequest>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Placement.Repartitioning.AcceptExchangeRequest);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Placement.Repartitioning.AcceptExchangeRequest> _activator;
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Immutable.ImmutableArray<global::Orleans.Placement.Repartitioning.CandidateVertex>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableArray<global::Orleans.Placement.Repartitioning.CandidateVertex>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.SiloAddress);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress> _codec1;
        private static readonly global::System.Action<global::Orleans.Placement.Repartitioning.AcceptExchangeRequest, int> setField0 = (global::System.Action<global::Orleans.Placement.Repartitioning.AcceptExchangeRequest, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Placement.Repartitioning.AcceptExchangeRequest), "<ActivationCountSnapshot>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Placement.Repartitioning.AcceptExchangeRequest, global::System.Collections.Immutable.ImmutableArray<global::Orleans.Placement.Repartitioning.CandidateVertex>> setField1 = (global::System.Action<global::Orleans.Placement.Repartitioning.AcceptExchangeRequest, global::System.Collections.Immutable.ImmutableArray<global::Orleans.Placement.Repartitioning.CandidateVertex>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Placement.Repartitioning.AcceptExchangeRequest), "<ExchangeSet>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Placement.Repartitioning.AcceptExchangeRequest, global::Orleans.Runtime.SiloAddress> setField2 = (global::System.Action<global::Orleans.Placement.Repartitioning.AcceptExchangeRequest, global::Orleans.Runtime.SiloAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Placement.Repartitioning.AcceptExchangeRequest), "<SendingSilo>k__BackingField");
        public Codec_AcceptExchangeRequest(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Placement.Repartitioning.AcceptExchangeRequest> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableArray<global::Orleans.Placement.Repartitioning.CandidateVertex>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Placement.Repartitioning.AcceptExchangeRequest instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, instance.SendingSilo);
            _codec0.WriteField(ref writer, 1U, _type0, instance.ExchangeSet);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.ActivationCountSnapshot);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Placement.Repartitioning.AcceptExchangeRequest instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField2(instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Placement.Repartitioning.AcceptExchangeRequest @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Placement.Repartitioning.AcceptExchangeRequest ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Placement.Repartitioning.AcceptExchangeRequest, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_AcceptExchangeResponse : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Placement.Repartitioning.AcceptExchangeResponse);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse> _activator;
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Immutable.ImmutableArray<global::Orleans.Runtime.GrainId>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableArray<global::Orleans.Runtime.GrainId>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Placement.Repartitioning.AcceptExchangeResponse.ResponseType);
        private readonly OrleansCodeGen.Orleans.Placement.Repartitioning.AcceptExchangeResponse.Codec_ResponseType _codec1;
        private static readonly global::System.Action<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse, global::System.Collections.Immutable.ImmutableArray<global::Orleans.Runtime.GrainId>> setField0 = (global::System.Action<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse, global::System.Collections.Immutable.ImmutableArray<global::Orleans.Runtime.GrainId>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Placement.Repartitioning.AcceptExchangeResponse), "<AcceptedGrainIds>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse, global::System.Collections.Immutable.ImmutableArray<global::Orleans.Runtime.GrainId>> setField1 = (global::System.Action<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse, global::System.Collections.Immutable.ImmutableArray<global::Orleans.Runtime.GrainId>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Placement.Repartitioning.AcceptExchangeResponse), "<GivenGrainIds>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse, global::Orleans.Placement.Repartitioning.AcceptExchangeResponse.ResponseType> setField2 = (global::System.Action<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse, global::Orleans.Placement.Repartitioning.AcceptExchangeResponse.ResponseType>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Placement.Repartitioning.AcceptExchangeResponse), "<Type>k__BackingField");
        public Codec_AcceptExchangeResponse(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableArray<global::Orleans.Runtime.GrainId>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Placement.Repartitioning.AcceptExchangeResponse.Codec_ResponseType>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Placement.Repartitioning.AcceptExchangeResponse instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, instance.Type);
            _codec0.WriteField(ref writer, 1U, _type0, instance.AcceptedGrainIds);
            _codec0.WriteField(ref writer, 1U, _type0, instance.GivenGrainIds);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Placement.Repartitioning.AcceptExchangeResponse instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField2(instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField0(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField1(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Placement.Repartitioning.AcceptExchangeResponse @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Placement.Repartitioning.AcceptExchangeResponse ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }
}

namespace OrleansCodeGen.Orleans.Storage
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Storage.IMemoryStorageGrain), "45659318")]
    public sealed class Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T> : global::Orleans.Runtime.TaskRequest<global::Orleans.IGrainState<T>>
    {
        public global::System.String arg0;
        global::Orleans.Storage.IMemoryStorageGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Storage.IMemoryStorageGrain), "ReadStateAsync", new[] { typeof(T) }, new[] { typeof(global::System.String) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "ReadStateAsync<T>";
        public override string GetInterfaceName() => "Orleans.Storage.IMemoryStorageGrain";
        public override string GetActivityName() => "IMemoryStorageGrain/ReadStateAsync<T>";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Storage.IMemoryStorageGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Storage.IMemoryStorageGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::System.String)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.IGrainState<T>> InvokeInner() => target.ReadStateAsync<T>(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Storage.IMemoryStorageGrain), "7CC6CA25")]
    public sealed class Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T> : global::Orleans.Runtime.TaskRequest<global::System.String>
    {
        public global::System.String arg0;
        public global::Orleans.IGrainState<T> arg1;
        global::Orleans.Storage.IMemoryStorageGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Storage.IMemoryStorageGrain), "WriteStateAsync", new[] { typeof(T) }, new[] { typeof(global::System.String), typeof(global::Orleans.IGrainState<T>) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "WriteStateAsync<T>";
        public override string GetInterfaceName() => "Orleans.Storage.IMemoryStorageGrain";
        public override string GetActivityName() => "IMemoryStorageGrain/WriteStateAsync<T>";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Storage.IMemoryStorageGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Storage.IMemoryStorageGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                case 1:
                    return arg1;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::System.String)value;
                    return;
                case 1:
                    arg1 = (global::Orleans.IGrainState<T>)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::System.String> InvokeInner() => target.WriteStateAsync<T>(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Storage.IMemoryStorageGrain), "B7CADD03")]
    public sealed class Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T> : global::Orleans.Runtime.TaskRequest
    {
        public global::System.String arg0;
        public global::System.String arg1;
        global::Orleans.Storage.IMemoryStorageGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Storage.IMemoryStorageGrain), "DeleteStateAsync", new[] { typeof(T) }, new[] { typeof(global::System.String), typeof(global::System.String) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "DeleteStateAsync<T>";
        public override string GetInterfaceName() => "Orleans.Storage.IMemoryStorageGrain";
        public override string GetActivityName() => "IMemoryStorageGrain/DeleteStateAsync<T>";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Storage.IMemoryStorageGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Storage.IMemoryStorageGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                case 1:
                    return arg1;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::System.String)value;
                    return;
                case 1:
                    arg1 = (global::System.String)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.DeleteStateAsync<T>(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IMemoryStorageGrain : global::Orleans.Runtime.GrainReference, global::Orleans.Storage.IMemoryStorageGrain
    {
        public Proxy_IMemoryStorageGrain(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.Task<global::Orleans.IGrainState<T>> global::Orleans.Storage.IMemoryStorageGrain.ReadStateAsync<T>(global::System.String arg0)
        {
            var request = new OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T>();
            request.arg0 = arg0;
            return base.InvokeAsync<global::Orleans.IGrainState<T>>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::System.String> global::Orleans.Storage.IMemoryStorageGrain.WriteStateAsync<T>(global::System.String arg0, global::Orleans.IGrainState<T> arg1)
        {
            var request = new OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T>();
            request.arg0 = arg0;
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg1 = copyContext.DeepCopy(arg1);
            return base.InvokeAsync<global::System.String>(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Storage.IMemoryStorageGrain.DeleteStateAsync<T>(global::System.String arg0, global::System.String arg1)
        {
            var request = new OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T>();
            request.arg0 = arg0;
            request.arg1 = arg1;
            return base.InvokeAsync(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_InconsistentStateException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Storage.InconsistentStateException>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Storage.InconsistentStateException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Storage.InconsistentStateException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        private static readonly global::System.Action<global::Orleans.Storage.InconsistentStateException, string> setField0 = (global::System.Action<global::Orleans.Storage.InconsistentStateException, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Storage.InconsistentStateException), "<CurrentEtag>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Storage.InconsistentStateException, string> setField2 = (global::System.Action<global::Orleans.Storage.InconsistentStateException, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Storage.InconsistentStateException), "<StoredEtag>k__BackingField");
        public Codec_InconsistentStateException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Storage.InconsistentStateException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.BoolCodec.WriteField(ref writer, 0U, instance.IsSourceActivation);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.StoredEtag);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.CurrentEtag);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Storage.InconsistentStateException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.IsSourceActivation = global::Orleans.Serialization.Codecs.BoolCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField2(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Storage.InconsistentStateException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Storage.InconsistentStateException))
            {
                if (@value is null)
                {
                    ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                    return;
                }

                ReferenceCodec.MarkValueField(writer.Session);
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Storage.InconsistentStateException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Storage.InconsistentStateException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Storage.InconsistentStateException();
                ReferenceCodec.MarkValueField(reader.Session);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Storage.InconsistentStateException>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_InconsistentStateException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Storage.InconsistentStateException, global::Orleans.Runtime.OrleansException>
    {
        private static readonly global::System.Action<global::Orleans.Storage.InconsistentStateException, string> setField0 = (global::System.Action<global::Orleans.Storage.InconsistentStateException, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Storage.InconsistentStateException), "<CurrentEtag>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Storage.InconsistentStateException, string> setField2 = (global::System.Action<global::Orleans.Storage.InconsistentStateException, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Storage.InconsistentStateException), "<StoredEtag>k__BackingField");
        public Copier_InconsistentStateException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void DeepCopy(global::Orleans.Storage.InconsistentStateException input, global::Orleans.Storage.InconsistentStateException output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            base.DeepCopy(input, output, context);
            output.IsSourceActivation = input.IsSourceActivation;
            setField2(output, input.StoredEtag);
            setField0(output, input.CurrentEtag);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_InconsistentStateException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Storage.InconsistentStateException>
    {
        public global::Orleans.Storage.InconsistentStateException Create() => new global::Orleans.Storage.InconsistentStateException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T>);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T> instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T>>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T> DeepCopy(OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_45659318_1<T>();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T>);
        private readonly global::System.Type _type0 = typeof(global::Orleans.IGrainState<T>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.IGrainState<T>> _codec0;
        public Codec_Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.IGrainState<T>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
            _codec0.WriteField(ref writer, 1U, _type0, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T> instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.IGrainState<T>> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T> DeepCopy(OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<T>();
            result.arg0 = original.arg0;
            result.arg1 = _copier0.DeepCopy(original.arg1, context);
            return result;
        }

        public Copier_Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.IGrainState<T>>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T>);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T> instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T>>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T> DeepCopy(OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<T>();
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_BadProviderConfigException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Storage.BadProviderConfigException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Storage.BadProviderConfigException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        public Codec_BadProviderConfigException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Storage.BadProviderConfigException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Storage.BadProviderConfigException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Storage.BadProviderConfigException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Storage.BadProviderConfigException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Storage.BadProviderConfigException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Storage.BadProviderConfigException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_BadProviderConfigException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Storage.BadProviderConfigException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_BadProviderConfigException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_BadProviderConfigException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Storage.BadProviderConfigException>
    {
        public global::Orleans.Storage.BadProviderConfigException Create() => new global::Orleans.Storage.BadProviderConfigException();
    }
}

namespace OrleansCodeGen.Orleans.Runtime.Messaging
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_InvalidMessageFrameException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.Messaging.InvalidMessageFrameException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.Messaging.InvalidMessageFrameException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        public Codec_InvalidMessageFrameException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.Messaging.InvalidMessageFrameException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.Messaging.InvalidMessageFrameException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.Messaging.InvalidMessageFrameException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.Messaging.InvalidMessageFrameException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.Messaging.InvalidMessageFrameException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.Messaging.InvalidMessageFrameException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_InvalidMessageFrameException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.Messaging.InvalidMessageFrameException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_InvalidMessageFrameException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_InvalidMessageFrameException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.Messaging.InvalidMessageFrameException>
    {
        public global::Orleans.Runtime.Messaging.InvalidMessageFrameException Create() => new global::Orleans.Runtime.Messaging.InvalidMessageFrameException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_ConnectionPreamble : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.Messaging.ConnectionPreamble>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.Messaging.ConnectionPreamble);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.Messaging.NetworkProtocolVersion);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.Messaging.NetworkProtocolVersion> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.GrainId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainId _codec1;
        private readonly global::System.Type _type2 = typeof(global::Orleans.Runtime.SiloAddress);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress> _codec2;
        private static readonly global::System.Action<global::Orleans.Runtime.Messaging.ConnectionPreamble, string> setField0 = (global::System.Action<global::Orleans.Runtime.Messaging.ConnectionPreamble, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.Messaging.ConnectionPreamble), "<ClusterId>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.Messaging.ConnectionPreamble, global::Orleans.Runtime.Messaging.NetworkProtocolVersion> setField1 = (global::System.Action<global::Orleans.Runtime.Messaging.ConnectionPreamble, global::Orleans.Runtime.Messaging.NetworkProtocolVersion>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.Messaging.ConnectionPreamble), "<NetworkProtocolVersion>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.Messaging.ConnectionPreamble, global::Orleans.Runtime.GrainId> setField2 = (global::System.Action<global::Orleans.Runtime.Messaging.ConnectionPreamble, global::Orleans.Runtime.GrainId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.Messaging.ConnectionPreamble), "<NodeIdentity>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.Messaging.ConnectionPreamble, global::Orleans.Runtime.SiloAddress> setField3 = (global::System.Action<global::Orleans.Runtime.Messaging.ConnectionPreamble, global::Orleans.Runtime.SiloAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.Messaging.ConnectionPreamble), "<SiloAddress>k__BackingField");
        public Codec_ConnectionPreamble(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.Messaging.NetworkProtocolVersion>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainId>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.Messaging.ConnectionPreamble instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.NetworkProtocolVersion);
            _codec1.WriteField(ref writer, 1U, _type1, instance.NodeIdentity);
            _codec2.WriteField(ref writer, 1U, _type2, instance.SiloAddress);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.ClusterId);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.Messaging.ConnectionPreamble instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField1(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField2(instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField3(instance, _codec2.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.Messaging.ConnectionPreamble @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.Messaging.ConnectionPreamble ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.Messaging.ConnectionPreamble, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.Messaging.ConnectionPreamble();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_ConnectionPreamble : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.Messaging.ConnectionPreamble>
    {
        public global::Orleans.Runtime.Messaging.ConnectionPreamble Create() => new global::Orleans.Runtime.Messaging.ConnectionPreamble();
    }
}

namespace OrleansCodeGen.Orleans.Runtime.Message
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Directions : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.Message.Directions>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.Message.Directions);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.Message.Directions @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.ByteCodec.WriteField(ref writer, fieldIdDelta, expectedType, (byte)@value, _codecFieldType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.Message.Directions ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            return (global::Orleans.Runtime.Message.Directions)global::Orleans.Serialization.Codecs.ByteCodec.ReadValue(ref reader, field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_ResponseTypes : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.Message.ResponseTypes>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.Message.ResponseTypes);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.Message.ResponseTypes @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.ByteCodec.WriteField(ref writer, fieldIdDelta, expectedType, (byte)@value, _codecFieldType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.Message.ResponseTypes ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            return (global::Orleans.Runtime.Message.ResponseTypes)global::Orleans.Serialization.Codecs.ByteCodec.ReadValue(ref reader, field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_RejectionTypes : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.Message.RejectionTypes>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.Message.RejectionTypes);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.Message.RejectionTypes @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.ByteCodec.WriteField(ref writer, fieldIdDelta, expectedType, (byte)@value, _codecFieldType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.Message.RejectionTypes ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            return (global::Orleans.Runtime.Message.RejectionTypes)global::Orleans.Serialization.Codecs.ByteCodec.ReadValue(ref reader, field);
        }
    }
}

namespace OrleansCodeGen.Orleans.GrainDirectory
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_AddressAndTag : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.GrainDirectory.AddressAndTag>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.GrainDirectory.AddressAndTag>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.GrainDirectory.AddressAndTag);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainAddress);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainAddress _codec0;
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.GrainDirectory.AddressAndTag, global::Orleans.Runtime.GrainAddress> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.GrainDirectory.AddressAndTag, global::Orleans.Runtime.GrainAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.GrainDirectory.AddressAndTag), "Address");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.GrainDirectory.AddressAndTag, int> setField1 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.GrainDirectory.AddressAndTag, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.GrainDirectory.AddressAndTag), "VersionTag");
        public Codec_AddressAndTag(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainAddress>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.GrainDirectory.AddressAndTag instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Address);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.VersionTag);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.GrainDirectory.AddressAndTag instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(ref instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(ref instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.GrainDirectory.AddressAndTag @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.GrainDirectory.AddressAndTag ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.GrainDirectory.AddressAndTag);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }
}

namespace OrleansCodeGen.Orleans.Providers
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ProviderInitializationException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Providers.ProviderInitializationException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Providers.ProviderInitializationException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        public Codec_ProviderInitializationException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Providers.ProviderInitializationException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Providers.ProviderInitializationException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Providers.ProviderInitializationException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Providers.ProviderInitializationException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Providers.ProviderInitializationException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Providers.ProviderInitializationException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ProviderInitializationException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Providers.ProviderInitializationException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_ProviderInitializationException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_ProviderInitializationException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Providers.ProviderInitializationException>
    {
        public global::Orleans.Providers.ProviderInitializationException Create() => new global::Orleans.Providers.ProviderInitializationException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ProviderStateException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Providers.ProviderStateException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Providers.ProviderStateException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        public Codec_ProviderStateException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Providers.ProviderStateException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Providers.ProviderStateException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Providers.ProviderStateException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Providers.ProviderStateException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Providers.ProviderStateException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Providers.ProviderStateException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ProviderStateException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Providers.ProviderStateException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_ProviderStateException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_ProviderStateException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Providers.ProviderStateException>
    {
        public global::Orleans.Providers.ProviderStateException Create() => new global::Orleans.Providers.ProviderStateException();
    }
}

namespace OrleansCodeGen.Orleans.Networking.Shared
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_SocketConnectionException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Networking.Shared.SocketConnectionException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Networking.Shared.SocketConnectionException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Networking.Shared.SocketConnectionException> _activator;
        public Codec_SocketConnectionException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Networking.Shared.SocketConnectionException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Networking.Shared.SocketConnectionException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Networking.Shared.SocketConnectionException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Networking.Shared.SocketConnectionException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Networking.Shared.SocketConnectionException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Networking.Shared.SocketConnectionException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_SocketConnectionException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Networking.Shared.SocketConnectionException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_SocketConnectionException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }
}

namespace OrleansCodeGen.Orleans.Placement.Repartitioning.AcceptExchangeResponse
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_ResponseType : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse.ResponseType>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Placement.Repartitioning.AcceptExchangeResponse.ResponseType);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Placement.Repartitioning.AcceptExchangeResponse.ResponseType @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, fieldIdDelta, expectedType, (int)@value, _codecFieldType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Placement.Repartitioning.AcceptExchangeResponse.ResponseType ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            return (global::Orleans.Placement.Repartitioning.AcceptExchangeResponse.ResponseType)global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, field);
        }
    }
}

namespace OrleansCodeGen.Orleans.LeaseProviders
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_AcquiredLease : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.LeaseProviders.AcquiredLease>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.LeaseProviders.AcquiredLease);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.LeaseProviders.AcquiredLease> _activator;
        private static readonly global::System.Action<global::Orleans.LeaseProviders.AcquiredLease, global::System.TimeSpan> setField0 = (global::System.Action<global::Orleans.LeaseProviders.AcquiredLease, global::System.TimeSpan>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.LeaseProviders.AcquiredLease), "<Duration>k__BackingField");
        private static readonly global::System.Action<global::Orleans.LeaseProviders.AcquiredLease, string> setField1 = (global::System.Action<global::Orleans.LeaseProviders.AcquiredLease, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.LeaseProviders.AcquiredLease), "<ResourceKey>k__BackingField");
        private static readonly global::System.Action<global::Orleans.LeaseProviders.AcquiredLease, global::System.DateTime> setField2 = (global::System.Action<global::Orleans.LeaseProviders.AcquiredLease, global::System.DateTime>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.LeaseProviders.AcquiredLease), "<StartTimeUtc>k__BackingField");
        private static readonly global::System.Action<global::Orleans.LeaseProviders.AcquiredLease, string> setField3 = (global::System.Action<global::Orleans.LeaseProviders.AcquiredLease, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.LeaseProviders.AcquiredLease), "<Token>k__BackingField");
        public Codec_AcquiredLease(global::Orleans.Serialization.Activators.IActivator<global::Orleans.LeaseProviders.AcquiredLease> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.LeaseProviders.AcquiredLease instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.ResourceKey);
            global::Orleans.Serialization.Codecs.TimeSpanCodec.WriteField(ref writer, 1U, instance.Duration);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.Token);
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 1U, instance.StartTimeUtc);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.LeaseProviders.AcquiredLease instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.TimeSpanCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField3(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    setField2(instance, global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.LeaseProviders.AcquiredLease @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.LeaseProviders.AcquiredLease ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.LeaseProviders.AcquiredLease, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_AcquireLeaseResult : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.LeaseProviders.AcquireLeaseResult>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.LeaseProviders.AcquireLeaseResult);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.LeaseProviders.AcquireLeaseResult> _activator;
        private readonly global::System.Type _type0 = typeof(global::Orleans.LeaseProviders.AcquiredLease);
        private readonly OrleansCodeGen.Orleans.LeaseProviders.Codec_AcquiredLease _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Exception);
        private readonly global::Orleans.Serialization.ExceptionCodec _codec1;
        private readonly global::System.Type _type2 = typeof(global::Orleans.LeaseProviders.ResponseCode);
        private readonly OrleansCodeGen.Orleans.LeaseProviders.Codec_ResponseCode _codec2;
        private static readonly global::System.Action<global::Orleans.LeaseProviders.AcquireLeaseResult, global::Orleans.LeaseProviders.AcquiredLease> setField0 = (global::System.Action<global::Orleans.LeaseProviders.AcquireLeaseResult, global::Orleans.LeaseProviders.AcquiredLease>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.LeaseProviders.AcquireLeaseResult), "<AcquiredLease>k__BackingField");
        private static readonly global::System.Action<global::Orleans.LeaseProviders.AcquireLeaseResult, global::System.Exception> setField1 = (global::System.Action<global::Orleans.LeaseProviders.AcquireLeaseResult, global::System.Exception>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.LeaseProviders.AcquireLeaseResult), "<FailureException>k__BackingField");
        private static readonly global::System.Action<global::Orleans.LeaseProviders.AcquireLeaseResult, global::Orleans.LeaseProviders.ResponseCode> setField2 = (global::System.Action<global::Orleans.LeaseProviders.AcquireLeaseResult, global::Orleans.LeaseProviders.ResponseCode>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.LeaseProviders.AcquireLeaseResult), "<StatusCode>k__BackingField");
        public Codec_AcquireLeaseResult(global::Orleans.Serialization.Activators.IActivator<global::Orleans.LeaseProviders.AcquireLeaseResult> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.LeaseProviders.Codec_AcquiredLease>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.ExceptionCodec>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.LeaseProviders.Codec_ResponseCode>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.LeaseProviders.AcquireLeaseResult instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.AcquiredLease);
            _codec2.WriteField(ref writer, 1U, _type2, instance.StatusCode);
            _codec1.WriteField(ref writer, 1U, _type1, instance.FailureException);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.LeaseProviders.AcquireLeaseResult instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField2(instance, _codec2.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField1(instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.LeaseProviders.AcquireLeaseResult @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.LeaseProviders.AcquireLeaseResult ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.LeaseProviders.AcquireLeaseResult, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ResponseCode : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.LeaseProviders.ResponseCode>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.LeaseProviders.ResponseCode);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.LeaseProviders.ResponseCode @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, fieldIdDelta, expectedType, (int)@value, _codecFieldType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.LeaseProviders.ResponseCode ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            return (global::Orleans.LeaseProviders.ResponseCode)global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_LeaseRequest : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.LeaseProviders.LeaseRequest>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.LeaseProviders.LeaseRequest);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.LeaseProviders.LeaseRequest> _activator;
        private static readonly global::System.Action<global::Orleans.LeaseProviders.LeaseRequest, global::System.TimeSpan> setField0 = (global::System.Action<global::Orleans.LeaseProviders.LeaseRequest, global::System.TimeSpan>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.LeaseProviders.LeaseRequest), "<Duration>k__BackingField");
        private static readonly global::System.Action<global::Orleans.LeaseProviders.LeaseRequest, string> setField1 = (global::System.Action<global::Orleans.LeaseProviders.LeaseRequest, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.LeaseProviders.LeaseRequest), "<ResourceKey>k__BackingField");
        public Codec_LeaseRequest(global::Orleans.Serialization.Activators.IActivator<global::Orleans.LeaseProviders.LeaseRequest> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.LeaseProviders.LeaseRequest instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.ResourceKey);
            global::Orleans.Serialization.Codecs.TimeSpanCodec.WriteField(ref writer, 1U, instance.Duration);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.LeaseProviders.LeaseRequest instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.TimeSpanCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.LeaseProviders.LeaseRequest @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.LeaseProviders.LeaseRequest ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.LeaseProviders.LeaseRequest, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }
}

namespace OrleansCodeGen.OrleansCore
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Metadata_OrleansCore : global::Orleans.Serialization.Configuration.TypeManifestProviderBase
    {
        protected override void ConfigureInner(global::Orleans.Serialization.Configuration.TypeManifestOptions config)
        {
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.ClientObservers.Codec_Invokable_IClientGatewayObserver_GrainReference_AFB768FD));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_GrainState<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_InvalidSchedulingContextException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_MigrationContext));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_ClusterManifestUpdate));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Messaging.Codec_InvalidMessageFrameException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Messaging.Codec_ConnectionPreamble));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_CorrelationId));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Message.Codec_Directions));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Message.Codec_ResponseTypes));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Message.Codec_RejectionTypes));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_RejectionResponse));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_StatusResponse));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_GrainCancellationTokenSurrogate));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_MembershipTableSnapshot));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_SingleRange));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_GeneralMultiRange));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_SiloStatus));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_SiloRuntimeStatistics));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_SimpleGrainStatistic));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_DetailedGrainStatistic));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_DetailedGrainReport));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_ICatalog_GrainReference_C4A56D7C));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_4C0864C2));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_CC6CCBC3));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_5922EB76));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_329F9A1B));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_54E6D1D1));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_B761B345));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_2D761B36));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_3CFF788C));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_ACCE9D6A));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_0A1C0D82));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_AEDE93F6));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_D7365B43));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_F67965CC_1<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_317D82B6));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_3DB7923B));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_0F06E027));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IManagementGrain_GrainReference_54FE0FEC));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_IVersionManager_GrainReference_8F5C15A9));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_IVersionManager_GrainReference_4AAEAFCE));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_IVersionManager_GrainReference_C01C4EE8));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_IVersionManager_GrainReference_90AB9D5E));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_GrainCallFrequency));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IMembershipService_GrainReference_22A02D46));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IMembershipService_GrainReference_39AB7071));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IMembershipService_GrainReference_0F85FAAF));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_IndirectProbeResponse));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.GrainDirectory.Codec_AddressAndTag));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Providers.Codec_ProviderInitializationException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Providers.Codec_ProviderStateException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Networking.Shared.Codec_SocketConnectionException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_Edge));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_EdgeVertex));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_CandidateVertex));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_CandidateConnectedVertex));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_AcceptExchangeRequest));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Codec_AcceptExchangeResponse));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.AcceptExchangeResponse.Codec_ResponseType));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Storage.Codec_InconsistentStateException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Storage.Codec_Invokable_IMemoryStorageGrain_GrainReference_45659318_1<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Storage.Codec_Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Storage.Codec_Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Storage.Codec_BadProviderConfigException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.LeaseProviders.Codec_AcquiredLease));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.LeaseProviders.Codec_AcquireLeaseResult));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.LeaseProviders.Codec_ResponseCode));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.LeaseProviders.Codec_LeaseRequest));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_IMembershipTable_GrainReference_FB89E5E9));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_IMembershipTable_GrainReference_BF899C85));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_IMembershipTable_GrainReference_7A519C2E));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_IMembershipTable_GrainReference_D851FB33));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_IMembershipTable_GrainReference_00BCE16F));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_IMembershipTable_GrainReference_FEF3AC5A));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_IMembershipTable_GrainReference_E06D3DBC));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_IMembershipTable_GrainReference_B1A52D2B));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_TableVersion));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_MembershipTableData));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_MembershipEntry));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_ISiloControl_GrainReference_1422B0B7));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_ISiloControl_GrainReference_F388CED1));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_ISiloControl_GrainReference_45D07D09));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_ISiloControl_GrainReference_0C7DBD0C));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_ISiloControl_GrainReference_F18EAF24));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_ISiloControl_GrainReference_FF707A30));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_ISiloControl_GrainReference_B0F4C24B));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_ISiloControl_GrainReference_6DE16EF7));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_ISiloControl_GrainReference_45172562));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_ISiloControl_GrainReference_C4C370A5));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_ISiloControl_GrainReference_355CA3FA_1<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_Invokable_ISiloControl_GrainReference_85797C87));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.ClientObservers.Copier_Invokable_IClientGatewayObserver_GrainReference_AFB768FD));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_GrainState<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_InvalidSchedulingContextException));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.MigrationContext>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_ClusterManifestUpdate));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Messaging.Copier_InvalidMessageFrameException));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.Messaging.ConnectionPreamble>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.CorrelationId>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.RejectionResponse>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.StatusResponse>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.GrainCancellationTokenSurrogate>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.MembershipTableSnapshot>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.SingleRange>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.GeneralMultiRange>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.SiloRuntimeStatistics>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.SimpleGrainStatistic>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.DetailedGrainStatistic>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.DetailedGrainReport>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_ICatalog_GrainReference_C4A56D7C));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_4C0864C2));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_CC6CCBC3));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_5922EB76));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_329F9A1B));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_54E6D1D1));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_B761B345));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_2D761B36));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_3CFF788C));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_ACCE9D6A));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_0A1C0D82));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_AEDE93F6));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_D7365B43));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_F67965CC_1<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_317D82B6));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_3DB7923B));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_0F06E027));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IManagementGrain_GrainReference_54FE0FEC));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_IVersionManager_GrainReference_8F5C15A9));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_IVersionManager_GrainReference_4AAEAFCE));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_IVersionManager_GrainReference_C01C4EE8));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_IVersionManager_GrainReference_90AB9D5E));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.GrainCallFrequency>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IMembershipService_GrainReference_22A02D46));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IMembershipService_GrainReference_39AB7071));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IMembershipService_GrainReference_0F85FAAF));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.IndirectProbeResponse>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.GrainDirectory.AddressAndTag>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Providers.Copier_ProviderInitializationException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Providers.Copier_ProviderStateException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Networking.Shared.Copier_SocketConnectionException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Copier_Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Copier_Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Copier_Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Copier_Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Copier_Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Copier_Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Copier_Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Placement.Repartitioning.Edge>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Placement.Repartitioning.EdgeVertex>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Copier_CandidateVertex));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Placement.Repartitioning.CandidateConnectedVertex>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Placement.Repartitioning.AcceptExchangeRequest>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Placement.Repartitioning.AcceptExchangeResponse>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Storage.Copier_InconsistentStateException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Storage.Copier_Invokable_IMemoryStorageGrain_GrainReference_45659318_1<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Storage.Copier_Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Storage.Copier_Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Storage.Copier_BadProviderConfigException));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.LeaseProviders.AcquiredLease>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.LeaseProviders.AcquireLeaseResult>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.LeaseProviders.LeaseRequest>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_IMembershipTable_GrainReference_FB89E5E9));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_IMembershipTable_GrainReference_BF899C85));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_IMembershipTable_GrainReference_7A519C2E));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_IMembershipTable_GrainReference_D851FB33));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_IMembershipTable_GrainReference_00BCE16F));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_IMembershipTable_GrainReference_FEF3AC5A));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_IMembershipTable_GrainReference_E06D3DBC));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_IMembershipTable_GrainReference_B1A52D2B));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.TableVersion>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_MembershipTableData));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_MembershipEntry));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_ISiloControl_GrainReference_1422B0B7));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_ISiloControl_GrainReference_F388CED1));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_ISiloControl_GrainReference_45D07D09));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_ISiloControl_GrainReference_0C7DBD0C));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_ISiloControl_GrainReference_F18EAF24));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_ISiloControl_GrainReference_FF707A30));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_ISiloControl_GrainReference_B0F4C24B));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_ISiloControl_GrainReference_6DE16EF7));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_ISiloControl_GrainReference_45172562));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_ISiloControl_GrainReference_C4C370A5));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_ISiloControl_GrainReference_355CA3FA_1<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_Invokable_ISiloControl_GrainReference_85797C87));
            config.Serializers.Add(typeof(global::Orleans.Runtime.GrainCancellationTokenCodec));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.ClientObservers.Proxy_IClientGatewayObserver));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.Proxy_IClusterManifestSystemTarget));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.Proxy_ICatalog));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.Proxy_IDeploymentLoadPublisher));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.Proxy_IManagementGrain));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.Proxy_IMembershipService));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Proxy_IActivationRepartitionerSystemTarget));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Storage.Proxy_IMemoryStorageGrain));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Proxy_IMembershipTableSystemTarget));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Proxy_ISiloControl));
            config.Interfaces.Add(typeof(global::Orleans.ClientObservers.IClientGatewayObserver));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.IClusterManifestSystemTarget));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.ICatalog));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.IDeploymentLoadPublisher));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.IManagementGrain));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.IMembershipService));
            config.Interfaces.Add(typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget));
            config.Interfaces.Add(typeof(global::Orleans.Storage.IMemoryStorageGrain));
            config.Interfaces.Add(typeof(global::Orleans.IMembershipTableSystemTarget));
            config.Interfaces.Add(typeof(global::Orleans.ISiloControl));
            config.InterfaceImplementations.Add(typeof(global::Orleans.ClientObservers.ClientGatewayObserver));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.AsyncEnumerableGrainExtension));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Activator_GrainState<>));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Messaging.Activator_InvalidMessageFrameException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Messaging.Activator_ConnectionPreamble));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_RejectionResponse));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_SimpleGrainStatistic));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_DetailedGrainStatistic));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_DetailedGrainReport));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Providers.Activator_ProviderInitializationException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Providers.Activator_ProviderStateException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Activator_CandidateVertex));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Storage.Activator_InconsistentStateException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Storage.Activator_BadProviderConfigException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Activator_MembershipEntry));
            config.WellKnownTypeIds.Add(101U, typeof(global::Orleans.Runtime.Message));
            config.WellKnownTypeIds.Add(102U, typeof(global::Orleans.Runtime.RejectionResponse));
            config.WellKnownTypeIds.Add(103U, typeof(global::Orleans.Runtime.StatusResponse));
            config.WellKnownTypeAliases.Add("MigrationCtx", typeof(global::Orleans.Runtime.MigrationContext));
            config.WellKnownTypeAliases.Add("Orleans.Runtime.GrainCallFrequency", typeof(global::Orleans.Runtime.GrainCallFrequency));
            config.WellKnownTypeAliases.Add("IActivationRepartitionerSystemTarget", typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget));
            var n1 = config.CompoundTypeAliases.Add("inv");
            var n2 = n1.Add(typeof(global::Orleans.Runtime.GrainReference));
            var n3 = n2.Add(typeof(global::Orleans.ClientObservers.IClientGatewayObserver));
            n3.Add("AFB768FD", typeof(OrleansCodeGen.Orleans.ClientObservers.Invokable_IClientGatewayObserver_GrainReference_AFB768FD));
            var n5 = n2.Add(typeof(global::Orleans.Runtime.IClusterManifestSystemTarget));
            n5.Add("40D39F85", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_40D39F85));
            n5.Add("4EFCA109", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IClusterManifestSystemTarget_GrainReference_4EFCA109));
            var n8 = n2.Add(typeof(global::Orleans.Runtime.ICatalog));
            n8.Add("C4A56D7C", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_ICatalog_GrainReference_C4A56D7C));
            var n10 = n2.Add(typeof(global::Orleans.Runtime.IDeploymentLoadPublisher));
            n10.Add("C5255F0C", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IDeploymentLoadPublisher_GrainReference_C5255F0C));
            var n12 = n2.Add(typeof(global::Orleans.Runtime.IManagementGrain));
            n12.Add("4C0864C2", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_4C0864C2));
            n12.Add("CC6CCBC3", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_CC6CCBC3));
            n12.Add("5922EB76", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_5922EB76));
            n12.Add("329F9A1B", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_329F9A1B));
            n12.Add("54E6D1D1", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54E6D1D1));
            n12.Add("B761B345", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_B761B345));
            n12.Add("2D761B36", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_2D761B36));
            n12.Add("3CFF788C", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3CFF788C));
            n12.Add("ACCE9D6A", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_ACCE9D6A));
            n12.Add("0A1C0D82", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0A1C0D82));
            n12.Add("AEDE93F6", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_AEDE93F6));
            n12.Add("D7365B43", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_D7365B43));
            n12.Add("F67965CC", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_F67965CC_1<>));
            n12.Add("317D82B6", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_317D82B6));
            n12.Add("3DB7923B", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_3DB7923B));
            n12.Add("0F06E027", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_0F06E027));
            n12.Add("54FE0FEC", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IManagementGrain_GrainReference_54FE0FEC));
            var n30 = n2.Add(typeof(global::Orleans.IVersionManager));
            n30.Add("8F5C15A9", typeof(OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_8F5C15A9));
            n30.Add("4AAEAFCE", typeof(OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_4AAEAFCE));
            n30.Add("C01C4EE8", typeof(OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_C01C4EE8));
            n30.Add("90AB9D5E", typeof(OrleansCodeGen.Orleans.Invokable_IVersionManager_GrainReference_90AB9D5E));
            var n35 = n2.Add(typeof(global::Orleans.Runtime.IMembershipService));
            n35.Add("22A02D46", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_22A02D46));
            n35.Add("39AB7071", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_39AB7071));
            n35.Add("0F85FAAF", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IMembershipService_GrainReference_0F85FAAF));
            var n39 = n2.Add(typeof(global::Orleans.Placement.Repartitioning.IActivationRepartitionerSystemTarget));
            n39.Add("A6EE4757", typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_A6EE4757));
            n39.Add("9D8EDC44", typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9D8EDC44));
            n39.Add("21852A09", typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_21852A09));
            n39.Add("9FB525F3", typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_9FB525F3));
            n39.Add("135356E5", typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_135356E5));
            n39.Add("C4497899", typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_C4497899));
            n39.Add("11731652", typeof(OrleansCodeGen.Orleans.Placement.Repartitioning.Invokable_IActivationRepartitionerSystemTarget_GrainReference_11731652));
            var n47 = n2.Add(typeof(global::Orleans.Storage.IMemoryStorageGrain));
            n47.Add("45659318", typeof(OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_45659318_1<>));
            n47.Add("7CC6CA25", typeof(OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_7CC6CA25_1<>));
            n47.Add("B7CADD03", typeof(OrleansCodeGen.Orleans.Storage.Invokable_IMemoryStorageGrain_GrainReference_B7CADD03_1<>));
            var n51 = n2.Add(typeof(global::Orleans.IMembershipTable));
            n51.Add("FB89E5E9", typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FB89E5E9));
            n51.Add("BF899C85", typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_BF899C85));
            n51.Add("7A519C2E", typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_7A519C2E));
            n51.Add("D851FB33", typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_D851FB33));
            n51.Add("00BCE16F", typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_00BCE16F));
            n51.Add("FEF3AC5A", typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_FEF3AC5A));
            n51.Add("E06D3DBC", typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_E06D3DBC));
            n51.Add("B1A52D2B", typeof(OrleansCodeGen.Orleans.Invokable_IMembershipTable_GrainReference_B1A52D2B));
            var n60 = n2.Add(typeof(global::Orleans.ISiloControl));
            n60.Add("1422B0B7", typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_1422B0B7));
            n60.Add("F388CED1", typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F388CED1));
            n60.Add("45D07D09", typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45D07D09));
            n60.Add("0C7DBD0C", typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_0C7DBD0C));
            n60.Add("F18EAF24", typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_F18EAF24));
            n60.Add("FF707A30", typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_FF707A30));
            n60.Add("B0F4C24B", typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_B0F4C24B));
            n60.Add("6DE16EF7", typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_6DE16EF7));
            n60.Add("45172562", typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_45172562));
            n60.Add("C4C370A5", typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_C4C370A5));
            n60.Add("355CA3FA", typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_355CA3FA_1<>));
            n60.Add("85797C87", typeof(OrleansCodeGen.Orleans.Invokable_ISiloControl_GrainReference_85797C87));
        }
    }
}