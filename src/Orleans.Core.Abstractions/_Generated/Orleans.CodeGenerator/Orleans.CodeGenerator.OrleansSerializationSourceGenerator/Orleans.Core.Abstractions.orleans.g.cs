#pragma warning disable CS1591
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Core.Abstractions")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Serialization")]
[assembly: global::Orleans.Serialization.Configuration.TypeManifestProviderAttribute(typeof(OrleansCodeGen.OrleansCoreAbstractions.Metadata_OrleansCoreAbstractions))]
namespace OrleansCodeGen.Orleans.Runtime
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), "Ext", typeof(global::Orleans.Runtime.ICancellationSourcesExtension), typeof(global::Orleans.Runtime.ICancellationSourcesExtension), "50F75C16")]
    internal sealed class Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16 : global::Orleans.Runtime.TaskRequest
    {
        public global::System.Guid arg0;
        global::Orleans.Runtime.ICancellationSourcesExtension target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.ICancellationSourcesExtension), "CancelRemoteToken", null, new[] { typeof(global::System.Guid) });
        public Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16() : base()
        {
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.AlwaysInterleave);
        }

        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "CancelRemoteToken";
        public override string GetInterfaceName() => "Orleans.Runtime.ICancellationSourcesExtension";
        public override string GetActivityName() => "ICancellationSourcesExtension/CancelRemoteToken";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.ICancellationSourcesExtension);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetComponent<global::Orleans.Runtime.ICancellationSourcesExtension>();
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
                    arg0 = (global::System.Guid)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.CancelRemoteToken(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_ICancellationSourcesExtension : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.ICancellationSourcesExtension
    {
        public Proxy_ICancellationSourcesExtension(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.Task global::Orleans.Runtime.ICancellationSourcesExtension.CancelRemoteToken(global::System.Guid arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16();
            request.arg0 = arg0;
            return base.InvokeAsync(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), "Ext", typeof(global::Orleans.Runtime.IAsyncEnumerableGrainExtension), typeof(global::Orleans.Runtime.IAsyncEnumerableGrainExtension), "370CD5AB")]
    public sealed class Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T> : global::Orleans.Runtime.Request<global::System.ValueTuple<global::Orleans.Runtime.EnumerationResult, global::System.Object>>
    {
        public global::System.Guid arg0;
        public global::Orleans.Runtime.IAsyncEnumerableRequest<T> arg1;
        global::Orleans.Runtime.IAsyncEnumerableGrainExtension target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IAsyncEnumerableGrainExtension), "StartEnumeration", new[] { typeof(T) }, new[] { typeof(global::System.Guid), typeof(global::Orleans.Runtime.IAsyncEnumerableRequest<T>) });
        public Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1() : base()
        {
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.AlwaysInterleave);
        }

        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "StartEnumeration<T>";
        public override string GetInterfaceName() => "Orleans.Runtime.IAsyncEnumerableGrainExtension";
        public override string GetActivityName() => "IAsyncEnumerableGrainExtension/StartEnumeration<T>";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IAsyncEnumerableGrainExtension);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetComponent<global::Orleans.Runtime.IAsyncEnumerableGrainExtension>();
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
                    arg0 = (global::System.Guid)value;
                    return;
                case 1:
                    arg1 = (global::Orleans.Runtime.IAsyncEnumerableRequest<T>)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.ValueTask<global::System.ValueTuple<global::Orleans.Runtime.EnumerationResult, global::System.Object>> InvokeInner() => target.StartEnumeration<T>(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), "Ext", typeof(global::Orleans.Runtime.IAsyncEnumerableGrainExtension), typeof(global::Orleans.Runtime.IAsyncEnumerableGrainExtension), "A7FA7E30")]
    public sealed class Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T> : global::Orleans.Runtime.Request<global::System.ValueTuple<global::Orleans.Runtime.EnumerationResult, global::System.Object>>
    {
        public global::System.Guid arg0;
        global::Orleans.Runtime.IAsyncEnumerableGrainExtension target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IAsyncEnumerableGrainExtension), "MoveNext", new[] { typeof(T) }, new[] { typeof(global::System.Guid) });
        public Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1() : base()
        {
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.AlwaysInterleave);
        }

        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "MoveNext<T>";
        public override string GetInterfaceName() => "Orleans.Runtime.IAsyncEnumerableGrainExtension";
        public override string GetActivityName() => "IAsyncEnumerableGrainExtension/MoveNext<T>";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IAsyncEnumerableGrainExtension);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetComponent<global::Orleans.Runtime.IAsyncEnumerableGrainExtension>();
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
                    arg0 = (global::System.Guid)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.ValueTask<global::System.ValueTuple<global::Orleans.Runtime.EnumerationResult, global::System.Object>> InvokeInner() => target.MoveNext<T>(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), "Ext", typeof(global::Orleans.Runtime.IAsyncEnumerableGrainExtension), typeof(global::Orleans.Runtime.IAsyncEnumerableGrainExtension), "3C6D7209")]
    public sealed class Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209 : global::Orleans.Runtime.Request
    {
        public global::System.Guid arg0;
        global::Orleans.Runtime.IAsyncEnumerableGrainExtension target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Runtime.IAsyncEnumerableGrainExtension), "DisposeAsync", null, new[] { typeof(global::System.Guid) });
        public Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209() : base()
        {
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.AlwaysInterleave);
        }

        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "DisposeAsync";
        public override string GetInterfaceName() => "Orleans.Runtime.IAsyncEnumerableGrainExtension";
        public override string GetActivityName() => "IAsyncEnumerableGrainExtension/DisposeAsync";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Runtime.IAsyncEnumerableGrainExtension);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetComponent<global::Orleans.Runtime.IAsyncEnumerableGrainExtension>();
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
                    arg0 = (global::System.Guid)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.ValueTask InvokeInner() => target.DisposeAsync(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IAsyncEnumerableGrainExtension : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAsyncEnumerableGrainExtension
    {
        public Proxy_IAsyncEnumerableGrainExtension(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.ValueTask<global::System.ValueTuple<global::Orleans.Runtime.EnumerationResult, global::System.Object>> global::Orleans.Runtime.IAsyncEnumerableGrainExtension.StartEnumeration<T>(global::System.Guid arg0, global::Orleans.Runtime.IAsyncEnumerableRequest<T> arg1)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T>();
            request.arg0 = arg0;
            request.arg1 = arg1;
            return base.InvokeAsync<global::System.ValueTuple<global::Orleans.Runtime.EnumerationResult, global::System.Object>>(request);
        }

        global::System.Threading.Tasks.ValueTask<global::System.ValueTuple<global::Orleans.Runtime.EnumerationResult, global::System.Object>> global::Orleans.Runtime.IAsyncEnumerableGrainExtension.MoveNext<T>(global::System.Guid arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T>();
            request.arg0 = arg0;
            return base.InvokeAsync<global::System.ValueTuple<global::Orleans.Runtime.EnumerationResult, global::System.Object>>(request);
        }

        global::System.Threading.Tasks.ValueTask global::Orleans.Runtime.IAsyncEnumerableGrainExtension.DisposeAsync(global::System.Guid arg0)
        {
            var request = new OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209();
            request.arg0 = arg0;
            return base.InvokeAsync(request);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IAddressable : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable
    {
        public Proxy_IAddressable(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IGrainExtension : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IGrainExtension
    {
        public Proxy_IGrainExtension(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16 instance)
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
                    instance.arg0 = global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16 @value)
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
        public OrleansCodeGen.Orleans.Runtime.Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ClientNotAvailableException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.ClientNotAvailableException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.ClientNotAvailableException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.ClientNotAvailableException> _activator;
        public Codec_ClientNotAvailableException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.ClientNotAvailableException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.ClientNotAvailableException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.ClientNotAvailableException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.ClientNotAvailableException @value)
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
        public global::Orleans.Runtime.ClientNotAvailableException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.ClientNotAvailableException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ClientNotAvailableException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.ClientNotAvailableException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_ClientNotAvailableException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_GatewayTooBusyException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GatewayTooBusyException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.GatewayTooBusyException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        public Codec_GatewayTooBusyException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.GatewayTooBusyException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.GatewayTooBusyException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.GatewayTooBusyException @value)
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
        public global::Orleans.Runtime.GatewayTooBusyException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.GatewayTooBusyException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.GatewayTooBusyException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_GatewayTooBusyException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.GatewayTooBusyException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_GatewayTooBusyException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_GatewayTooBusyException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.GatewayTooBusyException>
    {
        public global::Orleans.Runtime.GatewayTooBusyException Create() => new global::Orleans.Runtime.GatewayTooBusyException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_GrainExtensionNotInstalledException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GrainExtensionNotInstalledException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.GrainExtensionNotInstalledException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        public Codec_GrainExtensionNotInstalledException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.GrainExtensionNotInstalledException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.GrainExtensionNotInstalledException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.GrainExtensionNotInstalledException @value)
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
        public global::Orleans.Runtime.GrainExtensionNotInstalledException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.GrainExtensionNotInstalledException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.GrainExtensionNotInstalledException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_GrainExtensionNotInstalledException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.GrainExtensionNotInstalledException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_GrainExtensionNotInstalledException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_GrainExtensionNotInstalledException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.GrainExtensionNotInstalledException>
    {
        public global::Orleans.Runtime.GrainExtensionNotInstalledException Create() => new global::Orleans.Runtime.GrainExtensionNotInstalledException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_LimitExceededException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.LimitExceededException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.LimitExceededException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        public Codec_LimitExceededException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.LimitExceededException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.LimitExceededException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.LimitExceededException @value)
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
        public global::Orleans.Runtime.LimitExceededException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.LimitExceededException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.LimitExceededException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_LimitExceededException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.LimitExceededException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_LimitExceededException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_LimitExceededException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.LimitExceededException>
    {
        public global::Orleans.Runtime.LimitExceededException Create() => new global::Orleans.Runtime.LimitExceededException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansConfigurationException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.OrleansConfigurationException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.OrleansConfigurationException);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Exception> _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.OrleansConfigurationException> _activator;
        public Codec_OrleansConfigurationException(global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Exception> _baseTypeSerializer, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.OrleansConfigurationException> _activator)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.OrleansConfigurationException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.OrleansConfigurationException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.OrleansConfigurationException @value)
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
        public global::Orleans.Runtime.OrleansConfigurationException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.OrleansConfigurationException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansConfigurationException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.OrleansConfigurationException, global::System.Exception>
    {
        public Copier_OrleansConfigurationException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.OrleansException>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Runtime.OrleansException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.OrleansException);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Exception> _baseTypeSerializer;
        public Codec_OrleansException(global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Exception> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.OrleansException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.OrleansException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.OrleansException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Runtime.OrleansException))
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
        public global::Orleans.Runtime.OrleansException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.OrleansException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Runtime.OrleansException();
                ReferenceCodec.MarkValueField(reader.Session);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Runtime.OrleansException>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.OrleansException, global::System.Exception>
    {
        public Copier_OrleansException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_OrleansException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.OrleansException>
    {
        public global::Orleans.Runtime.OrleansException Create() => new global::Orleans.Runtime.OrleansException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansLifecycleCanceledException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.OrleansLifecycleCanceledException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.OrleansLifecycleCanceledException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.OrleansLifecycleCanceledException> _activator;
        public Codec_OrleansLifecycleCanceledException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.OrleansLifecycleCanceledException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.OrleansLifecycleCanceledException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.OrleansLifecycleCanceledException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.OrleansLifecycleCanceledException @value)
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
        public global::Orleans.Runtime.OrleansLifecycleCanceledException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.OrleansLifecycleCanceledException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansLifecycleCanceledException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.OrleansLifecycleCanceledException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_OrleansLifecycleCanceledException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansMessageRejectionException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.OrleansMessageRejectionException>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Runtime.OrleansMessageRejectionException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.OrleansMessageRejectionException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.OrleansMessageRejectionException> _activator;
        public Codec_OrleansMessageRejectionException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.OrleansMessageRejectionException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.OrleansMessageRejectionException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.OrleansMessageRejectionException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.OrleansMessageRejectionException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Runtime.OrleansMessageRejectionException))
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
        public global::Orleans.Runtime.OrleansMessageRejectionException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.OrleansMessageRejectionException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.MarkValueField(reader.Session);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Runtime.OrleansMessageRejectionException>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansMessageRejectionException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.OrleansMessageRejectionException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_OrleansMessageRejectionException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_SiloUnavailableException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloUnavailableException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.SiloUnavailableException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansMessageRejectionException _baseTypeSerializer;
        public Codec_SiloUnavailableException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansMessageRejectionException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.SiloUnavailableException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.SiloUnavailableException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.SiloUnavailableException @value)
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
        public global::Orleans.Runtime.SiloUnavailableException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.SiloUnavailableException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.SiloUnavailableException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_SiloUnavailableException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.SiloUnavailableException, global::Orleans.Runtime.OrleansMessageRejectionException>
    {
        public Copier_SiloUnavailableException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_SiloUnavailableException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.SiloUnavailableException>
    {
        public global::Orleans.Runtime.SiloUnavailableException Create() => new global::Orleans.Runtime.SiloUnavailableException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_WrappedException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.WrappedException>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Runtime.WrappedException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.WrappedException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.WrappedException> _activator;
        public Codec_WrappedException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.WrappedException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.WrappedException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.OriginalExceptionType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.WrappedException instance)
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
                    instance.OriginalExceptionType = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.WrappedException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Runtime.WrappedException))
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
        public global::Orleans.Runtime.WrappedException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.WrappedException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.MarkValueField(reader.Session);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Runtime.WrappedException>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_WrappedException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.WrappedException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_WrappedException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void DeepCopy(global::Orleans.Runtime.WrappedException input, global::Orleans.Runtime.WrappedException output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            base.DeepCopy(input, output, context);
            output.OriginalExceptionType = input.OriginalExceptionType;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ActivationId : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.ActivationId>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Runtime.ActivationId>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.ActivationId);
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.ActivationId, global::System.Guid> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.ActivationId, global::System.Guid>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Runtime.ActivationId), "Key");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Runtime.ActivationId instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 0U, instance.Key);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Runtime.ActivationId instance)
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
                    setField0(ref instance, global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.ActivationId @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.ActivationId ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Runtime.ActivationId);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_GrainAddress : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GrainAddress>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.GrainAddress);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.ActivationId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_ActivationId _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.GrainId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainId _codec1;
        private readonly global::System.Type _type2 = typeof(global::Orleans.Runtime.MembershipVersion);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_MembershipVersion _codec2;
        private readonly global::System.Type _type3 = typeof(global::Orleans.Runtime.SiloAddress);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress> _codec3;
        private static readonly global::System.Func<global::Orleans.Runtime.GrainAddress, global::Orleans.Runtime.ActivationId> getField0 = (global::System.Func<global::Orleans.Runtime.GrainAddress, global::Orleans.Runtime.ActivationId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.GrainAddress), "_activationId");
        private static readonly global::System.Action<global::Orleans.Runtime.GrainAddress, global::Orleans.Runtime.ActivationId> setField0 = (global::System.Action<global::Orleans.Runtime.GrainAddress, global::Orleans.Runtime.ActivationId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.GrainAddress), "_activationId");
        private static readonly global::System.Func<global::Orleans.Runtime.GrainAddress, global::Orleans.Runtime.GrainId> getField1 = (global::System.Func<global::Orleans.Runtime.GrainAddress, global::Orleans.Runtime.GrainId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.GrainAddress), "_grainId");
        private static readonly global::System.Action<global::Orleans.Runtime.GrainAddress, global::Orleans.Runtime.GrainId> setField1 = (global::System.Action<global::Orleans.Runtime.GrainAddress, global::Orleans.Runtime.GrainId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.GrainAddress), "_grainId");
        private static readonly global::System.Action<global::Orleans.Runtime.GrainAddress, global::Orleans.Runtime.MembershipVersion> setField2 = (global::System.Action<global::Orleans.Runtime.GrainAddress, global::Orleans.Runtime.MembershipVersion>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.GrainAddress), "<MembershipVersion>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.GrainAddress, global::Orleans.Runtime.SiloAddress> setField3 = (global::System.Action<global::Orleans.Runtime.GrainAddress, global::Orleans.Runtime.SiloAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.GrainAddress), "<SiloAddress>k__BackingField");
        public Codec_GrainAddress(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_ActivationId>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainId>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_MembershipVersion>(this, codecProvider);
            _codec3 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.GrainAddress instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, getField1(instance));
            _codec0.WriteField(ref writer, 1U, _type0, getField0(instance));
            _codec3.WriteField(ref writer, 1U, _type3, instance.SiloAddress);
            _codec2.WriteField(ref writer, 1U, _type2, instance.MembershipVersion);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.GrainAddress instance)
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
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField3(instance, _codec3.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    setField2(instance, _codec2.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.GrainAddress @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.GrainAddress ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.GrainAddress, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.GrainAddress();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_GrainAddress : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.GrainAddress>
    {
        public global::Orleans.Runtime.GrainAddress Create() => new global::Orleans.Runtime.GrainAddress();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_GrainAddressCacheUpdate : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GrainAddressCacheUpdate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.GrainAddressCacheUpdate);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.GrainAddressCacheUpdate> _activator;
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainId _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.ActivationId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_ActivationId _codec1;
        private readonly global::System.Type _type2 = typeof(global::Orleans.Runtime.MembershipVersion);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_MembershipVersion _codec2;
        private readonly global::System.Type _type3 = typeof(global::Orleans.Runtime.SiloAddress);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress> _codec3;
        private static readonly global::System.Func<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.GrainId> getField0 = (global::System.Func<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.GrainId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.GrainAddressCacheUpdate), "_grainId");
        private static readonly global::System.Action<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.GrainId> setField0 = (global::System.Action<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.GrainId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.GrainAddressCacheUpdate), "_grainId");
        private static readonly global::System.Func<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.ActivationId> getField1 = (global::System.Func<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.ActivationId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.GrainAddressCacheUpdate), "_invalidActivationId");
        private static readonly global::System.Action<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.ActivationId> setField1 = (global::System.Action<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.ActivationId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.GrainAddressCacheUpdate), "_invalidActivationId");
        private static readonly global::System.Func<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.MembershipVersion> getField2 = (global::System.Func<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.MembershipVersion>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.GrainAddressCacheUpdate), "_invalidMembershipVersion");
        private static readonly global::System.Action<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.MembershipVersion> setField2 = (global::System.Action<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.MembershipVersion>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.GrainAddressCacheUpdate), "_invalidMembershipVersion");
        private static readonly global::System.Func<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.SiloAddress> getField3 = (global::System.Func<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.SiloAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.GrainAddressCacheUpdate), "_invalidSiloAddress");
        private static readonly global::System.Action<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.SiloAddress> setField3 = (global::System.Action<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.SiloAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.GrainAddressCacheUpdate), "_invalidSiloAddress");
        private static readonly global::System.Func<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.ActivationId> getField4 = (global::System.Func<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.ActivationId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.GrainAddressCacheUpdate), "_validActivationId");
        private static readonly global::System.Action<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.ActivationId> setField4 = (global::System.Action<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.ActivationId>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.GrainAddressCacheUpdate), "_validActivationId");
        private static readonly global::System.Func<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.MembershipVersion> getField5 = (global::System.Func<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.MembershipVersion>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.GrainAddressCacheUpdate), "_validMembershipVersion");
        private static readonly global::System.Action<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.MembershipVersion> setField5 = (global::System.Action<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.MembershipVersion>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.GrainAddressCacheUpdate), "_validMembershipVersion");
        private static readonly global::System.Func<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.SiloAddress> getField6 = (global::System.Func<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.SiloAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Runtime.GrainAddressCacheUpdate), "_validSiloAddress");
        private static readonly global::System.Action<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.SiloAddress> setField6 = (global::System.Action<global::Orleans.Runtime.GrainAddressCacheUpdate, global::Orleans.Runtime.SiloAddress>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.GrainAddressCacheUpdate), "_validSiloAddress");
        public Codec_GrainAddressCacheUpdate(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.GrainAddressCacheUpdate> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainId>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_ActivationId>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_MembershipVersion>(this, codecProvider);
            _codec3 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SiloAddress>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.GrainAddressCacheUpdate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, getField0(instance));
            _codec1.WriteField(ref writer, 1U, _type1, getField1(instance));
            _codec3.WriteField(ref writer, 1U, _type3, getField3(instance));
            _codec2.WriteField(ref writer, 1U, _type2, getField2(instance));
            _codec1.WriteField(ref writer, 1U, _type1, getField4(instance));
            _codec3.WriteField(ref writer, 1U, _type3, getField6(instance));
            _codec2.WriteField(ref writer, 1U, _type2, getField5(instance));
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.GrainAddressCacheUpdate instance)
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
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField3(instance, _codec3.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    setField2(instance, _codec2.ReadValue(ref reader, header));
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
                    setField6(instance, _codec3.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 6U)
                {
                    setField5(instance, _codec2.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.GrainAddressCacheUpdate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.GrainAddressCacheUpdate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.GrainAddressCacheUpdate, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_GrainId : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GrainId>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Runtime.GrainId>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.GrainId);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.IdSpan);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_IdSpan _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.GrainType);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainType _codec1;
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.IdSpan> getField0 = (global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.IdSpan>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueGetter(typeof(global::Orleans.Runtime.GrainId), "_key");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.IdSpan> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.IdSpan>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Runtime.GrainId), "_key");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.GrainType> getField1 = (global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.GrainType>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueGetter(typeof(global::Orleans.Runtime.GrainId), "_type");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.GrainType> setField1 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.GrainId, global::Orleans.Runtime.GrainType>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Runtime.GrainId), "_type");
        public Codec_GrainId(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_IdSpan>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainType>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Runtime.GrainId instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, getField1(ref instance));
            _codec0.WriteField(ref writer, 1U, _type0, getField0(ref instance));
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Runtime.GrainId instance)
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
                    setField1(ref instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField0(ref instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.GrainId @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.GrainId ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Runtime.GrainId);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_GrainInterfaceType : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GrainInterfaceType>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Runtime.GrainInterfaceType>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.GrainInterfaceType);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.IdSpan);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_IdSpan _codec0;
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Runtime.IdSpan> getField0 = (global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Runtime.IdSpan>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueGetter(typeof(global::Orleans.Runtime.GrainInterfaceType), "_value");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Runtime.IdSpan> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Runtime.IdSpan>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Runtime.GrainInterfaceType), "_value");
        public Codec_GrainInterfaceType(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_IdSpan>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Runtime.GrainInterfaceType instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, getField0(ref instance));
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Runtime.GrainInterfaceType instance)
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
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.GrainInterfaceType @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.GrainInterfaceType ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Runtime.GrainInterfaceType);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_GrainType : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GrainType>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Runtime.GrainType>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.GrainType);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.IdSpan);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_IdSpan _codec0;
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Runtime.GrainType, global::Orleans.Runtime.IdSpan> getField0 = (global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Runtime.GrainType, global::Orleans.Runtime.IdSpan>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueGetter(typeof(global::Orleans.Runtime.GrainType), "_value");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.GrainType, global::Orleans.Runtime.IdSpan> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.GrainType, global::Orleans.Runtime.IdSpan>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Runtime.GrainType), "_value");
        public Codec_GrainType(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_IdSpan>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Runtime.GrainType instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, getField0(ref instance));
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Runtime.GrainType instance)
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
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.GrainType @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.GrainType ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Runtime.GrainType);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_GuidId : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GuidId>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.GuidId);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.GuidId> _activator;
        private static readonly global::System.Action<global::Orleans.Runtime.GuidId, global::System.Guid> setField0 = (global::System.Action<global::Orleans.Runtime.GuidId, global::System.Guid>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.GuidId), "Guid");
        public Codec_GuidId(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.GuidId> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.GuidId instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 0U, instance.Guid);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.GuidId instance)
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
                    setField0(instance, global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.GuidId @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.GuidId ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.GuidId, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_IdSpan : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.IdSpan>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Runtime.IdSpan>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.IdSpan);
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Runtime.IdSpan, int> getField0 = (global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Runtime.IdSpan, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueGetter(typeof(global::Orleans.Runtime.IdSpan), "_hashCode");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.IdSpan, int> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.IdSpan, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Runtime.IdSpan), "_hashCode");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Runtime.IdSpan, byte[]> getField1 = (global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Runtime.IdSpan, byte[]>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueGetter(typeof(global::Orleans.Runtime.IdSpan), "_value");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.IdSpan, byte[]> setField1 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.IdSpan, byte[]>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Runtime.IdSpan), "_value");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Runtime.IdSpan instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, getField0(ref instance));
            global::Orleans.Serialization.Codecs.ByteArrayCodec.WriteField(ref writer, 1U, getField1(ref instance));
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Runtime.IdSpan instance)
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
                    setField0(ref instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(ref instance, global::Orleans.Serialization.Codecs.ByteArrayCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.IdSpan @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.IdSpan ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Runtime.IdSpan);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_LegacyGrainId : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.LegacyGrainId>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.LegacyGrainId);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.LegacyGrainId> _activator;
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.UniqueKey);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_UniqueKey _codec0;
        private static readonly global::System.Action<global::Orleans.Runtime.LegacyGrainId, global::Orleans.Runtime.UniqueKey> setField0 = (global::System.Action<global::Orleans.Runtime.LegacyGrainId, global::Orleans.Runtime.UniqueKey>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.LegacyGrainId), "Key");
        public Codec_LegacyGrainId(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.LegacyGrainId> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_UniqueKey>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.LegacyGrainId instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Key);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.LegacyGrainId instance)
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
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.LegacyGrainId @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.LegacyGrainId ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.LegacyGrainId, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_UniqueKey : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.UniqueKey>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.UniqueKey);
        private static readonly global::System.Action<global::Orleans.Runtime.UniqueKey, string> setField0 = (global::System.Action<global::Orleans.Runtime.UniqueKey, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.UniqueKey), "<KeyExt>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.UniqueKey, ulong> setField1 = (global::System.Action<global::Orleans.Runtime.UniqueKey, ulong>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.UniqueKey), "<N0>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.UniqueKey, ulong> setField2 = (global::System.Action<global::Orleans.Runtime.UniqueKey, ulong>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.UniqueKey), "<N1>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Runtime.UniqueKey, ulong> setField3 = (global::System.Action<global::Orleans.Runtime.UniqueKey, ulong>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.UniqueKey), "<TypeCodeData>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.UniqueKey instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.UInt64Codec.WriteField(ref writer, 0U, instance.N0);
            global::Orleans.Serialization.Codecs.UInt64Codec.WriteField(ref writer, 1U, instance.N1);
            global::Orleans.Serialization.Codecs.UInt64Codec.WriteField(ref writer, 1U, instance.TypeCodeData);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.KeyExt);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.UniqueKey instance)
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
                    setField1(instance, global::Orleans.Serialization.Codecs.UInt64Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField2(instance, global::Orleans.Serialization.Codecs.UInt64Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField3(instance, global::Orleans.Serialization.Codecs.UInt64Codec.ReadValue(ref reader, header));
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.UniqueKey @value)
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
        public global::Orleans.Runtime.UniqueKey ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.UniqueKey, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.UniqueKey();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_UniqueKey : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.UniqueKey>
    {
        public global::Orleans.Runtime.UniqueKey Create() => new global::Orleans.Runtime.UniqueKey();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ActivationCountBasedPlacement : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.ActivationCountBasedPlacement>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.ActivationCountBasedPlacement);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.ActivationCountBasedPlacement instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.ActivationCountBasedPlacement instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.ActivationCountBasedPlacement @value)
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
        public global::Orleans.Runtime.ActivationCountBasedPlacement ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.ActivationCountBasedPlacement, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.ActivationCountBasedPlacement();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_ActivationCountBasedPlacement : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.ActivationCountBasedPlacement>
    {
        public global::Orleans.Runtime.ActivationCountBasedPlacement Create() => new global::Orleans.Runtime.ActivationCountBasedPlacement();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_HashBasedPlacement : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.HashBasedPlacement>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.HashBasedPlacement);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.HashBasedPlacement instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.HashBasedPlacement instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.HashBasedPlacement @value)
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
        public global::Orleans.Runtime.HashBasedPlacement ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.HashBasedPlacement, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.HashBasedPlacement();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_HashBasedPlacement : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.HashBasedPlacement>
    {
        public global::Orleans.Runtime.HashBasedPlacement Create() => new global::Orleans.Runtime.HashBasedPlacement();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_PreferLocalPlacement : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.PreferLocalPlacement>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.PreferLocalPlacement);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.PreferLocalPlacement instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.PreferLocalPlacement instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.PreferLocalPlacement @value)
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
        public global::Orleans.Runtime.PreferLocalPlacement ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.PreferLocalPlacement, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.PreferLocalPlacement();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_PreferLocalPlacement : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.PreferLocalPlacement>
    {
        public global::Orleans.Runtime.PreferLocalPlacement Create() => new global::Orleans.Runtime.PreferLocalPlacement();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_RandomPlacement : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.RandomPlacement>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.RandomPlacement);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.RandomPlacement instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.RandomPlacement instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.RandomPlacement @value)
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
        public global::Orleans.Runtime.RandomPlacement ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.RandomPlacement, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.RandomPlacement();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_RandomPlacement : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.RandomPlacement>
    {
        public global::Orleans.Runtime.RandomPlacement Create() => new global::Orleans.Runtime.RandomPlacement();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_StatelessWorkerPlacement : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.StatelessWorkerPlacement>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.StatelessWorkerPlacement);
        private static readonly global::System.Action<global::Orleans.Runtime.StatelessWorkerPlacement, int> setField0 = (global::System.Action<global::Orleans.Runtime.StatelessWorkerPlacement, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.StatelessWorkerPlacement), "<MaxLocal>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.StatelessWorkerPlacement instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.MaxLocal);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.StatelessWorkerPlacement instance)
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
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.StatelessWorkerPlacement @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.StatelessWorkerPlacement ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.StatelessWorkerPlacement, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.StatelessWorkerPlacement();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_StatelessWorkerPlacement : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Runtime.StatelessWorkerPlacement>
    {
        private static readonly global::System.Action<global::Orleans.Runtime.StatelessWorkerPlacement, int> setField0 = (global::System.Action<global::Orleans.Runtime.StatelessWorkerPlacement, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Runtime.StatelessWorkerPlacement), "<MaxLocal>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.StatelessWorkerPlacement DeepCopy(global::Orleans.Runtime.StatelessWorkerPlacement original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Runtime.StatelessWorkerPlacement existing))
                return existing;
            var result = new global::Orleans.Runtime.StatelessWorkerPlacement();
            context.RecordCopy(original, result);
            setField0(result, original.MaxLocal);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_StatelessWorkerPlacement : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.StatelessWorkerPlacement>
    {
        public global::Orleans.Runtime.StatelessWorkerPlacement Create() => new global::Orleans.Runtime.StatelessWorkerPlacement();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_SystemTargetPlacementStrategy : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.SystemTargetPlacementStrategy>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.SystemTargetPlacementStrategy);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.SystemTargetPlacementStrategy instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.SystemTargetPlacementStrategy instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.SystemTargetPlacementStrategy @value)
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
        public global::Orleans.Runtime.SystemTargetPlacementStrategy ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.SystemTargetPlacementStrategy, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.SystemTargetPlacementStrategy();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_SystemTargetPlacementStrategy : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.SystemTargetPlacementStrategy>
    {
        public global::Orleans.Runtime.SystemTargetPlacementStrategy Create() => new global::Orleans.Runtime.SystemTargetPlacementStrategy();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_EnumerationResult : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.EnumerationResult>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.EnumerationResult);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.EnumerationResult @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, fieldIdDelta, expectedType, (int)@value, _codecFieldType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.EnumerationResult ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            return (global::Orleans.Runtime.EnumerationResult)global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T>);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.IAsyncEnumerableRequest<T>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.IAsyncEnumerableRequest<T>> _codec0;
        public Codec_Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.IAsyncEnumerableRequest<T>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 0U, instance.arg0);
            _codec0.WriteField(ref writer, 1U, _type0, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T> instance)
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
                    instance.arg0 = global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header);
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T> @value)
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
        public OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T>>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T> DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<T>();
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T>);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T> instance)
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
                    instance.arg0 = global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T> @value)
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
        public OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T>>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T> DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<T>();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209 instance)
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
                    instance.arg0 = global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209 @value)
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
        public OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209 DeepCopy(OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209();
            result.arg0 = original.arg0;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_AsyncEnumerableRequest<T> : global::Orleans.Serialization.Serializers.AbstractTypeSerializer<global::Orleans.Runtime.AsyncEnumerableRequest<T>>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.AsyncEnumerableRequest<T> instance)
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.MaxBatchSize);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.AsyncEnumerableRequest<T> instance)
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
                    instance.MaxBatchSize = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_AsyncEnumerableRequest<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Runtime.AsyncEnumerableRequest<T>>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Runtime.AsyncEnumerableRequest<T>>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.AsyncEnumerableRequest<T> DeepCopy(global::Orleans.Runtime.AsyncEnumerableRequest<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return context.DeepCopy(original);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Runtime.AsyncEnumerableRequest<T> input, global::Orleans.Runtime.AsyncEnumerableRequest<T> output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.MaxBatchSize = input.MaxBatchSize;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_EnumerationAbortedException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.EnumerationAbortedException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.EnumerationAbortedException);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Exception> _baseTypeSerializer;
        public Codec_EnumerationAbortedException(global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Exception> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.EnumerationAbortedException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.EnumerationAbortedException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.EnumerationAbortedException @value)
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
        public global::Orleans.Runtime.EnumerationAbortedException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.EnumerationAbortedException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Runtime.EnumerationAbortedException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_EnumerationAbortedException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.EnumerationAbortedException, global::System.Exception>
    {
        public Copier_EnumerationAbortedException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_EnumerationAbortedException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.EnumerationAbortedException>
    {
        public global::Orleans.Runtime.EnumerationAbortedException Create() => new global::Orleans.Runtime.EnumerationAbortedException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_GrainReferenceSurrogate : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GrainReferenceSurrogate>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Runtime.GrainReferenceSurrogate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.GrainReferenceSurrogate);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainId);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainId _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Runtime.GrainInterfaceType);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_GrainInterfaceType _codec1;
        public Codec_GrainReferenceSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainId>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_GrainInterfaceType>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Runtime.GrainReferenceSurrogate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.GrainId);
            _codec1.WriteField(ref writer, 1U, _type1, instance.GrainInterfaceType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Runtime.GrainReferenceSurrogate instance)
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
                    instance.GrainInterfaceType = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.GrainReferenceSurrogate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.GrainReferenceSurrogate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Runtime.GrainReferenceSurrogate);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_GrainReferenceNotBoundException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GrainReferenceNotBoundException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.GrainReferenceNotBoundException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.GrainReferenceNotBoundException> _activator;
        public Codec_GrainReferenceNotBoundException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Runtime.GrainReferenceNotBoundException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Runtime.GrainReferenceNotBoundException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Runtime.GrainReferenceNotBoundException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.GrainReferenceNotBoundException @value)
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
        public global::Orleans.Runtime.GrainReferenceNotBoundException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Runtime.GrainReferenceNotBoundException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_GrainReferenceNotBoundException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Runtime.GrainReferenceNotBoundException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_GrainReferenceNotBoundException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_MembershipVersion : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.MembershipVersion>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Runtime.MembershipVersion>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Runtime.MembershipVersion);
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.MembershipVersion, long> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Runtime.MembershipVersion, long>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Runtime.MembershipVersion), "<Value>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Runtime.MembershipVersion instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 0U, instance.Value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Runtime.MembershipVersion instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Runtime.MembershipVersion @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Runtime.MembershipVersion ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Runtime.MembershipVersion);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }
}
#pragma warning restore CS1591

namespace OrleansCodeGen.Orleans
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IGrain : global::Orleans.Runtime.GrainReference, global::Orleans.IGrain
    {
        public Proxy_IGrain(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IGrainWithGuidKey : global::Orleans.Runtime.GrainReference, global::Orleans.IGrainWithGuidKey
    {
        public Proxy_IGrainWithGuidKey(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IGrainWithIntegerKey : global::Orleans.Runtime.GrainReference, global::Orleans.IGrainWithIntegerKey
    {
        public Proxy_IGrainWithIntegerKey(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IGrainWithStringKey : global::Orleans.Runtime.GrainReference, global::Orleans.IGrainWithStringKey
    {
        public Proxy_IGrainWithStringKey(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IGrainWithGuidCompoundKey : global::Orleans.Runtime.GrainReference, global::Orleans.IGrainWithGuidCompoundKey
    {
        public Proxy_IGrainWithGuidCompoundKey(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IGrainWithIntegerCompoundKey : global::Orleans.Runtime.GrainReference, global::Orleans.IGrainWithIntegerCompoundKey
    {
        public Proxy_IGrainWithIntegerCompoundKey(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IGrainObserver : global::Orleans.Runtime.GrainReference, global::Orleans.IGrainObserver
    {
        public Proxy_IGrainObserver(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_ISystemTarget : global::Orleans.Runtime.GrainReference, global::Orleans.ISystemTarget
    {
        public Proxy_ISystemTarget(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_DeactivationReasonCode : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.DeactivationReasonCode>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.DeactivationReasonCode);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.DeactivationReasonCode @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.ByteCodec.WriteField(ref writer, fieldIdDelta, expectedType, (byte)@value, _codecFieldType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.DeactivationReasonCode ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            return (global::Orleans.DeactivationReasonCode)global::Orleans.Serialization.Codecs.ByteCodec.ReadValue(ref reader, field);
        }
    }
}

namespace OrleansCodeGen.Orleans.Core.Internal
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), "Ext", typeof(global::Orleans.Core.Internal.IGrainManagementExtension), typeof(global::Orleans.Core.Internal.IGrainManagementExtension), "1B9614D1")]
    public sealed class Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1 : global::Orleans.Runtime.Request
    {
        global::Orleans.Core.Internal.IGrainManagementExtension target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Core.Internal.IGrainManagementExtension), "DeactivateOnIdle", null, null);
        public override string GetMethodName() => "DeactivateOnIdle";
        public override string GetInterfaceName() => "Orleans.Core.Internal.IGrainManagementExtension";
        public override string GetActivityName() => "IGrainManagementExtension/DeactivateOnIdle";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Core.Internal.IGrainManagementExtension);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetComponent<global::Orleans.Core.Internal.IGrainManagementExtension>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.ValueTask InvokeInner() => target.DeactivateOnIdle();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), "Ext", typeof(global::Orleans.Core.Internal.IGrainManagementExtension), typeof(global::Orleans.Core.Internal.IGrainManagementExtension), "4CC93B45")]
    public sealed class Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45 : global::Orleans.Runtime.Request
    {
        global::Orleans.Core.Internal.IGrainManagementExtension target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Core.Internal.IGrainManagementExtension), "MigrateOnIdle", null, null);
        public override string GetMethodName() => "MigrateOnIdle";
        public override string GetInterfaceName() => "Orleans.Core.Internal.IGrainManagementExtension";
        public override string GetActivityName() => "IGrainManagementExtension/MigrateOnIdle";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Core.Internal.IGrainManagementExtension);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetComponent<global::Orleans.Core.Internal.IGrainManagementExtension>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            target = default;
        }

        protected override global::System.Threading.Tasks.ValueTask InvokeInner() => target.MigrateOnIdle();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IGrainManagementExtension : global::Orleans.Runtime.GrainReference, global::Orleans.Core.Internal.IGrainManagementExtension
    {
        public Proxy_IGrainManagementExtension(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.ValueTask global::Orleans.Core.Internal.IGrainManagementExtension.DeactivateOnIdle()
        {
            var request = new OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1();
            return base.InvokeAsync(request);
        }

        global::System.Threading.Tasks.ValueTask global::Orleans.Core.Internal.IGrainManagementExtension.MigrateOnIdle()
        {
            var request = new OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45();
            return base.InvokeAsync(request);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1 @value)
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
        public OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1 DeepCopy(OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1();
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45 instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45 @value)
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
        public OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45 DeepCopy(OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45();
            return result;
        }
    }
}

namespace OrleansCodeGen.Orleans.Services
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_IGrainService : global::Orleans.Runtime.GrainReference, global::Orleans.Services.IGrainService
    {
        public Proxy_IGrainService(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }
    }
}

namespace OrleansCodeGen.Orleans.CodeGeneration
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_InvokeMethodOptions : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.CodeGeneration.InvokeMethodOptions>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.CodeGeneration.InvokeMethodOptions);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.CodeGeneration.InvokeMethodOptions @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, fieldIdDelta, expectedType, (int)@value, _codecFieldType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.CodeGeneration.InvokeMethodOptions ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            return (global::Orleans.CodeGeneration.InvokeMethodOptions)global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, field);
        }
    }
}

namespace OrleansCodeGen.Orleans.Concurrency
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Immutable<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Concurrency.Immutable<T>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Concurrency.Immutable<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Concurrency.Immutable<T>);
        private readonly global::System.Type _type0 = typeof(T);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T> _codec0;
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Concurrency.Immutable<T>, T> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Concurrency.Immutable<T>, T>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Concurrency.Immutable<T>), "Value");
        public Codec_Immutable(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Concurrency.Immutable<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Concurrency.Immutable<T> instance)
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
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Concurrency.Immutable<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Concurrency.Immutable<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Concurrency.Immutable<T>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Immutable<T> : global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Concurrency.Immutable<T>>
    {
    }
}

namespace OrleansCodeGen.Orleans.Metadata
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ClusterManifest : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Metadata.ClusterManifest>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Metadata.ClusterManifest);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Metadata.ClusterManifest> _activator;
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Immutable.ImmutableArray<global::Orleans.Metadata.GrainManifest>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableArray<global::Orleans.Metadata.GrainManifest>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Metadata.GrainManifest>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Metadata.GrainManifest>> _codec1;
        private readonly global::System.Type _type2 = typeof(global::Orleans.Metadata.MajorMinorVersion);
        private readonly OrleansCodeGen.Orleans.Metadata.Codec_MajorMinorVersion _codec2;
        private static readonly global::System.Action<global::Orleans.Metadata.ClusterManifest, global::System.Collections.Immutable.ImmutableArray<global::Orleans.Metadata.GrainManifest>> setField0 = (global::System.Action<global::Orleans.Metadata.ClusterManifest, global::System.Collections.Immutable.ImmutableArray<global::Orleans.Metadata.GrainManifest>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Metadata.ClusterManifest), "<AllGrainManifests>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Metadata.ClusterManifest, global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Metadata.GrainManifest>> setField1 = (global::System.Action<global::Orleans.Metadata.ClusterManifest, global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Metadata.GrainManifest>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Metadata.ClusterManifest), "<Silos>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Metadata.ClusterManifest, global::Orleans.Metadata.MajorMinorVersion> setField2 = (global::System.Action<global::Orleans.Metadata.ClusterManifest, global::Orleans.Metadata.MajorMinorVersion>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Metadata.ClusterManifest), "<Version>k__BackingField");
        public Codec_ClusterManifest(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Metadata.ClusterManifest> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableArray<global::Orleans.Metadata.GrainManifest>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Metadata.GrainManifest>>>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Metadata.Codec_MajorMinorVersion>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Metadata.ClusterManifest instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec2.WriteField(ref writer, 0U, _type2, instance.Version);
            _codec1.WriteField(ref writer, 1U, _type1, instance.Silos);
            _codec0.WriteField(ref writer, 1U, _type0, instance.AllGrainManifests);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Metadata.ClusterManifest instance)
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
                    setField2(instance, _codec2.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(instance, _codec1.ReadValue(ref reader, header));
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Metadata.ClusterManifest @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Metadata.ClusterManifest ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Metadata.ClusterManifest, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_GrainInterfaceProperties : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Metadata.GrainInterfaceProperties>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Metadata.GrainInterfaceProperties);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Metadata.GrainInterfaceProperties> _activator;
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Immutable.ImmutableDictionary<string, string>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<string, string>> _codec0;
        private static readonly global::System.Action<global::Orleans.Metadata.GrainInterfaceProperties, global::System.Collections.Immutable.ImmutableDictionary<string, string>> setField0 = (global::System.Action<global::Orleans.Metadata.GrainInterfaceProperties, global::System.Collections.Immutable.ImmutableDictionary<string, string>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Metadata.GrainInterfaceProperties), "<Properties>k__BackingField");
        public Codec_GrainInterfaceProperties(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Metadata.GrainInterfaceProperties> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<string, string>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Metadata.GrainInterfaceProperties instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Properties);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Metadata.GrainInterfaceProperties instance)
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
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Metadata.GrainInterfaceProperties @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Metadata.GrainInterfaceProperties ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Metadata.GrainInterfaceProperties, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_GrainManifest : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Metadata.GrainManifest>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Metadata.GrainManifest);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Metadata.GrainManifest> _activator;
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.GrainType, global::Orleans.Metadata.GrainProperties>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.GrainType, global::Orleans.Metadata.GrainProperties>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Metadata.GrainInterfaceProperties>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Metadata.GrainInterfaceProperties>> _codec1;
        private static readonly global::System.Action<global::Orleans.Metadata.GrainManifest, global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.GrainType, global::Orleans.Metadata.GrainProperties>> setField0 = (global::System.Action<global::Orleans.Metadata.GrainManifest, global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.GrainType, global::Orleans.Metadata.GrainProperties>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Metadata.GrainManifest), "<Grains>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Metadata.GrainManifest, global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Metadata.GrainInterfaceProperties>> setField1 = (global::System.Action<global::Orleans.Metadata.GrainManifest, global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Metadata.GrainInterfaceProperties>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Metadata.GrainManifest), "<Interfaces>k__BackingField");
        public Codec_GrainManifest(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Metadata.GrainManifest> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.GrainType, global::Orleans.Metadata.GrainProperties>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<global::Orleans.Runtime.GrainInterfaceType, global::Orleans.Metadata.GrainInterfaceProperties>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Metadata.GrainManifest instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, instance.Interfaces);
            _codec0.WriteField(ref writer, 1U, _type0, instance.Grains);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Metadata.GrainManifest instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Metadata.GrainManifest @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Metadata.GrainManifest ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Metadata.GrainManifest, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_GrainProperties : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Metadata.GrainProperties>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Metadata.GrainProperties);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Metadata.GrainProperties> _activator;
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Immutable.ImmutableDictionary<string, string>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<string, string>> _codec0;
        private static readonly global::System.Action<global::Orleans.Metadata.GrainProperties, global::System.Collections.Immutable.ImmutableDictionary<string, string>> setField0 = (global::System.Action<global::Orleans.Metadata.GrainProperties, global::System.Collections.Immutable.ImmutableDictionary<string, string>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Metadata.GrainProperties), "<Properties>k__BackingField");
        public Codec_GrainProperties(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Metadata.GrainProperties> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Immutable.ImmutableDictionary<string, string>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Metadata.GrainProperties instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Properties);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Metadata.GrainProperties instance)
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
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Metadata.GrainProperties @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Metadata.GrainProperties ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Metadata.GrainProperties, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_MajorMinorVersion : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Metadata.MajorMinorVersion>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Metadata.MajorMinorVersion>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Metadata.MajorMinorVersion);
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Metadata.MajorMinorVersion, long> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Metadata.MajorMinorVersion, long>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Metadata.MajorMinorVersion), "<Major>k__BackingField");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Metadata.MajorMinorVersion, long> setField1 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Metadata.MajorMinorVersion, long>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Metadata.MajorMinorVersion), "<Minor>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Metadata.MajorMinorVersion instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 0U, instance.Major);
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 1U, instance.Minor);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Metadata.MajorMinorVersion instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Metadata.MajorMinorVersion @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Metadata.MajorMinorVersion ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Metadata.MajorMinorVersion);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }
}

namespace OrleansCodeGen.Orleans.Statistics
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_EnvironmentStatistics : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Statistics.EnvironmentStatistics>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Statistics.EnvironmentStatistics>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Statistics.EnvironmentStatistics);
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Statistics.EnvironmentStatistics, long> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Statistics.EnvironmentStatistics, long>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Statistics.EnvironmentStatistics), "AvailableMemoryBytes");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Statistics.EnvironmentStatistics, float> setField1 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Statistics.EnvironmentStatistics, float>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Statistics.EnvironmentStatistics), "CpuUsagePercentage");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Statistics.EnvironmentStatistics, long> setField2 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Statistics.EnvironmentStatistics, long>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Statistics.EnvironmentStatistics), "MaximumAvailableMemoryBytes");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Statistics.EnvironmentStatistics, long> setField3 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Statistics.EnvironmentStatistics, long>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Statistics.EnvironmentStatistics), "MemoryUsageBytes");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Statistics.EnvironmentStatistics instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.FloatCodec.WriteField(ref writer, 0U, instance.CpuUsagePercentage);
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 1U, instance.MemoryUsageBytes);
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 1U, instance.AvailableMemoryBytes);
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 1U, instance.MaximumAvailableMemoryBytes);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Statistics.EnvironmentStatistics instance)
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
                    setField1(ref instance, global::Orleans.Serialization.Codecs.FloatCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField3(ref instance, global::Orleans.Serialization.Codecs.Int64Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField0(ref instance, global::Orleans.Serialization.Codecs.Int64Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    setField2(ref instance, global::Orleans.Serialization.Codecs.Int64Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Statistics.EnvironmentStatistics @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Statistics.EnvironmentStatistics ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Statistics.EnvironmentStatistics);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }
}

namespace OrleansCodeGen.Orleans.Versions.Compatibility
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_AllVersionsCompatible : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Compatibility.AllVersionsCompatible>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Versions.Compatibility.AllVersionsCompatible);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Versions.Compatibility.AllVersionsCompatible instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Versions.Compatibility.AllVersionsCompatible instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Versions.Compatibility.AllVersionsCompatible @value)
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
        public global::Orleans.Versions.Compatibility.AllVersionsCompatible ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Versions.Compatibility.AllVersionsCompatible, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Versions.Compatibility.AllVersionsCompatible();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_AllVersionsCompatible : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Versions.Compatibility.AllVersionsCompatible>
    {
        public global::Orleans.Versions.Compatibility.AllVersionsCompatible Create() => new global::Orleans.Versions.Compatibility.AllVersionsCompatible();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_BackwardCompatible : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Compatibility.BackwardCompatible>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Versions.Compatibility.BackwardCompatible);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Versions.Compatibility.BackwardCompatible instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Versions.Compatibility.BackwardCompatible instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Versions.Compatibility.BackwardCompatible @value)
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
        public global::Orleans.Versions.Compatibility.BackwardCompatible ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Versions.Compatibility.BackwardCompatible, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Versions.Compatibility.BackwardCompatible();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_BackwardCompatible : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Versions.Compatibility.BackwardCompatible>
    {
        public global::Orleans.Versions.Compatibility.BackwardCompatible Create() => new global::Orleans.Versions.Compatibility.BackwardCompatible();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_StrictVersionCompatible : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Compatibility.StrictVersionCompatible>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Versions.Compatibility.StrictVersionCompatible);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Versions.Compatibility.StrictVersionCompatible instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Versions.Compatibility.StrictVersionCompatible instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Versions.Compatibility.StrictVersionCompatible @value)
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
        public global::Orleans.Versions.Compatibility.StrictVersionCompatible ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Versions.Compatibility.StrictVersionCompatible, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Versions.Compatibility.StrictVersionCompatible();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_StrictVersionCompatible : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Versions.Compatibility.StrictVersionCompatible>
    {
        public global::Orleans.Versions.Compatibility.StrictVersionCompatible Create() => new global::Orleans.Versions.Compatibility.StrictVersionCompatible();
    }
}

namespace OrleansCodeGen.Orleans.Versions.Selector
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_AllCompatibleVersions : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Selector.AllCompatibleVersions>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Versions.Selector.AllCompatibleVersions);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Versions.Selector.AllCompatibleVersions instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Versions.Selector.AllCompatibleVersions instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Versions.Selector.AllCompatibleVersions @value)
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
        public global::Orleans.Versions.Selector.AllCompatibleVersions ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Versions.Selector.AllCompatibleVersions, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Versions.Selector.AllCompatibleVersions();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_AllCompatibleVersions : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Versions.Selector.AllCompatibleVersions>
    {
        public global::Orleans.Versions.Selector.AllCompatibleVersions Create() => new global::Orleans.Versions.Selector.AllCompatibleVersions();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_LatestVersion : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Selector.LatestVersion>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Versions.Selector.LatestVersion);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Versions.Selector.LatestVersion instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Versions.Selector.LatestVersion instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Versions.Selector.LatestVersion @value)
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
        public global::Orleans.Versions.Selector.LatestVersion ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Versions.Selector.LatestVersion, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Versions.Selector.LatestVersion();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_LatestVersion : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Versions.Selector.LatestVersion>
    {
        public global::Orleans.Versions.Selector.LatestVersion Create() => new global::Orleans.Versions.Selector.LatestVersion();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_MinimumVersion : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Versions.Selector.MinimumVersion>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Versions.Selector.MinimumVersion);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Versions.Selector.MinimumVersion instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Versions.Selector.MinimumVersion instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Versions.Selector.MinimumVersion @value)
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
        public global::Orleans.Versions.Selector.MinimumVersion ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Versions.Selector.MinimumVersion, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Versions.Selector.MinimumVersion();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_MinimumVersion : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Versions.Selector.MinimumVersion>
    {
        public global::Orleans.Versions.Selector.MinimumVersion Create() => new global::Orleans.Versions.Selector.MinimumVersion();
    }
}

namespace OrleansCodeGen.OrleansCoreAbstractions
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Metadata_OrleansCoreAbstractions : global::Orleans.Serialization.Configuration.TypeManifestProviderBase
    {
        protected override void ConfigureInner(global::Orleans.Serialization.Configuration.TypeManifestOptions config)
        {
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_ClientNotAvailableException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_GatewayTooBusyException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_GrainExtensionNotInstalledException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_LimitExceededException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_OrleansConfigurationException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_OrleansException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_OrleansLifecycleCanceledException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_OrleansMessageRejectionException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_SiloUnavailableException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_WrappedException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_ActivationId));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_GrainAddress));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_GrainAddressCacheUpdate));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_GrainId));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_GrainInterfaceType));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_GrainType));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_GuidId));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_IdSpan));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_LegacyGrainId));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_UniqueKey));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_ActivationCountBasedPlacement));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_HashBasedPlacement));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_PreferLocalPlacement));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_RandomPlacement));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_StatelessWorkerPlacement));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_SystemTargetPlacementStrategy));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_EnumerationResult));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_AsyncEnumerableRequest<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_EnumerationAbortedException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_GrainReferenceSurrogate));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_GrainReferenceNotBoundException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Codec_MembershipVersion));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.CodeGeneration.Codec_InvokeMethodOptions));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Concurrency.Codec_Immutable<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_DeactivationReasonCode));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Core.Internal.Codec_Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Core.Internal.Codec_Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Metadata.Codec_ClusterManifest));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Metadata.Codec_GrainInterfaceProperties));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Metadata.Codec_GrainManifest));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Metadata.Codec_GrainProperties));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Metadata.Codec_MajorMinorVersion));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Statistics.Codec_EnvironmentStatistics));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Versions.Compatibility.Codec_AllVersionsCompatible));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Versions.Compatibility.Codec_BackwardCompatible));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Versions.Compatibility.Codec_StrictVersionCompatible));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Versions.Selector.Codec_AllCompatibleVersions));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Versions.Selector.Codec_LatestVersion));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Versions.Selector.Codec_MinimumVersion));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_ClientNotAvailableException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_GatewayTooBusyException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_GrainExtensionNotInstalledException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_LimitExceededException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_OrleansConfigurationException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_OrleansException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_OrleansLifecycleCanceledException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_OrleansMessageRejectionException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_SiloUnavailableException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_WrappedException));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.ActivationId>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.GrainAddress>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.GrainAddressCacheUpdate>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.GrainId>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.GrainInterfaceType>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.GrainType>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.GuidId>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.IdSpan>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.LegacyGrainId>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.UniqueKey>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.ActivationCountBasedPlacement>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.HashBasedPlacement>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.PreferLocalPlacement>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.RandomPlacement>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_StatelessWorkerPlacement));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.SystemTargetPlacementStrategy>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_AsyncEnumerableRequest<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_EnumerationAbortedException));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.GrainReferenceSurrogate>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Runtime.Copier_GrainReferenceNotBoundException));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Runtime.MembershipVersion>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Concurrency.Copier_Immutable<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Core.Internal.Copier_Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Core.Internal.Copier_Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Metadata.ClusterManifest>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Metadata.GrainInterfaceProperties>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Metadata.GrainManifest>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Metadata.GrainProperties>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Metadata.MajorMinorVersion>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Statistics.EnvironmentStatistics>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Versions.Compatibility.AllVersionsCompatible>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Versions.Compatibility.BackwardCompatible>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Versions.Compatibility.StrictVersionCompatible>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Versions.Selector.AllCompatibleVersions>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Versions.Selector.LatestVersion>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Versions.Selector.MinimumVersion>));
            config.Copiers.Add(typeof(global::Orleans.Runtime.GrainReferenceCopier));
            config.Serializers.Add(typeof(global::Orleans.Runtime.IdSpanCodec));
            config.Serializers.Add(typeof(global::Orleans.Runtime.Serialization.SiloAddressCodec));
            config.Serializers.Add(typeof(global::Orleans.Runtime.GrainReferenceCodec));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.Proxy_ICancellationSourcesExtension));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.Proxy_IAsyncEnumerableGrainExtension));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.Proxy_IAddressable));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Runtime.Proxy_IGrainExtension));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Proxy_IGrain));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Proxy_IGrainWithGuidKey));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Proxy_IGrainWithIntegerKey));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Proxy_IGrainWithStringKey));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Proxy_IGrainWithGuidCompoundKey));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Proxy_IGrainWithIntegerCompoundKey));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Proxy_IGrainObserver));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Core.Internal.Proxy_IGrainManagementExtension));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Services.Proxy_IGrainService));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Proxy_ISystemTarget));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.ICancellationSourcesExtension));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.IAsyncEnumerableGrainExtension));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.IAddressable));
            config.Interfaces.Add(typeof(global::Orleans.Runtime.IGrainExtension));
            config.Interfaces.Add(typeof(global::Orleans.IGrain));
            config.Interfaces.Add(typeof(global::Orleans.IGrainWithGuidKey));
            config.Interfaces.Add(typeof(global::Orleans.IGrainWithIntegerKey));
            config.Interfaces.Add(typeof(global::Orleans.IGrainWithStringKey));
            config.Interfaces.Add(typeof(global::Orleans.IGrainWithGuidCompoundKey));
            config.Interfaces.Add(typeof(global::Orleans.IGrainWithIntegerCompoundKey));
            config.Interfaces.Add(typeof(global::Orleans.IGrainObserver));
            config.Interfaces.Add(typeof(global::Orleans.Core.Internal.IGrainManagementExtension));
            config.Interfaces.Add(typeof(global::Orleans.Services.IGrainService));
            config.Interfaces.Add(typeof(global::Orleans.ISystemTarget));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Runtime.GrainReference));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Grain<>));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_GatewayTooBusyException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_GrainExtensionNotInstalledException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_LimitExceededException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_OrleansException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_SiloUnavailableException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_GrainAddress));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_UniqueKey));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_ActivationCountBasedPlacement));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_HashBasedPlacement));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_PreferLocalPlacement));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_RandomPlacement));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_StatelessWorkerPlacement));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_SystemTargetPlacementStrategy));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Runtime.Activator_EnumerationAbortedException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Versions.Compatibility.Activator_AllVersionsCompatible));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Versions.Compatibility.Activator_BackwardCompatible));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Versions.Compatibility.Activator_StrictVersionCompatible));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Versions.Selector.Activator_AllCompatibleVersions));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Versions.Selector.Activator_LatestVersion));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Versions.Selector.Activator_MinimumVersion));
            config.WellKnownTypeAliases.Add("GrainRef", typeof(global::Orleans.Runtime.GrainReference));
            config.WellKnownTypeAliases.Add("Orleans.Statistics.EnvironmentStatistics", typeof(global::Orleans.Statistics.EnvironmentStatistics));
            var n1 = config.CompoundTypeAliases.Add("inv");
            var n2 = n1.Add(typeof(global::Orleans.Runtime.GrainReference));
            var n3 = n2.Add("Ext");
            var n4 = n3.Add(typeof(global::Orleans.Runtime.ICancellationSourcesExtension));
            var n5 = n4.Add(typeof(global::Orleans.Runtime.ICancellationSourcesExtension));
            n5.Add("50F75C16", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_ICancellationSourcesExtension_GrainReference_Ext_50F75C16));
            var n7 = n3.Add(typeof(global::Orleans.Runtime.IAsyncEnumerableGrainExtension));
            var n8 = n7.Add(typeof(global::Orleans.Runtime.IAsyncEnumerableGrainExtension));
            n8.Add("370CD5AB", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_370CD5AB_1<>));
            n8.Add("A7FA7E30", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_A7FA7E30_1<>));
            n8.Add("3C6D7209", typeof(OrleansCodeGen.Orleans.Runtime.Invokable_IAsyncEnumerableGrainExtension_GrainReference_Ext_3C6D7209));
            var n12 = n3.Add(typeof(global::Orleans.Core.Internal.IGrainManagementExtension));
            var n13 = n12.Add(typeof(global::Orleans.Core.Internal.IGrainManagementExtension));
            n13.Add("1B9614D1", typeof(OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_1B9614D1));
            n13.Add("4CC93B45", typeof(OrleansCodeGen.Orleans.Core.Internal.Invokable_IGrainManagementExtension_GrainReference_Ext_4CC93B45));
        }
    }
}