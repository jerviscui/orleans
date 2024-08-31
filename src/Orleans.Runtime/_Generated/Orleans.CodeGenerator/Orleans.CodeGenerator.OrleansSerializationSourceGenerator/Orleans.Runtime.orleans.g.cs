#pragma warning disable CS1591
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Runtime")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Core.Abstractions")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Serialization")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Core")]
[assembly: global::Orleans.Serialization.Configuration.TypeManifestProviderAttribute(typeof(OrleansCodeGen.OrleansRuntime.Metadata_OrleansRuntime))]
namespace OrleansCodeGen.Orleans.Runtime
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IActivationMigrationManagerSystemTarget), "29E9E63F")]
    internal sealed class Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F : global::Orleans.Runtime.Request
    {
        public global::System.Collections.Generic.List<global::Orleans.Runtime.GrainMigrationPackage> arg0;
        global::Orleans.Runtime.IActivationMigrationManagerSystemTarget target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IActivationMigrationManagerSystemTarget), "AcceptMigratingGrains", null, new[] { typeof(global::System.Collections.Generic.List<global::Orleans.Runtime.GrainMigrationPackage>) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "AcceptMigratingGrains";
        public override string GetInterfaceName() => "Orleans.Runtime.IActivationMigrationManagerSystemTarget";
        public override string GetActivityName() => "IActivationMigrationManagerSystemTarget/AcceptMigratingGrains";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IActivationMigrationManagerSystemTarget);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IActivationMigrationManagerSystemTarget>();
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
                    arg0 = (global::System.Collections.Generic.List<global::Orleans.Runtime.GrainMigrationPackage>)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.ValueTask InvokeInner() => target.AcceptMigratingGrains(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IActivationMigrationManagerSystemTarget : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IActivationMigrationManagerSystemTarget
    {
        public Proxy_IActivationMigrationManagerSystemTarget(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.ValueTask global::Orleans.Runtime.IActivationMigrationManagerSystemTarget.AcceptMigratingGrains(global::System.Collections.Generic.List<global::Orleans.Runtime.GrainMigrationPackage> arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F();
            request.arg0 = arg0;
            return base.InvokeAsync(request);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IRemoteGrainDirectory), "CD06EAEE")]
    internal sealed class Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE : global::Orleans.Runtime.TaskRequest
    {
        public global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress> arg0;
        global::Orleans.Runtime.IRemoteGrainDirectory target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IRemoteGrainDirectory), "RegisterMany", null, new[] { typeof(global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress>) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "RegisterMany";
        public override string GetInterfaceName() => "Orleans.Runtime.IRemoteGrainDirectory";
        public override string GetActivityName() => "IRemoteGrainDirectory/RegisterMany";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IRemoteGrainDirectory);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IRemoteGrainDirectory>();
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
                    arg0 = (global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress>)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.RegisterMany(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IRemoteGrainDirectory), "7DF50601")]
    internal sealed class Invokable_IRemoteGrainDirectory_GrainReference_7DF50601 : global::Orleans.Runtime.TaskRequest<global::System.Collections.Generic.List<global::Orleans.GrainDirectory.AddressAndTag>>
    {
        public global::System.Collections.Generic.List<(global::Orleans.Runtime.GrainId GrainId, int Version)> arg0;
        global::Orleans.Runtime.IRemoteGrainDirectory target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IRemoteGrainDirectory), "LookUpMany", null, new[] { typeof(global::System.Collections.Generic.List<(global::Orleans.Runtime.GrainId GrainId, int Version)>) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "LookUpMany";
        public override string GetInterfaceName() => "Orleans.Runtime.IRemoteGrainDirectory";
        public override string GetActivityName() => "IRemoteGrainDirectory/LookUpMany";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IRemoteGrainDirectory);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IRemoteGrainDirectory>();
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
                    arg0 = (global::System.Collections.Generic.List<(global::Orleans.Runtime.GrainId GrainId, int Version)>)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.GrainDirectory.AddressAndTag>> InvokeInner() => target.LookUpMany(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IRemoteGrainDirectory), "9ABE3793")]
    internal sealed class Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793 : global::Orleans.Runtime.TaskRequest
    {
        public global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress> arg0;
        global::Orleans.Runtime.IRemoteGrainDirectory target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IRemoteGrainDirectory), "AcceptSplitPartition", null, new[] { typeof(global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress>) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "AcceptSplitPartition";
        public override string GetInterfaceName() => "Orleans.Runtime.IRemoteGrainDirectory";
        public override string GetActivityName() => "IRemoteGrainDirectory/AcceptSplitPartition";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IRemoteGrainDirectory);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IRemoteGrainDirectory>();
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
                    arg0 = (global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress>)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.AcceptSplitPartition(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IRemoteGrainDirectory : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IRemoteGrainDirectory
    {
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Runtime.GrainAddress> _copier0;
        private readonly global::Orleans.Serialization.Codecs.ListCopier<(global::Orleans.Runtime.GrainId GrainId, int Version)> _copier1;
        public Proxy_IRemoteGrainDirectory(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Runtime.GrainAddress>>(this, CodecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<(global::Orleans.Runtime.GrainId GrainId, int Version)>>(this, CodecProvider);
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.IRemoteGrainDirectory.RegisterMany(global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress> arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Orleans.GrainDirectory.AddressAndTag>> global::Orleans.Runtime.IRemoteGrainDirectory.LookUpMany(global::System.Collections.Generic.List<(global::Orleans.Runtime.GrainId GrainId, int Version)> arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_7DF50601();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier1.DeepCopy(arg0, copyContext);
            return base.InvokeAsync<global::System.Collections.Generic.List<global::Orleans.GrainDirectory.AddressAndTag>>(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.IRemoteGrainDirectory.AcceptSplitPartition(global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress> arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.GrainDirectory.AddressAndTag> global::Orleans.GrainDirectory.IDhtGrainDirectory.RegisterAsync(global::Orleans.Runtime.GrainAddress arg0, int arg1)
        {
            var request = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_B5C58E36();
            request.arg0 = arg0;
            request.arg1 = arg1;
            return base.InvokeAsync<global::Orleans.GrainDirectory.AddressAndTag>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.GrainDirectory.AddressAndTag> global::Orleans.GrainDirectory.IDhtGrainDirectory.RegisterAsync(global::Orleans.Runtime.GrainAddress arg0, global::Orleans.Runtime.GrainAddress arg1, int arg2)
        {
            var request = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9F511ACB();
            request.arg0 = arg0;
            request.arg1 = arg1;
            request.arg2 = arg2;
            return base.InvokeAsync<global::Orleans.GrainDirectory.AddressAndTag>(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.GrainDirectory.IDhtGrainDirectory.UnregisterAsync(global::Orleans.Runtime.GrainAddress arg0, global::Orleans.GrainDirectory.UnregistrationCause arg1, int arg2)
        {
            var request = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0();
            request.arg0 = arg0;
            request.arg1 = arg1;
            request.arg2 = arg2;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.GrainDirectory.IDhtGrainDirectory.UnregisterManyAsync(global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress> arg0, global::Orleans.GrainDirectory.UnregistrationCause arg1, int arg2)
        {
            var request = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            request.arg1 = arg1;
            request.arg2 = arg2;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.GrainDirectory.IDhtGrainDirectory.DeleteGrainAsync(global::Orleans.Runtime.GrainId arg0, int arg1)
        {
            var request = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_C0878611();
            request.arg0 = arg0;
            request.arg1 = arg1;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.GrainDirectory.AddressAndTag> global::Orleans.GrainDirectory.IDhtGrainDirectory.LookupAsync(global::Orleans.Runtime.GrainId arg0, int arg1)
        {
            var request = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F();
            request.arg0 = arg0;
            request.arg1 = arg1;
            return base.InvokeAsync<global::Orleans.GrainDirectory.AddressAndTag>(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.ISiloManifestSystemTarget), "1857A4C8")]
    internal sealed class Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8 : global::Orleans.Runtime.Request<global::Orleans.Metadata.GrainManifest>
    {
        global::Orleans.Runtime.ISiloManifestSystemTarget target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.ISiloManifestSystemTarget), "GetSiloManifest", null, null);
        public override string GetMethodName() => "GetSiloManifest";
        public override string GetInterfaceName() => "Orleans.Runtime.ISiloManifestSystemTarget";
        public override string GetActivityName() => "ISiloManifestSystemTarget/GetSiloManifest";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.ISiloManifestSystemTarget);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.ISiloManifestSystemTarget>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.ValueTask<global::Orleans.Metadata.GrainManifest> InvokeInner() => target.GetSiloManifest();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_ISiloManifestSystemTarget : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.ISiloManifestSystemTarget
    {
        public Proxy_ISiloManifestSystemTarget(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.ValueTask<global::Orleans.Metadata.GrainManifest> global::Orleans.Runtime.ISiloManifestSystemTarget.GetSiloManifest()
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8();
            return base.InvokeAsync<global::Orleans.Metadata.GrainManifest>(request);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.IGrainTimerInvoker), "3F6C2672")]
    internal sealed class Invokable_IGrainTimerInvoker_GrainReference_3F6C2672 : global::Orleans.Runtime.TaskRequest
    {
        global::Orleans.Runtime.IGrainTimerInvoker target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IGrainTimerInvoker), "InvokeCallbackAsync", null, null);
        public override string GetMethodName() => "InvokeCallbackAsync";
        public override string GetInterfaceName() => "Orleans.Runtime.IGrainTimerInvoker";
        public override string GetActivityName() => "IGrainTimerInvoker/InvokeCallbackAsync";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IGrainTimerInvoker);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.IGrainTimerInvoker>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.InvokeCallbackAsync();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IGrainTimerInvoker : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IGrainTimerInvoker
    {
        public Proxy_IGrainTimerInvoker(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.IGrainTimerInvoker.InvokeCallbackAsync()
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IGrainTimerInvoker_GrainReference_3F6C2672();
            return base.InvokeAsync(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.List<global::Orleans.Runtime.GrainMigrationPackage>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Runtime.GrainMigrationPackage> _codec0;
        public Codec_Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Runtime.GrainMigrationPackage>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F @value)
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
        public OrleansCodeGen.Orleans.Runtime.Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_GrainMigrationPackage : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GrainMigrationPackage>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Runtime.GrainMigrationPackage>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.GrainMigrationPackage);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainId _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.MigrationContext);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_MigrationContext _codec1;
        public Codec_GrainMigrationPackage(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainId>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_MigrationContext>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Runtime.GrainMigrationPackage instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.GrainId);
            _codec1.WriteField(ref writer, 1U, _type1, instance.MigrationContext);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Runtime.GrainMigrationPackage instance)
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
                    instance.GrainId = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.MigrationContext = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.GrainMigrationPackage @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.GrainMigrationPackage ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Runtime.GrainMigrationPackage);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Runtime.GrainAddress> _codec0;
        public Codec_Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Runtime.GrainAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE @value)
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
        public OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE>
    {
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Runtime.GrainAddress> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Runtime.GrainAddress>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IRemoteGrainDirectory_GrainReference_7DF50601 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_7DF50601>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_7DF50601);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.List<(global::Orleans.Runtime.GrainId GrainId, int Version)>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<(global::Orleans.Runtime.GrainId GrainId, int Version)> _codec0;
        public Codec_Invokable_IRemoteGrainDirectory_GrainReference_7DF50601(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<(global::Orleans.Runtime.GrainId GrainId, int Version)>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_7DF50601 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_7DF50601 instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_7DF50601 @value)
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
        public OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_7DF50601 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_7DF50601, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_7DF50601();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IRemoteGrainDirectory_GrainReference_7DF50601 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_7DF50601>
    {
        private readonly global::Orleans.Serialization.Codecs.ListCopier<(global::Orleans.Runtime.GrainId GrainId, int Version)> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_7DF50601 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_7DF50601 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_7DF50601();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IRemoteGrainDirectory_GrainReference_7DF50601(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<(global::Orleans.Runtime.GrainId GrainId, int Version)>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Runtime.GrainAddress> _codec0;
        public Codec_Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Runtime.GrainAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793 instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793 @value)
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
        public OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793>
    {
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Runtime.GrainAddress> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Runtime.GrainAddress>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8 @value)
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
        public OrleansCodeGen.Orleans.Runtime.Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ClusterMember : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.ClusterMember>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.ClusterMember);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.ClusterMember> _activator;
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.SiloAddress);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.SiloStatus);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_SiloStatus _codec1;
        private static readonly global::System.Action<global::Orleans.Runtime.ClusterMember, string> setField0 = (global::System.Action<global::Orleans.Runtime.ClusterMember, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.ClusterMember), "<Name>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.ClusterMember, global::Orleans.Runtime.SiloAddress> setField1 = (global::System.Action<global::Orleans.Runtime.ClusterMember, global::Orleans.Runtime.SiloAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.ClusterMember), "<SiloAddress>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.ClusterMember, global::Orleans.Runtime.SiloStatus> setField2 = (global::System.Action<global::Orleans.Runtime.ClusterMember, global::Orleans.Runtime.SiloStatus>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.ClusterMember), "<Status>k__BackingField");
        public Codec_ClusterMember(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.ClusterMember> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_SiloStatus>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.ClusterMember instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.SiloAddress);
            _codec1.WriteField(ref writer, 1U, _type1, instance.Status);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.Name);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.ClusterMember instance)
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
                    setField0(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.ClusterMember @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.ClusterMember ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.ClusterMember, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ClusterMembershipSnapshot : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.ClusterMembershipSnapshot>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.ClusterMembershipSnapshot);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.ClusterMembershipSnapshot> _activator;
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.ClusterMember>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.ClusterMember>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.MembershipVersion);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_MembershipVersion _codec1;
        private static readonly global::System.Action<global::Orleans.Runtime.ClusterMembershipSnapshot, global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.ClusterMember>> setField0 = (global::System.Action<global::Orleans.Runtime.ClusterMembershipSnapshot, global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.ClusterMember>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.ClusterMembershipSnapshot), "<Members>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.ClusterMembershipSnapshot, global::Orleans.Runtime.MembershipVersion> setField1 = (global::System.Action<global::Orleans.Runtime.ClusterMembershipSnapshot, global::Orleans.Runtime.MembershipVersion>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.ClusterMembershipSnapshot), "<Version>k__BackingField");
        public Codec_ClusterMembershipSnapshot(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.ClusterMembershipSnapshot> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.ClusterMember>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_MembershipVersion>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.ClusterMembershipSnapshot instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Members);
            _codec1.WriteField(ref writer, 1U, _type1, instance.Version);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.ClusterMembershipSnapshot instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.ClusterMembershipSnapshot @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.ClusterMembershipSnapshot ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.ClusterMembershipSnapshot, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ClusterMembershipUpdate : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.ClusterMembershipUpdate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.ClusterMembershipUpdate);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.ClusterMembershipUpdate> _activator;
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Immutable.ImmutableArray<global::Orleans.Runtime.ClusterMember>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableArray<global::Orleans.Runtime.ClusterMember>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.ClusterMembershipSnapshot);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_ClusterMembershipSnapshot _codec1;
        private static readonly global::System.Action<global::Orleans.Runtime.ClusterMembershipUpdate, global::System.Collections.Immutable.ImmutableArray<global::Orleans.Runtime.ClusterMember>> setField0 = (global::System.Action<global::Orleans.Runtime.ClusterMembershipUpdate, global::System.Collections.Immutable.ImmutableArray<global::Orleans.Runtime.ClusterMember>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.ClusterMembershipUpdate), "<Changes>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.ClusterMembershipUpdate, global::Orleans.Runtime.ClusterMembershipSnapshot> setField1 = (global::System.Action<global::Orleans.Runtime.ClusterMembershipUpdate, global::Orleans.Runtime.ClusterMembershipSnapshot>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.ClusterMembershipUpdate), "<Snapshot>k__BackingField");
        public Codec_ClusterMembershipUpdate(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.ClusterMembershipUpdate> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableArray<global::Orleans.Runtime.ClusterMember>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_ClusterMembershipSnapshot>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.ClusterMembershipUpdate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Changes);
            _codec1.WriteField(ref writer, 1U, _type1, instance.Snapshot);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.ClusterMembershipUpdate instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.ClusterMembershipUpdate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.ClusterMembershipUpdate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.ClusterMembershipUpdate, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IGrainTimerInvoker_GrainReference_3F6C2672 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IGrainTimerInvoker_GrainReference_3F6C2672>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IGrainTimerInvoker_GrainReference_3F6C2672);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IGrainTimerInvoker_GrainReference_3F6C2672 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IGrainTimerInvoker_GrainReference_3F6C2672 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IGrainTimerInvoker_GrainReference_3F6C2672 @value)
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
        public OrleansCodeGen.Orleans.Runtime.Invokable_IGrainTimerInvoker_GrainReference_3F6C2672 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IGrainTimerInvoker_GrainReference_3F6C2672, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IGrainTimerInvoker_GrainReference_3F6C2672();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IGrainTimerInvoker_GrainReference_3F6C2672 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IGrainTimerInvoker_GrainReference_3F6C2672>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IGrainTimerInvoker_GrainReference_3F6C2672 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IGrainTimerInvoker_GrainReference_3F6C2672 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IGrainTimerInvoker_GrainReference_3F6C2672();
            return result;
        }
    }
}
#pragma warning restore CS1591

namespace OrleansCodeGen.Orleans.Runtime.Development
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.Development.IDevelopmentLeaseProviderGrain), "847FCE12")]
    internal sealed class Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12 : global::Orleans.Runtime.TaskRequest
    {
        global::Orleans.Runtime.Development.IDevelopmentLeaseProviderGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.Development.IDevelopmentLeaseProviderGrain), "Reset", null, null);
        public override string GetMethodName() => "Reset";
        public override string GetInterfaceName() => "Orleans.Runtime.Development.IDevelopmentLeaseProviderGrain";
        public override string GetActivityName() => "IDevelopmentLeaseProviderGrain/Reset";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.Development.IDevelopmentLeaseProviderGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.Development.IDevelopmentLeaseProviderGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.Reset();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IDevelopmentLeaseProviderGrain : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.Development.IDevelopmentLeaseProviderGrain
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.LeaseProviders.LeaseRequest> _copier0;
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.LeaseProviders.AcquiredLease> _copier1;
        public Proxy_IDevelopmentLeaseProviderGrain(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.LeaseProviders.LeaseRequest>>(this, CodecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.LeaseProviders.AcquiredLease>>(this, CodecProvider);
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.Development.IDevelopmentLeaseProviderGrain.Reset()
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Development.Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12();
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.LeaseProviders.AcquireLeaseResult[]> global::Orleans.LeaseProviders.ILeaseProvider.Acquire(string arg0, global::Orleans.LeaseProviders.LeaseRequest[] arg1)
        {
            var request = new OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_5C7B2877();
            request.arg0 = arg0;
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg1 = _copier0.DeepCopy(arg1, copyContext);
            return base.InvokeAsync<global::Orleans.LeaseProviders.AcquireLeaseResult[]>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.LeaseProviders.AcquireLeaseResult[]> global::Orleans.LeaseProviders.ILeaseProvider.Renew(string arg0, global::Orleans.LeaseProviders.AcquiredLease[] arg1)
        {
            var request = new OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_ACF8E0DD();
            request.arg0 = arg0;
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg1 = _copier1.DeepCopy(arg1, copyContext);
            return base.InvokeAsync<global::Orleans.LeaseProviders.AcquireLeaseResult[]>(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.LeaseProviders.ILeaseProvider.Release(string arg0, global::Orleans.LeaseProviders.AcquiredLease[] arg1)
        {
            var request = new OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_F2BF11D0();
            request.arg0 = arg0;
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg1 = _copier1.DeepCopy(arg1, copyContext);
            return base.InvokeAsync(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Development.Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Development.Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Development.Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Development.Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Development.Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12 @value)
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
        public OrleansCodeGen.Orleans.Runtime.Development.Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Development.Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Development.Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Development.Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Development.Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12 DeepCopy(OrleansCodeGen.Orleans.Runtime.Development.Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Development.Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12();
            return result;
        }
    }
}

namespace OrleansCodeGen.Orleans.LeaseProviders
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.LeaseProviders.ILeaseProvider), "5C7B2877")]
    public sealed class Invokable_ILeaseProvider_GrainReference_5C7B2877 : global::Orleans.Runtime.TaskRequest<global::Orleans.LeaseProviders.AcquireLeaseResult[]>
    {
        public string arg0;
        public global::Orleans.LeaseProviders.LeaseRequest[] arg1;
        global::Orleans.LeaseProviders.ILeaseProvider target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.LeaseProviders.ILeaseProvider), "Acquire", null, new[] { typeof(string), typeof(global::Orleans.LeaseProviders.LeaseRequest[]) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "Acquire";
        public override string GetInterfaceName() => "Orleans.LeaseProviders.ILeaseProvider";
        public override string GetActivityName() => "ILeaseProvider/Acquire";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.LeaseProviders.ILeaseProvider);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.LeaseProviders.ILeaseProvider>();
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
                    arg0 = (string)value;
                    return;
                case 1:
                    arg1 = (global::Orleans.LeaseProviders.LeaseRequest[])value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.LeaseProviders.AcquireLeaseResult[]> InvokeInner() => target.Acquire(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.LeaseProviders.ILeaseProvider), "ACF8E0DD")]
    public sealed class Invokable_ILeaseProvider_GrainReference_ACF8E0DD : global::Orleans.Runtime.TaskRequest<global::Orleans.LeaseProviders.AcquireLeaseResult[]>
    {
        public string arg0;
        public global::Orleans.LeaseProviders.AcquiredLease[] arg1;
        global::Orleans.LeaseProviders.ILeaseProvider target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.LeaseProviders.ILeaseProvider), "Renew", null, new[] { typeof(string), typeof(global::Orleans.LeaseProviders.AcquiredLease[]) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "Renew";
        public override string GetInterfaceName() => "Orleans.LeaseProviders.ILeaseProvider";
        public override string GetActivityName() => "ILeaseProvider/Renew";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.LeaseProviders.ILeaseProvider);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.LeaseProviders.ILeaseProvider>();
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
                    arg0 = (string)value;
                    return;
                case 1:
                    arg1 = (global::Orleans.LeaseProviders.AcquiredLease[])value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.LeaseProviders.AcquireLeaseResult[]> InvokeInner() => target.Renew(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.LeaseProviders.ILeaseProvider), "F2BF11D0")]
    public sealed class Invokable_ILeaseProvider_GrainReference_F2BF11D0 : global::Orleans.Runtime.TaskRequest
    {
        public string arg0;
        public global::Orleans.LeaseProviders.AcquiredLease[] arg1;
        global::Orleans.LeaseProviders.ILeaseProvider target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.LeaseProviders.ILeaseProvider), "Release", null, new[] { typeof(string), typeof(global::Orleans.LeaseProviders.AcquiredLease[]) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "Release";
        public override string GetInterfaceName() => "Orleans.LeaseProviders.ILeaseProvider";
        public override string GetActivityName() => "ILeaseProvider/Release";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.LeaseProviders.ILeaseProvider);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.LeaseProviders.ILeaseProvider>();
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
                    arg0 = (string)value;
                    return;
                case 1:
                    arg1 = (global::Orleans.LeaseProviders.AcquiredLease[])value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.Release(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_ILeaseProvider_GrainReference_5C7B2877 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_5C7B2877>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_5C7B2877);
        private readonly global::System.Type _type0 = typeof(global::Orleans.LeaseProviders.LeaseRequest[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.LeaseProviders.LeaseRequest> _codec0;
        public Codec_Invokable_ILeaseProvider_GrainReference_5C7B2877(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.LeaseProviders.LeaseRequest>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_5C7B2877 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
            _codec0.WriteField(ref writer, 1U, _type0, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_5C7B2877 instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_5C7B2877 @value)
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
        public OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_5C7B2877 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_5C7B2877, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_5C7B2877();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_ILeaseProvider_GrainReference_5C7B2877 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_5C7B2877>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.LeaseProviders.LeaseRequest> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_5C7B2877 DeepCopy(OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_5C7B2877 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_5C7B2877();
            result.arg0 = original.arg0;
            result.arg1 = _copier0.DeepCopy(original.arg1, context);
            return result;
        }

        public Copier_Invokable_ILeaseProvider_GrainReference_5C7B2877(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.LeaseProviders.LeaseRequest>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_ILeaseProvider_GrainReference_ACF8E0DD : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_ACF8E0DD>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_ACF8E0DD);
        private readonly global::System.Type _type0 = typeof(global::Orleans.LeaseProviders.AcquiredLease[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.LeaseProviders.AcquiredLease> _codec0;
        public Codec_Invokable_ILeaseProvider_GrainReference_ACF8E0DD(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.LeaseProviders.AcquiredLease>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_ACF8E0DD instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
            _codec0.WriteField(ref writer, 1U, _type0, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_ACF8E0DD instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_ACF8E0DD @value)
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
        public OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_ACF8E0DD ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_ACF8E0DD, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_ACF8E0DD();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_ILeaseProvider_GrainReference_ACF8E0DD : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_ACF8E0DD>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.LeaseProviders.AcquiredLease> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_ACF8E0DD DeepCopy(OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_ACF8E0DD original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_ACF8E0DD();
            result.arg0 = original.arg0;
            result.arg1 = _copier0.DeepCopy(original.arg1, context);
            return result;
        }

        public Copier_Invokable_ILeaseProvider_GrainReference_ACF8E0DD(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.LeaseProviders.AcquiredLease>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_ILeaseProvider_GrainReference_F2BF11D0 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_F2BF11D0>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_F2BF11D0);
        private readonly global::System.Type _type0 = typeof(global::Orleans.LeaseProviders.AcquiredLease[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.LeaseProviders.AcquiredLease> _codec0;
        public Codec_Invokable_ILeaseProvider_GrainReference_F2BF11D0(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<global::Orleans.LeaseProviders.AcquiredLease>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_F2BF11D0 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
            _codec0.WriteField(ref writer, 1U, _type0, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_F2BF11D0 instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_F2BF11D0 @value)
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
        public OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_F2BF11D0 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_F2BF11D0, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_F2BF11D0();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_ILeaseProvider_GrainReference_F2BF11D0 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_F2BF11D0>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.LeaseProviders.AcquiredLease> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_F2BF11D0 DeepCopy(OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_F2BF11D0 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_F2BF11D0();
            result.arg0 = original.arg0;
            result.arg1 = _copier0.DeepCopy(original.arg1, context);
            return result;
        }

        public Copier_Invokable_ILeaseProvider_GrainReference_F2BF11D0(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<global::Orleans.LeaseProviders.AcquiredLease>>(this, codecProvider);
        }
    }
}

namespace OrleansCodeGen.Orleans.Runtime.GrainDirectory
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.GrainDirectory.IRemoteClientDirectory), "972F9953")]
    internal sealed class Invokable_IRemoteClientDirectory_GrainReference_972F9953 : global::Orleans.Runtime.TaskRequest
    {
        public global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, (global::System.Collections.Immutable.ImmutableHashSet<global::Orleans.Runtime.GrainId> ConnectedClients, long Version)> arg0;
        global::Orleans.Runtime.GrainDirectory.IRemoteClientDirectory target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.GrainDirectory.IRemoteClientDirectory), "OnUpdateClientRoutes", null, new[] { typeof(global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, (global::System.Collections.Immutable.ImmutableHashSet<global::Orleans.Runtime.GrainId> ConnectedClients, long Version)>) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "OnUpdateClientRoutes";
        public override string GetInterfaceName() => "Orleans.Runtime.GrainDirectory.IRemoteClientDirectory";
        public override string GetActivityName() => "IRemoteClientDirectory/OnUpdateClientRoutes";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.GrainDirectory.IRemoteClientDirectory);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.GrainDirectory.IRemoteClientDirectory>();
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
                    arg0 = (global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, (global::System.Collections.Immutable.ImmutableHashSet<global::Orleans.Runtime.GrainId> ConnectedClients, long Version)>)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.OnUpdateClientRoutes(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.GrainDirectory.IRemoteClientDirectory), "A6E49CD1")]
    internal sealed class Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1 : global::Orleans.Runtime.TaskRequest<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, (global::System.Collections.Immutable.ImmutableHashSet<global::Orleans.Runtime.GrainId> ConnectedClients, long Version)>>
    {
        public global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, long> arg0;
        global::Orleans.Runtime.GrainDirectory.IRemoteClientDirectory target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.GrainDirectory.IRemoteClientDirectory), "GetClientRoutes", null, new[] { typeof(global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, long>) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "GetClientRoutes";
        public override string GetInterfaceName() => "Orleans.Runtime.GrainDirectory.IRemoteClientDirectory";
        public override string GetActivityName() => "IRemoteClientDirectory/GetClientRoutes";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.GrainDirectory.IRemoteClientDirectory);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.GrainDirectory.IRemoteClientDirectory>();
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
                    arg0 = (global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, long>)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, (global::System.Collections.Immutable.ImmutableHashSet<global::Orleans.Runtime.GrainId> ConnectedClients, long Version)>> InvokeInner() => target.GetClientRoutes(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IRemoteClientDirectory : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.GrainDirectory.IRemoteClientDirectory
    {
        public Proxy_IRemoteClientDirectory(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.GrainDirectory.IRemoteClientDirectory.OnUpdateClientRoutes(global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, (global::System.Collections.Immutable.ImmutableHashSet<global::Orleans.Runtime.GrainId> ConnectedClients, long Version)> arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_972F9953();
            request.arg0 = arg0;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, (global::System.Collections.Immutable.ImmutableHashSet<global::Orleans.Runtime.GrainId> ConnectedClients, long Version)>> global::Orleans.Runtime.GrainDirectory.IRemoteClientDirectory.GetClientRoutes(global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, long> arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1();
            request.arg0 = arg0;
            return base.InvokeAsync<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, (global::System.Collections.Immutable.ImmutableHashSet<global::Orleans.Runtime.GrainId> ConnectedClients, long Version)>>(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IRemoteClientDirectory_GrainReference_972F9953 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_972F9953>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_972F9953);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, (global::System.Collections.Immutable.ImmutableHashSet<global::Orleans.Runtime.GrainId> ConnectedClients, long Version)>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, (global::System.Collections.Immutable.ImmutableHashSet<global::Orleans.Runtime.GrainId> ConnectedClients, long Version)>> _codec0;
        public Codec_Invokable_IRemoteClientDirectory_GrainReference_972F9953(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, (global::System.Collections.Immutable.ImmutableHashSet<global::Orleans.Runtime.GrainId> ConnectedClients, long Version)>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_972F9953 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_972F9953 instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_972F9953 @value)
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
        public OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_972F9953 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_972F9953, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_972F9953();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IRemoteClientDirectory_GrainReference_972F9953 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_972F9953>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_972F9953 DeepCopy(OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_972F9953 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_972F9953();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, long>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, long>> _codec0;
        public Codec_Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, long>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1 instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1 @value)
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
        public OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1 DeepCopy(OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1();
            result.arg0 = original.arg0;
            return result;
        }
    }
}

namespace OrleansCodeGen.Orleans.GrainDirectory
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory), "B5C58E36")]
    internal sealed class Invokable_IDhtGrainDirectory_GrainReference_B5C58E36 : global::Orleans.Runtime.TaskRequest<global::Orleans.GrainDirectory.AddressAndTag>
    {
        public global::Orleans.Runtime.GrainAddress arg0;
        public int arg1;
        global::Orleans.GrainDirectory.IDhtGrainDirectory target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory), "RegisterAsync", null, new[] { typeof(global::Orleans.Runtime.GrainAddress), typeof(int) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "RegisterAsync";
        public override string GetInterfaceName() => "Orleans.GrainDirectory.IDhtGrainDirectory";
        public override string GetActivityName() => "IDhtGrainDirectory/RegisterAsync";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.GrainDirectory.IDhtGrainDirectory>();
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
                    arg0 = (global::Orleans.Runtime.GrainAddress)value;
                    return;
                case 1:
                    arg1 = (int)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.GrainDirectory.AddressAndTag> InvokeInner() => target.RegisterAsync(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory), "9F511ACB")]
    internal sealed class Invokable_IDhtGrainDirectory_GrainReference_9F511ACB : global::Orleans.Runtime.TaskRequest<global::Orleans.GrainDirectory.AddressAndTag>
    {
        public global::Orleans.Runtime.GrainAddress arg0;
        public global::Orleans.Runtime.GrainAddress arg1;
        public int arg2;
        global::Orleans.GrainDirectory.IDhtGrainDirectory target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory), "RegisterAsync", null, new[] { typeof(global::Orleans.Runtime.GrainAddress), typeof(global::Orleans.Runtime.GrainAddress), typeof(int) });
        public override int GetArgumentCount() => 3;
        public override string GetMethodName() => "RegisterAsync";
        public override string GetInterfaceName() => "Orleans.GrainDirectory.IDhtGrainDirectory";
        public override string GetActivityName() => "IDhtGrainDirectory/RegisterAsync";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.GrainDirectory.IDhtGrainDirectory>();
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
                    arg0 = (global::Orleans.Runtime.GrainAddress)value;
                    return;
                case 1:
                    arg1 = (global::Orleans.Runtime.GrainAddress)value;
                    return;
                case 2:
                    arg2 = (int)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.GrainDirectory.AddressAndTag> InvokeInner() => target.RegisterAsync(arg0, arg1, arg2);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory), "9AE7D8E0")]
    internal sealed class Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0 : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.Runtime.GrainAddress arg0;
        public global::Orleans.GrainDirectory.UnregistrationCause arg1;
        public int arg2;
        global::Orleans.GrainDirectory.IDhtGrainDirectory target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory), "UnregisterAsync", null, new[] { typeof(global::Orleans.Runtime.GrainAddress), typeof(global::Orleans.GrainDirectory.UnregistrationCause), typeof(int) });
        public override int GetArgumentCount() => 3;
        public override string GetMethodName() => "UnregisterAsync";
        public override string GetInterfaceName() => "Orleans.GrainDirectory.IDhtGrainDirectory";
        public override string GetActivityName() => "IDhtGrainDirectory/UnregisterAsync";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.GrainDirectory.IDhtGrainDirectory>();
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
                    arg0 = (global::Orleans.Runtime.GrainAddress)value;
                    return;
                case 1:
                    arg1 = (global::Orleans.GrainDirectory.UnregistrationCause)value;
                    return;
                case 2:
                    arg2 = (int)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.UnregisterAsync(arg0, arg1, arg2);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory), "DBC70A4F")]
    internal sealed class Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F : global::Orleans.Runtime.TaskRequest
    {
        public global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress> arg0;
        public global::Orleans.GrainDirectory.UnregistrationCause arg1;
        public int arg2;
        global::Orleans.GrainDirectory.IDhtGrainDirectory target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory), "UnregisterManyAsync", null, new[] { typeof(global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress>), typeof(global::Orleans.GrainDirectory.UnregistrationCause), typeof(int) });
        public override int GetArgumentCount() => 3;
        public override string GetMethodName() => "UnregisterManyAsync";
        public override string GetInterfaceName() => "Orleans.GrainDirectory.IDhtGrainDirectory";
        public override string GetActivityName() => "IDhtGrainDirectory/UnregisterManyAsync";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.GrainDirectory.IDhtGrainDirectory>();
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
                    arg1 = (global::Orleans.GrainDirectory.UnregistrationCause)value;
                    return;
                case 2:
                    arg2 = (int)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.UnregisterManyAsync(arg0, arg1, arg2);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory), "C0878611")]
    internal sealed class Invokable_IDhtGrainDirectory_GrainReference_C0878611 : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.Runtime.GrainId arg0;
        public int arg1;
        global::Orleans.GrainDirectory.IDhtGrainDirectory target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory), "DeleteGrainAsync", null, new[] { typeof(global::Orleans.Runtime.GrainId), typeof(int) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "DeleteGrainAsync";
        public override string GetInterfaceName() => "Orleans.GrainDirectory.IDhtGrainDirectory";
        public override string GetActivityName() => "IDhtGrainDirectory/DeleteGrainAsync";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.GrainDirectory.IDhtGrainDirectory>();
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
                    arg0 = (global::Orleans.Runtime.GrainId)value;
                    return;
                case 1:
                    arg1 = (int)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.DeleteGrainAsync(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory), "1BA64C6F")]
    internal sealed class Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F : global::Orleans.Runtime.TaskRequest<global::Orleans.GrainDirectory.AddressAndTag>
    {
        public global::Orleans.Runtime.GrainId arg0;
        public int arg1;
        global::Orleans.GrainDirectory.IDhtGrainDirectory target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory), "LookupAsync", null, new[] { typeof(global::Orleans.Runtime.GrainId), typeof(int) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "LookupAsync";
        public override string GetInterfaceName() => "Orleans.GrainDirectory.IDhtGrainDirectory";
        public override string GetActivityName() => "IDhtGrainDirectory/LookupAsync";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.GrainDirectory.IDhtGrainDirectory>();
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
                    arg0 = (global::Orleans.Runtime.GrainId)value;
                    return;
                case 1:
                    arg1 = (int)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.GrainDirectory.AddressAndTag> InvokeInner() => target.LookupAsync(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IDhtGrainDirectory_GrainReference_B5C58E36 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_B5C58E36>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_B5C58E36);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainAddress);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainAddress _codec0;
        public Codec_Invokable_IDhtGrainDirectory_GrainReference_B5C58E36(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainAddress>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_B5C58E36 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_B5C58E36 instance)
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
                    instance.arg1 = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_B5C58E36 @value)
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
        public OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_B5C58E36 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_B5C58E36, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_B5C58E36();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IDhtGrainDirectory_GrainReference_B5C58E36 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_B5C58E36>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_B5C58E36 DeepCopy(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_B5C58E36 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_B5C58E36();
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IDhtGrainDirectory_GrainReference_9F511ACB : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9F511ACB>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9F511ACB);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainAddress);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainAddress _codec0;
        public Codec_Invokable_IDhtGrainDirectory_GrainReference_9F511ACB(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainAddress>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9F511ACB instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            _codec0.WriteField(ref writer, 1U, _type0, instance.arg1);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.arg2);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9F511ACB instance)
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
                    instance.arg1 = _codec0.ReadValue(ref reader, header);
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9F511ACB @value)
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
        public OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9F511ACB ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9F511ACB, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9F511ACB();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IDhtGrainDirectory_GrainReference_9F511ACB : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9F511ACB>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9F511ACB DeepCopy(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9F511ACB original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9F511ACB();
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            result.arg2 = original.arg2;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainAddress);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainAddress _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.GrainDirectory.UnregistrationCause);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.GrainDirectory.UnregistrationCause> _codec1;
        public Codec_Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainAddress>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.GrainDirectory.UnregistrationCause>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg1);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.arg2);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0 instance)
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
                    instance.arg2 = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0 @value)
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
        public OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0 DeepCopy(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0();
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            result.arg2 = original.arg2;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.List<global::Orleans.Runtime.GrainAddress>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Runtime.GrainAddress> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.GrainDirectory.UnregistrationCause);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.GrainDirectory.UnregistrationCause> _codec1;
        public Codec_Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Runtime.GrainAddress>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.GrainDirectory.UnregistrationCause>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg1);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.arg2);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F instance)
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
                    instance.arg2 = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F @value)
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
        public OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F>
    {
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Runtime.GrainAddress> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F DeepCopy(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            result.arg1 = original.arg1;
            result.arg2 = original.arg2;
            return result;
        }

        public Copier_Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Runtime.GrainAddress>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IDhtGrainDirectory_GrainReference_C0878611 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_C0878611>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_C0878611);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainId _codec0;
        public Codec_Invokable_IDhtGrainDirectory_GrainReference_C0878611(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainId>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_C0878611 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_C0878611 instance)
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
                    instance.arg1 = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_C0878611 @value)
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
        public OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_C0878611 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_C0878611, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_C0878611();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IDhtGrainDirectory_GrainReference_C0878611 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_C0878611>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_C0878611 DeepCopy(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_C0878611 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_C0878611();
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainId _codec0;
        public Codec_Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainId>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F instance)
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
                    instance.arg1 = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F @value)
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
        public OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F DeepCopy(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F();
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            return result;
        }
    }
}

namespace OrleansCodeGen.Orleans.Runtime.TestHooks
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "6E596A25")]
    internal sealed class Invokable_ITestHooks_GrainReference_6E596A25 : global::Orleans.Runtime.TaskRequest<global::Orleans.Runtime.SiloAddress>
    {
        public uint arg0;
        global::Orleans.Runtime.TestHooks.ITestHooks target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "GetConsistentRingPrimaryTargetSilo", null, new[] { typeof(uint) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "GetConsistentRingPrimaryTargetSilo";
        public override string GetInterfaceName() => "Orleans.Runtime.TestHooks.ITestHooks";
        public override string GetActivityName() => "ITestHooks/GetConsistentRingPrimaryTargetSilo";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.TestHooks.ITestHooks);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.TestHooks.ITestHooks>();
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
                    arg0 = (uint)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.Runtime.SiloAddress> InvokeInner() => target.GetConsistentRingPrimaryTargetSilo(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "3A061434")]
    internal sealed class Invokable_ITestHooks_GrainReference_3A061434 : global::Orleans.Runtime.TaskRequest<string>
    {
        global::Orleans.Runtime.TestHooks.ITestHooks target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "GetConsistentRingProviderDiagnosticInfo", null, null);
        public override string GetMethodName() => "GetConsistentRingProviderDiagnosticInfo";
        public override string GetInterfaceName() => "Orleans.Runtime.TestHooks.ITestHooks";
        public override string GetActivityName() => "ITestHooks/GetConsistentRingProviderDiagnosticInfo";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.TestHooks.ITestHooks);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.TestHooks.ITestHooks>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task<string> InvokeInner() => target.GetConsistentRingProviderDiagnosticInfo();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "898941AE")]
    internal sealed class Invokable_ITestHooks_GrainReference_898941AE : global::Orleans.Runtime.TaskRequest<string>
    {
        global::Orleans.Runtime.TestHooks.ITestHooks target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "GetServiceId", null, null);
        public override string GetMethodName() => "GetServiceId";
        public override string GetInterfaceName() => "Orleans.Runtime.TestHooks.ITestHooks";
        public override string GetActivityName() => "ITestHooks/GetServiceId";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.TestHooks.ITestHooks);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.TestHooks.ITestHooks>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task<string> InvokeInner() => target.GetServiceId();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "92407CFC")]
    internal sealed class Invokable_ITestHooks_GrainReference_92407CFC : global::Orleans.Runtime.TaskRequest<bool>
    {
        public string arg0;
        global::Orleans.Runtime.TestHooks.ITestHooks target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "HasStorageProvider", null, new[] { typeof(string) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "HasStorageProvider";
        public override string GetInterfaceName() => "Orleans.Runtime.TestHooks.ITestHooks";
        public override string GetActivityName() => "ITestHooks/HasStorageProvider";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.TestHooks.ITestHooks);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.TestHooks.ITestHooks>();
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

        protected override global::System.Threading.Tasks.Task<bool> InvokeInner() => target.HasStorageProvider(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "B4C39864")]
    internal sealed class Invokable_ITestHooks_GrainReference_B4C39864 : global::Orleans.Runtime.TaskRequest<bool>
    {
        public string arg0;
        global::Orleans.Runtime.TestHooks.ITestHooks target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "HasStreamProvider", null, new[] { typeof(string) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "HasStreamProvider";
        public override string GetInterfaceName() => "Orleans.Runtime.TestHooks.ITestHooks";
        public override string GetActivityName() => "ITestHooks/HasStreamProvider";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.TestHooks.ITestHooks);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.TestHooks.ITestHooks>();
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

        protected override global::System.Threading.Tasks.Task<bool> InvokeInner() => target.HasStreamProvider(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "1C8A306F")]
    internal sealed class Invokable_ITestHooks_GrainReference_1C8A306F : global::Orleans.Runtime.TaskRequest<int>
    {
        public global::Orleans.Runtime.GrainId arg0;
        global::Orleans.Runtime.TestHooks.ITestHooks target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "UnregisterGrainForTesting", null, new[] { typeof(global::Orleans.Runtime.GrainId) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "UnregisterGrainForTesting";
        public override string GetInterfaceName() => "Orleans.Runtime.TestHooks.ITestHooks";
        public override string GetActivityName() => "ITestHooks/UnregisterGrainForTesting";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.TestHooks.ITestHooks);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.TestHooks.ITestHooks>();
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

        protected override global::System.Threading.Tasks.Task<int> InvokeInner() => target.UnregisterGrainForTesting(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "BDC27193")]
    internal sealed class Invokable_ITestHooks_GrainReference_BDC27193 : global::Orleans.Runtime.TaskRequest
    {
        public bool arg0;
        public global::System.TimeSpan arg1;
        global::Orleans.Runtime.TestHooks.ITestHooks target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "LatchIsOverloaded", null, new[] { typeof(bool), typeof(global::System.TimeSpan) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "LatchIsOverloaded";
        public override string GetInterfaceName() => "Orleans.Runtime.TestHooks.ITestHooks";
        public override string GetActivityName() => "ITestHooks/LatchIsOverloaded";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.TestHooks.ITestHooks);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.TestHooks.ITestHooks>();
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
                    arg0 = (bool)value;
                    return;
                case 1:
                    arg1 = (global::System.TimeSpan)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.LatchIsOverloaded(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "A9172A30")]
    internal sealed class Invokable_ITestHooks_GrainReference_A9172A30 : global::Orleans.Runtime.TaskRequest<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloStatus>>
    {
        global::Orleans.Runtime.TestHooks.ITestHooks target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.TestHooks.ITestHooks), "GetApproximateSiloStatuses", null, null);
        public override string GetMethodName() => "GetApproximateSiloStatuses";
        public override string GetInterfaceName() => "Orleans.Runtime.TestHooks.ITestHooks";
        public override string GetActivityName() => "ITestHooks/GetApproximateSiloStatuses";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.TestHooks.ITestHooks);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.TestHooks.ITestHooks>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloStatus>> InvokeInner() => target.GetApproximateSiloStatuses();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_ITestHooksSystemTarget : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.TestHooks.ITestHooksSystemTarget
    {
        public Proxy_ITestHooksSystemTarget(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.Task<global::Orleans.Runtime.SiloAddress> global::Orleans.Runtime.TestHooks.ITestHooks.GetConsistentRingPrimaryTargetSilo(uint arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_6E596A25();
            request.arg0 = arg0;
            return base.InvokeAsync<global::Orleans.Runtime.SiloAddress>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<string> global::Orleans.Runtime.TestHooks.ITestHooks.GetConsistentRingProviderDiagnosticInfo()
        {
            var request = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_3A061434();
            return base.InvokeAsync<string>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<string> global::Orleans.Runtime.TestHooks.ITestHooks.GetServiceId()
        {
            var request = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_898941AE();
            return base.InvokeAsync<string>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<bool> global::Orleans.Runtime.TestHooks.ITestHooks.HasStorageProvider(string arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_92407CFC();
            request.arg0 = arg0;
            return base.InvokeAsync<bool>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<bool> global::Orleans.Runtime.TestHooks.ITestHooks.HasStreamProvider(string arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_B4C39864();
            request.arg0 = arg0;
            return base.InvokeAsync<bool>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<int> global::Orleans.Runtime.TestHooks.ITestHooks.UnregisterGrainForTesting(global::Orleans.Runtime.GrainId arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_1C8A306F();
            request.arg0 = arg0;
            return base.InvokeAsync<int>(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.TestHooks.ITestHooks.LatchIsOverloaded(bool arg0, global::System.TimeSpan arg1)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_BDC27193();
            request.arg0 = arg0;
            request.arg1 = arg1;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloStatus>> global::Orleans.Runtime.TestHooks.ITestHooks.GetApproximateSiloStatuses()
        {
            var request = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_A9172A30();
            return base.InvokeAsync<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloStatus>>(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ITestHooks_GrainReference_6E596A25 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_6E596A25>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_6E596A25);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_6E596A25 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.UInt32Codec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_6E596A25 instance)
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
                    instance.arg0 = global::Orleans.Serialization.Codecs.UInt32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_6E596A25 @value)
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
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_6E596A25 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_6E596A25, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_6E596A25();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ITestHooks_GrainReference_6E596A25 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_6E596A25>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_6E596A25 DeepCopy(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_6E596A25 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_6E596A25();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ITestHooks_GrainReference_3A061434 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_3A061434>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_3A061434);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_3A061434 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_3A061434 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_3A061434 @value)
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
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_3A061434 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_3A061434, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_3A061434();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ITestHooks_GrainReference_3A061434 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_3A061434>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_3A061434 DeepCopy(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_3A061434 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_3A061434();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ITestHooks_GrainReference_898941AE : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_898941AE>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_898941AE);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_898941AE instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_898941AE instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_898941AE @value)
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
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_898941AE ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_898941AE, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_898941AE();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ITestHooks_GrainReference_898941AE : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_898941AE>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_898941AE DeepCopy(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_898941AE original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_898941AE();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ITestHooks_GrainReference_92407CFC : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_92407CFC>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_92407CFC);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_92407CFC instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_92407CFC instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_92407CFC @value)
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
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_92407CFC ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_92407CFC, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_92407CFC();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ITestHooks_GrainReference_92407CFC : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_92407CFC>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_92407CFC DeepCopy(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_92407CFC original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_92407CFC();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ITestHooks_GrainReference_B4C39864 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_B4C39864>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_B4C39864);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_B4C39864 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_B4C39864 instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_B4C39864 @value)
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
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_B4C39864 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_B4C39864, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_B4C39864();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ITestHooks_GrainReference_B4C39864 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_B4C39864>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_B4C39864 DeepCopy(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_B4C39864 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_B4C39864();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ITestHooks_GrainReference_1C8A306F : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_1C8A306F>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_1C8A306F);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainId _codec0;
        public Codec_Invokable_ITestHooks_GrainReference_1C8A306F(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainId>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_1C8A306F instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_1C8A306F instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_1C8A306F @value)
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
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_1C8A306F ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_1C8A306F, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_1C8A306F();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ITestHooks_GrainReference_1C8A306F : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_1C8A306F>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_1C8A306F DeepCopy(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_1C8A306F original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_1C8A306F();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ITestHooks_GrainReference_BDC27193 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_BDC27193>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_BDC27193);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_BDC27193 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.BoolCodec.WriteField(ref writer, 0U, instance.arg0);
            global::Orleans.Serialization.Codecs.TimeSpanCodec.WriteField(ref writer, 1U, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_BDC27193 instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_BDC27193 @value)
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
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_BDC27193 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_BDC27193, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_BDC27193();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ITestHooks_GrainReference_BDC27193 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_BDC27193>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_BDC27193 DeepCopy(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_BDC27193 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_BDC27193();
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ITestHooks_GrainReference_A9172A30 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_A9172A30>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_A9172A30);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_A9172A30 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_A9172A30 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_A9172A30 @value)
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
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_A9172A30 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_A9172A30, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_A9172A30();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ITestHooks_GrainReference_A9172A30 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_A9172A30>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_A9172A30 DeepCopy(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_A9172A30 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_A9172A30();
            return result;
        }
    }
}

namespace OrleansCodeGen.Orleans.Runtime.Versions
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "7261373F")]
    internal sealed class Invokable_IVersionStoreGrain_GrainReference_7261373F : global::Orleans.Runtime.TaskRequest<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Compatibility.CompatibilityStrategy>>
    {
        global::Orleans.Runtime.Versions.IVersionStoreGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "GetCompatibilityStrategies", null, null);
        public override string GetMethodName() => "GetCompatibilityStrategies";
        public override string GetInterfaceName() => "Orleans.Runtime.Versions.IVersionStoreGrain";
        public override string GetActivityName() => "IVersionStoreGrain/GetCompatibilityStrategies";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.Versions.IVersionStoreGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Compatibility.CompatibilityStrategy>> InvokeInner() => target.GetCompatibilityStrategies();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "743D88ED")]
    internal sealed class Invokable_IVersionStoreGrain_GrainReference_743D88ED : global::Orleans.Runtime.TaskRequest<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Selector.VersionSelectorStrategy>>
    {
        global::Orleans.Runtime.Versions.IVersionStoreGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "GetSelectorStrategies", null, null);
        public override string GetMethodName() => "GetSelectorStrategies";
        public override string GetInterfaceName() => "Orleans.Runtime.Versions.IVersionStoreGrain";
        public override string GetActivityName() => "IVersionStoreGrain/GetSelectorStrategies";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.Versions.IVersionStoreGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Selector.VersionSelectorStrategy>> InvokeInner() => target.GetSelectorStrategies();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "67EF9A39")]
    internal sealed class Invokable_IVersionStoreGrain_GrainReference_67EF9A39 : global::Orleans.Runtime.TaskRequest<global::Orleans.Versions.Compatibility.CompatibilityStrategy>
    {
        global::Orleans.Runtime.Versions.IVersionStoreGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "GetCompatibilityStrategy", null, null);
        public override string GetMethodName() => "GetCompatibilityStrategy";
        public override string GetInterfaceName() => "Orleans.Runtime.Versions.IVersionStoreGrain";
        public override string GetActivityName() => "IVersionStoreGrain/GetCompatibilityStrategy";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.Versions.IVersionStoreGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.Versions.Compatibility.CompatibilityStrategy> InvokeInner() => target.GetCompatibilityStrategy();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "8A72848A")]
    internal sealed class Invokable_IVersionStoreGrain_GrainReference_8A72848A : global::Orleans.Runtime.TaskRequest<global::Orleans.Versions.Selector.VersionSelectorStrategy>
    {
        global::Orleans.Runtime.Versions.IVersionStoreGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "GetSelectorStrategy", null, null);
        public override string GetMethodName() => "GetSelectorStrategy";
        public override string GetInterfaceName() => "Orleans.Runtime.Versions.IVersionStoreGrain";
        public override string GetActivityName() => "IVersionStoreGrain/GetSelectorStrategy";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.Versions.IVersionStoreGrain>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.Versions.Selector.VersionSelectorStrategy> InvokeInner() => target.GetSelectorStrategy();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "67A0B5AA")]
    internal sealed class Invokable_IVersionStoreGrain_GrainReference_67A0B5AA : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.Versions.Compatibility.CompatibilityStrategy arg0;
        global::Orleans.Runtime.Versions.IVersionStoreGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "SetCompatibilityStrategy", null, new[] { typeof(global::Orleans.Versions.Compatibility.CompatibilityStrategy) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "SetCompatibilityStrategy";
        public override string GetInterfaceName() => "Orleans.Runtime.Versions.IVersionStoreGrain";
        public override string GetActivityName() => "IVersionStoreGrain/SetCompatibilityStrategy";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.Versions.IVersionStoreGrain>();
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
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "E7532DE3")]
    internal sealed class Invokable_IVersionStoreGrain_GrainReference_E7532DE3 : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.Versions.Selector.VersionSelectorStrategy arg0;
        global::Orleans.Runtime.Versions.IVersionStoreGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "SetSelectorStrategy", null, new[] { typeof(global::Orleans.Versions.Selector.VersionSelectorStrategy) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "SetSelectorStrategy";
        public override string GetInterfaceName() => "Orleans.Runtime.Versions.IVersionStoreGrain";
        public override string GetActivityName() => "IVersionStoreGrain/SetSelectorStrategy";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.Versions.IVersionStoreGrain>();
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
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "1B7F13C8")]
    internal sealed class Invokable_IVersionStoreGrain_GrainReference_1B7F13C8 : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.Runtime.GrainInterfaceType arg0;
        public global::Orleans.Versions.Compatibility.CompatibilityStrategy arg1;
        global::Orleans.Runtime.Versions.IVersionStoreGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "SetCompatibilityStrategy", null, new[] { typeof(global::Orleans.Runtime.GrainInterfaceType), typeof(global::Orleans.Versions.Compatibility.CompatibilityStrategy) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "SetCompatibilityStrategy";
        public override string GetInterfaceName() => "Orleans.Runtime.Versions.IVersionStoreGrain";
        public override string GetActivityName() => "IVersionStoreGrain/SetCompatibilityStrategy";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.Versions.IVersionStoreGrain>();
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
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "3E6DDE3E")]
    internal sealed class Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E : global::Orleans.Runtime.TaskRequest
    {
        public global::Orleans.Runtime.GrainInterfaceType arg0;
        public global::Orleans.Versions.Selector.VersionSelectorStrategy arg1;
        global::Orleans.Runtime.Versions.IVersionStoreGrain target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain), "SetSelectorStrategy", null, new[] { typeof(global::Orleans.Runtime.GrainInterfaceType), typeof(global::Orleans.Versions.Selector.VersionSelectorStrategy) });
        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "SetSelectorStrategy";
        public override string GetInterfaceName() => "Orleans.Runtime.Versions.IVersionStoreGrain";
        public override string GetActivityName() => "IVersionStoreGrain/SetSelectorStrategy";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetTarget<global::Orleans.Runtime.Versions.IVersionStoreGrain>();
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
    internal sealed class Proxy_IVersionStoreGrain : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.Versions.IVersionStoreGrain
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy> _copier0;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy> _copier1;
        public Proxy_IVersionStoreGrain(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(this, CodecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy>>(this, CodecProvider);
        }

        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Compatibility.CompatibilityStrategy>> global::Orleans.Runtime.Versions.IVersionStoreGrain.GetCompatibilityStrategies()
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_7261373F();
            return base.InvokeAsync<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Selector.VersionSelectorStrategy>> global::Orleans.Runtime.Versions.IVersionStoreGrain.GetSelectorStrategies()
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_743D88ED();
            return base.InvokeAsync<global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Selector.VersionSelectorStrategy>>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.Versions.Compatibility.CompatibilityStrategy> global::Orleans.Runtime.Versions.IVersionStoreGrain.GetCompatibilityStrategy()
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67EF9A39();
            return base.InvokeAsync<global::Orleans.Versions.Compatibility.CompatibilityStrategy>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.Versions.Selector.VersionSelectorStrategy> global::Orleans.Runtime.Versions.IVersionStoreGrain.GetSelectorStrategy()
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_8A72848A();
            return base.InvokeAsync<global::Orleans.Versions.Selector.VersionSelectorStrategy>(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.Versions.IVersionStoreGrain.SetCompatibilityStrategy(global::Orleans.Versions.Compatibility.CompatibilityStrategy arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67A0B5AA();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.Versions.IVersionStoreGrain.SetSelectorStrategy(global::Orleans.Versions.Selector.VersionSelectorStrategy arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_E7532DE3();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier1.DeepCopy(arg0, copyContext);
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.Versions.IVersionStoreGrain.SetCompatibilityStrategy(global::Orleans.Runtime.GrainInterfaceType arg0, global::Orleans.Versions.Compatibility.CompatibilityStrategy arg1)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_1B7F13C8();
            request.arg0 = arg0;
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg1 = _copier0.DeepCopy(arg1, copyContext);
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.Versions.IVersionStoreGrain.SetSelectorStrategy(global::Orleans.Runtime.GrainInterfaceType arg0, global::Orleans.Versions.Selector.VersionSelectorStrategy arg1)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E();
            request.arg0 = arg0;
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg1 = _copier1.DeepCopy(arg1, copyContext);
            return base.InvokeAsync(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IVersionStoreGrain_GrainReference_7261373F : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_7261373F>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_7261373F);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_7261373F instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_7261373F instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_7261373F @value)
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
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_7261373F ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_7261373F, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_7261373F();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IVersionStoreGrain_GrainReference_7261373F : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_7261373F>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_7261373F DeepCopy(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_7261373F original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_7261373F();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IVersionStoreGrain_GrainReference_743D88ED : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_743D88ED>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_743D88ED);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_743D88ED instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_743D88ED instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_743D88ED @value)
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
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_743D88ED ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_743D88ED, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_743D88ED();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IVersionStoreGrain_GrainReference_743D88ED : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_743D88ED>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_743D88ED DeepCopy(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_743D88ED original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_743D88ED();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IVersionStoreGrain_GrainReference_67EF9A39 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67EF9A39>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67EF9A39);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67EF9A39 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67EF9A39 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67EF9A39 @value)
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
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67EF9A39 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67EF9A39, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67EF9A39();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IVersionStoreGrain_GrainReference_67EF9A39 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67EF9A39>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67EF9A39 DeepCopy(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67EF9A39 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67EF9A39();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IVersionStoreGrain_GrainReference_8A72848A : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_8A72848A>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_8A72848A);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_8A72848A instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_8A72848A instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_8A72848A @value)
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
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_8A72848A ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_8A72848A, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_8A72848A();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IVersionStoreGrain_GrainReference_8A72848A : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_8A72848A>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_8A72848A DeepCopy(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_8A72848A original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_8A72848A();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IVersionStoreGrain_GrainReference_67A0B5AA : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67A0B5AA>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67A0B5AA);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Versions.Compatibility.CompatibilityStrategy);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Compatibility.CompatibilityStrategy> _codec0;
        public Codec_Invokable_IVersionStoreGrain_GrainReference_67A0B5AA(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67A0B5AA instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67A0B5AA instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67A0B5AA @value)
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
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67A0B5AA ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67A0B5AA, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67A0B5AA();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IVersionStoreGrain_GrainReference_67A0B5AA : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67A0B5AA>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67A0B5AA DeepCopy(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67A0B5AA original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67A0B5AA();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IVersionStoreGrain_GrainReference_67A0B5AA(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IVersionStoreGrain_GrainReference_E7532DE3 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_E7532DE3>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_E7532DE3);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Versions.Selector.VersionSelectorStrategy);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Selector.VersionSelectorStrategy> _codec0;
        public Codec_Invokable_IVersionStoreGrain_GrainReference_E7532DE3(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Selector.VersionSelectorStrategy>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_E7532DE3 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_E7532DE3 instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_E7532DE3 @value)
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
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_E7532DE3 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_E7532DE3, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_E7532DE3();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IVersionStoreGrain_GrainReference_E7532DE3 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_E7532DE3>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_E7532DE3 DeepCopy(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_E7532DE3 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_E7532DE3();
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IVersionStoreGrain_GrainReference_E7532DE3(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IVersionStoreGrain_GrainReference_1B7F13C8 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_1B7F13C8>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_1B7F13C8);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainInterfaceType);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainInterfaceType _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Versions.Compatibility.CompatibilityStrategy);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Compatibility.CompatibilityStrategy> _codec1;
        public Codec_Invokable_IVersionStoreGrain_GrainReference_1B7F13C8(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainInterfaceType>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_1B7F13C8 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_1B7F13C8 instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_1B7F13C8 @value)
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
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_1B7F13C8 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_1B7F13C8, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_1B7F13C8();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IVersionStoreGrain_GrainReference_1B7F13C8 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_1B7F13C8>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_1B7F13C8 DeepCopy(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_1B7F13C8 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_1B7F13C8();
            result.arg0 = original.arg0;
            result.arg1 = _copier0.DeepCopy(original.arg1, context);
            return result;
        }

        public Copier_Invokable_IVersionStoreGrain_GrainReference_1B7F13C8(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainInterfaceType);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainInterfaceType _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Versions.Selector.VersionSelectorStrategy);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Selector.VersionSelectorStrategy> _codec1;
        public Codec_Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainInterfaceType>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Selector.VersionSelectorStrategy>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E @value)
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
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E DeepCopy(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E();
            result.arg0 = original.arg0;
            result.arg1 = _copier0.DeepCopy(original.arg1, context);
            return result;
        }

        public Copier_Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_VersionStoreGrainState : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.Versions.VersionStoreGrainState>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.Versions.VersionStoreGrainState);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Versions.Compatibility.CompatibilityStrategy);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Compatibility.CompatibilityStrategy> _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Compatibility.CompatibilityStrategy>);
        private readonly global::Orleans.Serialization.Codecs.DictionaryCodec<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Compatibility.CompatibilityStrategy> _codec1;
        private readonly global::System.Type _type2 = typeof(global::Orleans.Versions.Selector.VersionSelectorStrategy);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Selector.VersionSelectorStrategy> _codec2;
        private readonly global::System.Type _type3 = typeof(global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Selector.VersionSelectorStrategy>);
        private readonly global::Orleans.Serialization.Codecs.DictionaryCodec<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Selector.VersionSelectorStrategy> _codec3;
        private static readonly global::System.Action<global::Orleans.Runtime.Versions.VersionStoreGrainState, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Compatibility.CompatibilityStrategy>> setField1 = (global::System.Action<global::Orleans.Runtime.Versions.VersionStoreGrainState, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Compatibility.CompatibilityStrategy>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.Versions.VersionStoreGrainState), "CompatibilityStrategies");
        private static readonly global::System.Action<global::Orleans.Runtime.Versions.VersionStoreGrainState, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Selector.VersionSelectorStrategy>> setField3 = (global::System.Action<global::Orleans.Runtime.Versions.VersionStoreGrainState, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Selector.VersionSelectorStrategy>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.Versions.VersionStoreGrainState), "VersionSelectorStrategies");
        public Codec_VersionStoreGrainState(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCodec<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Selector.VersionSelectorStrategy>>(this, codecProvider);
            _codec3 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCodec<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Selector.VersionSelectorStrategy>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.Versions.VersionStoreGrainState instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, instance.CompatibilityStrategies);
            _codec3.WriteField(ref writer, 1U, _type3, instance.VersionSelectorStrategies);
            _codec2.WriteField(ref writer, 1U, _type2, instance.SelectorOverride);
            _codec0.WriteField(ref writer, 1U, _type0, instance.CompatibilityOverride);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.Versions.VersionStoreGrainState instance)
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
                    setField3(instance, _codec3.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.SelectorOverride = _codec2.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.CompatibilityOverride = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.Versions.VersionStoreGrainState @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.Versions.VersionStoreGrainState ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.Versions.VersionStoreGrainState, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.Versions.VersionStoreGrainState();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_VersionStoreGrainState : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Runtime.Versions.VersionStoreGrainState>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy> _copier0;
        private readonly global::Orleans.Serialization.Codecs.DictionaryCopier<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Compatibility.CompatibilityStrategy> _copier1;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy> _copier2;
        private readonly global::Orleans.Serialization.Codecs.DictionaryCopier<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Selector.VersionSelectorStrategy> _copier3;
        private static readonly global::System.Action<global::Orleans.Runtime.Versions.VersionStoreGrainState, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Compatibility.CompatibilityStrategy>> setField1 = (global::System.Action<global::Orleans.Runtime.Versions.VersionStoreGrainState, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Compatibility.CompatibilityStrategy>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.Versions.VersionStoreGrainState), "CompatibilityStrategies");
        private static readonly global::System.Action<global::Orleans.Runtime.Versions.VersionStoreGrainState, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Selector.VersionSelectorStrategy>> setField3 = (global::System.Action<global::Orleans.Runtime.Versions.VersionStoreGrainState, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Selector.VersionSelectorStrategy>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.Versions.VersionStoreGrainState), "VersionSelectorStrategies");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.Versions.VersionStoreGrainState DeepCopy(global::Orleans.Runtime.Versions.VersionStoreGrainState original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Runtime.Versions.VersionStoreGrainState existing))
                return existing;
            var result = new global::Orleans.Runtime.Versions.VersionStoreGrainState();
            context.RecordCopy(original, result);
            setField1(result, _copier1.DeepCopy(original.CompatibilityStrategies, context));
            setField3(result, _copier3.DeepCopy(original.VersionSelectorStrategies, context));
            result.SelectorOverride = _copier2.DeepCopy(original.SelectorOverride, context);
            result.CompatibilityOverride = _copier0.DeepCopy(original.CompatibilityOverride, context);
            return result;
        }

        public Copier_VersionStoreGrainState(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCopier<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Compatibility.CompatibilityStrategy>>(this, codecProvider);
            _copier2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Versions.Selector.VersionSelectorStrategy>>(this, codecProvider);
            _copier3 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCopier<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Versions.Selector.VersionSelectorStrategy>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_VersionStoreGrainState : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.Versions.VersionStoreGrainState>
    {
        public global::Orleans.Runtime.Versions.VersionStoreGrainState Create() => new global::Orleans.Runtime.Versions.VersionStoreGrainState();
    }
}

namespace OrleansCodeGen.Orleans.Runtime.MembershipService
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansClusterConnectivityCheckFailedException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.MembershipService.OrleansClusterConnectivityCheckFailedException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.MembershipService.OrleansClusterConnectivityCheckFailedException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        public Codec_OrleansClusterConnectivityCheckFailedException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.MembershipService.OrleansClusterConnectivityCheckFailedException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.MembershipService.OrleansClusterConnectivityCheckFailedException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.MembershipService.OrleansClusterConnectivityCheckFailedException @value)
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
        public global::Orleans.Runtime.MembershipService.OrleansClusterConnectivityCheckFailedException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.MembershipService.OrleansClusterConnectivityCheckFailedException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.MembershipService.OrleansClusterConnectivityCheckFailedException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansClusterConnectivityCheckFailedException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.MembershipService.OrleansClusterConnectivityCheckFailedException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_OrleansClusterConnectivityCheckFailedException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_OrleansClusterConnectivityCheckFailedException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.MembershipService.OrleansClusterConnectivityCheckFailedException>
    {
        public global::Orleans.Runtime.MembershipService.OrleansClusterConnectivityCheckFailedException Create() => new global::Orleans.Runtime.MembershipService.OrleansClusterConnectivityCheckFailedException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansMissingMembershipEntryException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.MembershipService.OrleansMissingMembershipEntryException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.MembershipService.OrleansMissingMembershipEntryException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        public Codec_OrleansMissingMembershipEntryException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.MembershipService.OrleansMissingMembershipEntryException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.MembershipService.OrleansMissingMembershipEntryException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.MembershipService.OrleansMissingMembershipEntryException @value)
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
        public global::Orleans.Runtime.MembershipService.OrleansMissingMembershipEntryException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.MembershipService.OrleansMissingMembershipEntryException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.MembershipService.OrleansMissingMembershipEntryException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansMissingMembershipEntryException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.MembershipService.OrleansMissingMembershipEntryException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_OrleansMissingMembershipEntryException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_OrleansMissingMembershipEntryException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.MembershipService.OrleansMissingMembershipEntryException>
    {
        public global::Orleans.Runtime.MembershipService.OrleansMissingMembershipEntryException Create() => new global::Orleans.Runtime.MembershipService.OrleansMissingMembershipEntryException();
    }
}

namespace OrleansCodeGen.OrleansRuntime
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Metadata_OrleansRuntime : global::Orleans.Serialization.Configuration.TypeManifestProviderBase
    {
        protected override void ConfigureInner(global::Orleans.Serialization.Configuration.TypeManifestOptions config)
        {
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_GrainMigrationPackage));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Development.Codec_Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.LeaseProviders.Codec_Invokable_ILeaseProvider_GrainReference_5C7B2877));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.LeaseProviders.Codec_Invokable_ILeaseProvider_GrainReference_ACF8E0DD));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.LeaseProviders.Codec_Invokable_ILeaseProvider_GrainReference_F2BF11D0));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.GrainDirectory.Codec_Invokable_IRemoteClientDirectory_GrainReference_972F9953));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.GrainDirectory.Codec_Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IRemoteGrainDirectory_GrainReference_7DF50601));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.GrainDirectory.Codec_Invokable_IDhtGrainDirectory_GrainReference_B5C58E36));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.GrainDirectory.Codec_Invokable_IDhtGrainDirectory_GrainReference_9F511ACB));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.GrainDirectory.Codec_Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.GrainDirectory.Codec_Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.GrainDirectory.Codec_Invokable_IDhtGrainDirectory_GrainReference_C0878611));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.GrainDirectory.Codec_Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.MembershipService.Codec_OrleansClusterConnectivityCheckFailedException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.MembershipService.Codec_OrleansMissingMembershipEntryException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_ClusterMember));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_ClusterMembershipSnapshot));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_ClusterMembershipUpdate));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Codec_Invokable_ITestHooks_GrainReference_6E596A25));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Codec_Invokable_ITestHooks_GrainReference_3A061434));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Codec_Invokable_ITestHooks_GrainReference_898941AE));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Codec_Invokable_ITestHooks_GrainReference_92407CFC));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Codec_Invokable_ITestHooks_GrainReference_B4C39864));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Codec_Invokable_ITestHooks_GrainReference_1C8A306F));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Codec_Invokable_ITestHooks_GrainReference_BDC27193));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Codec_Invokable_ITestHooks_GrainReference_A9172A30));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IGrainTimerInvoker_GrainReference_3F6C2672));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Codec_Invokable_IVersionStoreGrain_GrainReference_7261373F));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Codec_Invokable_IVersionStoreGrain_GrainReference_743D88ED));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Codec_Invokable_IVersionStoreGrain_GrainReference_67EF9A39));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Codec_Invokable_IVersionStoreGrain_GrainReference_8A72848A));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Codec_Invokable_IVersionStoreGrain_GrainReference_67A0B5AA));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Codec_Invokable_IVersionStoreGrain_GrainReference_E7532DE3));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Codec_Invokable_IVersionStoreGrain_GrainReference_1B7F13C8));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Codec_Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Codec_VersionStoreGrainState));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.GrainMigrationPackage>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Development.Copier_Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.LeaseProviders.Copier_Invokable_ILeaseProvider_GrainReference_5C7B2877));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.LeaseProviders.Copier_Invokable_ILeaseProvider_GrainReference_ACF8E0DD));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.LeaseProviders.Copier_Invokable_ILeaseProvider_GrainReference_F2BF11D0));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.GrainDirectory.Copier_Invokable_IRemoteClientDirectory_GrainReference_972F9953));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.GrainDirectory.Copier_Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IRemoteGrainDirectory_GrainReference_7DF50601));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.GrainDirectory.Copier_Invokable_IDhtGrainDirectory_GrainReference_B5C58E36));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.GrainDirectory.Copier_Invokable_IDhtGrainDirectory_GrainReference_9F511ACB));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.GrainDirectory.Copier_Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.GrainDirectory.Copier_Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.GrainDirectory.Copier_Invokable_IDhtGrainDirectory_GrainReference_C0878611));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.GrainDirectory.Copier_Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.MembershipService.Copier_OrleansClusterConnectivityCheckFailedException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.MembershipService.Copier_OrleansMissingMembershipEntryException));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.ClusterMember>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.ClusterMembershipSnapshot>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.ClusterMembershipUpdate>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Copier_Invokable_ITestHooks_GrainReference_6E596A25));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Copier_Invokable_ITestHooks_GrainReference_3A061434));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Copier_Invokable_ITestHooks_GrainReference_898941AE));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Copier_Invokable_ITestHooks_GrainReference_92407CFC));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Copier_Invokable_ITestHooks_GrainReference_B4C39864));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Copier_Invokable_ITestHooks_GrainReference_1C8A306F));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Copier_Invokable_ITestHooks_GrainReference_BDC27193));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Copier_Invokable_ITestHooks_GrainReference_A9172A30));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IGrainTimerInvoker_GrainReference_3F6C2672));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Copier_Invokable_IVersionStoreGrain_GrainReference_7261373F));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Copier_Invokable_IVersionStoreGrain_GrainReference_743D88ED));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Copier_Invokable_IVersionStoreGrain_GrainReference_67EF9A39));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Copier_Invokable_IVersionStoreGrain_GrainReference_8A72848A));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Copier_Invokable_IVersionStoreGrain_GrainReference_67A0B5AA));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Copier_Invokable_IVersionStoreGrain_GrainReference_E7532DE3));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Copier_Invokable_IVersionStoreGrain_GrainReference_1B7F13C8));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Copier_Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Copier_VersionStoreGrainState));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.Proxy_IActivationMigrationManagerSystemTarget));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.Development.Proxy_IDevelopmentLeaseProviderGrain));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.GrainDirectory.Proxy_IRemoteClientDirectory));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.Proxy_IRemoteGrainDirectory));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.Proxy_ISiloManifestSystemTarget));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Proxy_ITestHooksSystemTarget));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.Proxy_IGrainTimerInvoker));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Proxy_IVersionStoreGrain));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.IActivationMigrationManagerSystemTarget));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.Development.IDevelopmentLeaseProviderGrain));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.GrainDirectory.IRemoteClientDirectory));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.IRemoteGrainDirectory));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.ISiloManifestSystemTarget));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.TestHooks.ITestHooksSystemTarget));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.IGrainTimerInvoker));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.CancellationSourcesExtension));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.ActivationData));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.ActivationMigrationManager));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.Catalog));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.Management.ManagementGrain));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.Development.DevelopmentLeaseProviderGrain));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.GrainDirectory.ClientDirectory));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.GrainDirectory.RemoteGrainDirectory));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.ClusterManifestSystemTarget));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.MembershipService.MembershipSystemTarget));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.MembershipService.MembershipTableSystemTarget));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.Placement.Repartitioning.ActivationRepartitioner));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.DeploymentLoadPublisher));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.FallbackSystemTarget));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.LifecycleSchedulingSystemTarget));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.SiloControl));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.TestHooks.TestHooksSystemTarget));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.Versions.VersionStoreGrain));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.MembershipService.Activator_OrleansClusterConnectivityCheckFailedException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.MembershipService.Activator_OrleansMissingMembershipEntryException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Versions.Activator_VersionStoreGrainState));
            var n1 = config.CompoundTypeAliases.Add("inv");
            var n2 = n1.Add(typeof(global::Orleans.Runtime.GrainReference));
            var n3 = n2.Add(typeof(global::Orleans.Runtime.IActivationMigrationManagerSystemTarget));
            n3.Add("29E9E63F", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IActivationMigrationManagerSystemTarget_GrainReference_29E9E63F));
            var n5 = n2.Add(typeof(global::Orleans.Runtime.Development.IDevelopmentLeaseProviderGrain));
            n5.Add("847FCE12", typeof(OrleansCodeGen.Orleans.Runtime.Development.Invokable_IDevelopmentLeaseProviderGrain_GrainReference_847FCE12));
            var n7 = n2.Add(typeof(global::Orleans.LeaseProviders.ILeaseProvider));
            n7.Add("5C7B2877", typeof(OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_5C7B2877));
            n7.Add("ACF8E0DD", typeof(OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_ACF8E0DD));
            n7.Add("F2BF11D0", typeof(OrleansCodeGen.Orleans.LeaseProviders.Invokable_ILeaseProvider_GrainReference_F2BF11D0));
            var n11 = n2.Add(typeof(global::Orleans.Runtime.GrainDirectory.IRemoteClientDirectory));
            n11.Add("972F9953", typeof(OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_972F9953));
            n11.Add("A6E49CD1", typeof(OrleansCodeGen.Orleans.Runtime.GrainDirectory.Invokable_IRemoteClientDirectory_GrainReference_A6E49CD1));
            var n14 = n2.Add(typeof(global::Orleans.Runtime.IRemoteGrainDirectory));
            n14.Add("CD06EAEE", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_CD06EAEE));
            n14.Add("7DF50601", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_7DF50601));
            n14.Add("9ABE3793", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IRemoteGrainDirectory_GrainReference_9ABE3793));
            var n18 = n2.Add(typeof(global::Orleans.GrainDirectory.IDhtGrainDirectory));
            n18.Add("B5C58E36", typeof(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_B5C58E36));
            n18.Add("9F511ACB", typeof(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9F511ACB));
            n18.Add("9AE7D8E0", typeof(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_9AE7D8E0));
            n18.Add("DBC70A4F", typeof(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_DBC70A4F));
            n18.Add("C0878611", typeof(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_C0878611));
            n18.Add("1BA64C6F", typeof(OrleansCodeGen.Orleans.GrainDirectory.Invokable_IDhtGrainDirectory_GrainReference_1BA64C6F));
            var n25 = n2.Add(typeof(global::Orleans.Runtime.ISiloManifestSystemTarget));
            n25.Add("1857A4C8", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_ISiloManifestSystemTarget_GrainReference_1857A4C8));
            var n27 = n2.Add(typeof(global::Orleans.Runtime.TestHooks.ITestHooks));
            n27.Add("6E596A25", typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_6E596A25));
            n27.Add("3A061434", typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_3A061434));
            n27.Add("898941AE", typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_898941AE));
            n27.Add("92407CFC", typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_92407CFC));
            n27.Add("B4C39864", typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_B4C39864));
            n27.Add("1C8A306F", typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_1C8A306F));
            n27.Add("BDC27193", typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_BDC27193));
            n27.Add("A9172A30", typeof(OrleansCodeGen.Orleans.Runtime.TestHooks.Invokable_ITestHooks_GrainReference_A9172A30));
            var n36 = n2.Add(typeof(global::Orleans.Runtime.IGrainTimerInvoker));
            n36.Add("3F6C2672", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IGrainTimerInvoker_GrainReference_3F6C2672));
            var n38 = n2.Add(typeof(global::Orleans.Runtime.Versions.IVersionStoreGrain));
            n38.Add("7261373F", typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_7261373F));
            n38.Add("743D88ED", typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_743D88ED));
            n38.Add("67EF9A39", typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67EF9A39));
            n38.Add("8A72848A", typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_8A72848A));
            n38.Add("67A0B5AA", typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_67A0B5AA));
            n38.Add("E7532DE3", typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_E7532DE3));
            n38.Add("1B7F13C8", typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_1B7F13C8));
            n38.Add("3E6DDE3E", typeof(OrleansCodeGen.Orleans.Runtime.Versions.Invokable_IVersionStoreGrain_GrainReference_3E6DDE3E));
        }
    }
}