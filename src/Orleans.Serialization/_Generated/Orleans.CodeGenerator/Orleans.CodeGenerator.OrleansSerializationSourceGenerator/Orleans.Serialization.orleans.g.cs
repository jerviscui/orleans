#pragma warning disable CS1591
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Serialization")]
[assembly: global::Orleans.Serialization.Configuration.TypeManifestProviderAttribute(typeof(OrleansCodeGen.OrleansSerialization.Metadata_OrleansSerialization))]
namespace OrleansCodeGen.Orleans.Serialization.Codecs
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ArrayListSurrogate : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.ArrayListSurrogate>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.ArrayListSurrogate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.ArrayListSurrogate);
        private readonly global::System.Type _type0 = typeof(object[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<object> _codec0;
        public Codec_ArrayListSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<object>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.ArrayListSurrogate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Values);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.ArrayListSurrogate instance)
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
                    instance.Values = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.ArrayListSurrogate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ArrayListSurrogate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.ArrayListSurrogate);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ArrayListSurrogate : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.ArrayListSurrogate>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<object> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ArrayListSurrogate DeepCopy(global::Orleans.Serialization.Codecs.ArrayListSurrogate result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier0.DeepCopy(result.Values, context);
            return result;
        }

        public Copier_ArrayListSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<object>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ConcurrentDictionarySurrogate<TKey, TValue> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.ConcurrentDictionarySurrogate<TKey, TValue>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.ConcurrentDictionarySurrogate<TKey, TValue>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.ConcurrentDictionarySurrogate<TKey, TValue>);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.Dictionary<TKey, TValue>);
        private readonly global::Orleans.Serialization.Codecs.DictionaryCodec<TKey, TValue> _codec0;
        public Codec_ConcurrentDictionarySurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCodec<TKey, TValue>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.ConcurrentDictionarySurrogate<TKey, TValue> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Values);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.ConcurrentDictionarySurrogate<TKey, TValue> instance)
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
                    instance.Values = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.ConcurrentDictionarySurrogate<TKey, TValue> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ConcurrentDictionarySurrogate<TKey, TValue> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.ConcurrentDictionarySurrogate<TKey, TValue>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ConcurrentDictionarySurrogate<TKey, TValue> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.ConcurrentDictionarySurrogate<TKey, TValue>>
    {
        private readonly global::Orleans.Serialization.Codecs.DictionaryCopier<TKey, TValue> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ConcurrentDictionarySurrogate<TKey, TValue> DeepCopy(global::Orleans.Serialization.Codecs.ConcurrentDictionarySurrogate<TKey, TValue> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier0.DeepCopy(result.Values, context);
            return result;
        }

        public Copier_ConcurrentDictionarySurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCopier<TKey, TValue>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ConcurrentQueueSurrogate<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.ConcurrentQueueSurrogate<T>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.ConcurrentQueueSurrogate<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.ConcurrentQueueSurrogate<T>);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.Queue<T>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.Queue<T>> _codec0;
        public Codec_ConcurrentQueueSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.Queue<T>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.ConcurrentQueueSurrogate<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Values);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.ConcurrentQueueSurrogate<T> instance)
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
                    instance.Values = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.ConcurrentQueueSurrogate<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ConcurrentQueueSurrogate<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.ConcurrentQueueSurrogate<T>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ConcurrentQueueSurrogate<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.ConcurrentQueueSurrogate<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.Queue<T>> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ConcurrentQueueSurrogate<T> DeepCopy(global::Orleans.Serialization.Codecs.ConcurrentQueueSurrogate<T> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier0.DeepCopy(result.Values, context);
            return result;
        }

        public Copier_ConcurrentQueueSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.Queue<T>>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_CultureInfoSurrogate : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.CultureInfoSurrogate>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.CultureInfoSurrogate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.CultureInfoSurrogate);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.CultureInfoSurrogate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.Name);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.CultureInfoSurrogate instance)
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
                    instance.Name = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.CultureInfoSurrogate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.CultureInfoSurrogate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.CultureInfoSurrogate);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ImmutableArraySurrogate<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.ImmutableArraySurrogate<T>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.ImmutableArraySurrogate<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.ImmutableArraySurrogate<T>);
        private readonly global::System.Type _type0 = typeof(T[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<T> _codec0;
        public Codec_ImmutableArraySurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.ImmutableArraySurrogate<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Values);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.ImmutableArraySurrogate<T> instance)
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
                    instance.Values = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.ImmutableArraySurrogate<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableArraySurrogate<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.ImmutableArraySurrogate<T>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ImmutableArraySurrogate<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.ImmutableArraySurrogate<T>>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<T> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableArraySurrogate<T> DeepCopy(global::Orleans.Serialization.Codecs.ImmutableArraySurrogate<T> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier0.DeepCopy(result.Values, context);
            return result;
        }

        public Copier_ImmutableArraySurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<T>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ImmutableDictionarySurrogate<TKey, TValue> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.ImmutableDictionarySurrogate<TKey, TValue>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.ImmutableDictionarySurrogate<TKey, TValue>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.ImmutableDictionarySurrogate<TKey, TValue>);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.Dictionary<TKey, TValue>);
        private readonly global::Orleans.Serialization.Codecs.DictionaryCodec<TKey, TValue> _codec0;
        public Codec_ImmutableDictionarySurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCodec<TKey, TValue>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.ImmutableDictionarySurrogate<TKey, TValue> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Values);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.ImmutableDictionarySurrogate<TKey, TValue> instance)
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
                    instance.Values = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.ImmutableDictionarySurrogate<TKey, TValue> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableDictionarySurrogate<TKey, TValue> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.ImmutableDictionarySurrogate<TKey, TValue>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ImmutableDictionarySurrogate<TKey, TValue> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.ImmutableDictionarySurrogate<TKey, TValue>>
    {
        private readonly global::Orleans.Serialization.Codecs.DictionaryCopier<TKey, TValue> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableDictionarySurrogate<TKey, TValue> DeepCopy(global::Orleans.Serialization.Codecs.ImmutableDictionarySurrogate<TKey, TValue> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier0.DeepCopy(result.Values, context);
            return result;
        }

        public Copier_ImmutableDictionarySurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCopier<TKey, TValue>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ImmutableHashSetSurrogate<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.ImmutableHashSetSurrogate<T>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.ImmutableHashSetSurrogate<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.ImmutableHashSetSurrogate<T>);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.IEqualityComparer<T>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IEqualityComparer<T>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Generic.List<T>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<T> _codec1;
        public Codec_ImmutableHashSetSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IEqualityComparer<T>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.ImmutableHashSetSurrogate<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, instance.Values);
            _codec0.WriteField(ref writer, 1U, _type0, instance.KeyComparer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.ImmutableHashSetSurrogate<T> instance)
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
                    instance.Values = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.KeyComparer = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.ImmutableHashSetSurrogate<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableHashSetSurrogate<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.ImmutableHashSetSurrogate<T>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ImmutableHashSetSurrogate<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.ImmutableHashSetSurrogate<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IEqualityComparer<T>> _copier0;
        private readonly global::Orleans.Serialization.Codecs.ListCopier<T> _copier1;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableHashSetSurrogate<T> DeepCopy(global::Orleans.Serialization.Codecs.ImmutableHashSetSurrogate<T> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier1.DeepCopy(result.Values, context);
            result.KeyComparer = _copier0.DeepCopy(result.KeyComparer, context);
            return result;
        }

        public Copier_ImmutableHashSetSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IEqualityComparer<T>>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<T>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ImmutableListSurrogate<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.ImmutableListSurrogate<T>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.ImmutableListSurrogate<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.ImmutableListSurrogate<T>);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.List<T>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<T> _codec0;
        public Codec_ImmutableListSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.ImmutableListSurrogate<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Values);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.ImmutableListSurrogate<T> instance)
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
                    instance.Values = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.ImmutableListSurrogate<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableListSurrogate<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.ImmutableListSurrogate<T>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ImmutableListSurrogate<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.ImmutableListSurrogate<T>>
    {
        private readonly global::Orleans.Serialization.Codecs.ListCopier<T> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableListSurrogate<T> DeepCopy(global::Orleans.Serialization.Codecs.ImmutableListSurrogate<T> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier0.DeepCopy(result.Values, context);
            return result;
        }

        public Copier_ImmutableListSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<T>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ImmutableQueueSurrogate<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.ImmutableQueueSurrogate<T>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.ImmutableQueueSurrogate<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.ImmutableQueueSurrogate<T>);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.List<T>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<T> _codec0;
        public Codec_ImmutableQueueSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.ImmutableQueueSurrogate<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Values);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.ImmutableQueueSurrogate<T> instance)
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
                    instance.Values = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.ImmutableQueueSurrogate<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableQueueSurrogate<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.ImmutableQueueSurrogate<T>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ImmutableQueueSurrogate<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.ImmutableQueueSurrogate<T>>
    {
        private readonly global::Orleans.Serialization.Codecs.ListCopier<T> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableQueueSurrogate<T> DeepCopy(global::Orleans.Serialization.Codecs.ImmutableQueueSurrogate<T> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier0.DeepCopy(result.Values, context);
            return result;
        }

        public Copier_ImmutableQueueSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<T>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ImmutableSortedDictionarySurrogate<TKey, TValue> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.ImmutableSortedDictionarySurrogate<TKey, TValue>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.ImmutableSortedDictionarySurrogate<TKey, TValue>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.ImmutableSortedDictionarySurrogate<TKey, TValue>);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.IComparer<TKey>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IComparer<TKey>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Generic.IEqualityComparer<TValue>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IEqualityComparer<TValue>> _codec1;
        private readonly global::System.Type _type2 = typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> _codec2;
        public Codec_ImmutableSortedDictionarySurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IComparer<TKey>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IEqualityComparer<TValue>>>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.ImmutableSortedDictionarySurrogate<TKey, TValue> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec2.WriteField(ref writer, 0U, _type2, instance.Values);
            _codec0.WriteField(ref writer, 1U, _type0, instance.KeyComparer);
            _codec1.WriteField(ref writer, 1U, _type1, instance.ValueComparer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.ImmutableSortedDictionarySurrogate<TKey, TValue> instance)
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
                    instance.Values = _codec2.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.KeyComparer = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.ValueComparer = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.ImmutableSortedDictionarySurrogate<TKey, TValue> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableSortedDictionarySurrogate<TKey, TValue> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.ImmutableSortedDictionarySurrogate<TKey, TValue>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ImmutableSortedDictionarySurrogate<TKey, TValue> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.ImmutableSortedDictionarySurrogate<TKey, TValue>>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IComparer<TKey>> _copier0;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IEqualityComparer<TValue>> _copier1;
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> _copier2;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableSortedDictionarySurrogate<TKey, TValue> DeepCopy(global::Orleans.Serialization.Codecs.ImmutableSortedDictionarySurrogate<TKey, TValue> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier2.DeepCopy(result.Values, context);
            result.KeyComparer = _copier0.DeepCopy(result.KeyComparer, context);
            result.ValueComparer = _copier1.DeepCopy(result.ValueComparer, context);
            return result;
        }

        public Copier_ImmutableSortedDictionarySurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IComparer<TKey>>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IEqualityComparer<TValue>>>(this, codecProvider);
            _copier2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ImmutableSortedSetSurrogate<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.ImmutableSortedSetSurrogate<T>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.ImmutableSortedSetSurrogate<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.ImmutableSortedSetSurrogate<T>);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.IComparer<T>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IComparer<T>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Generic.List<T>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<T> _codec1;
        public Codec_ImmutableSortedSetSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IComparer<T>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.ImmutableSortedSetSurrogate<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, instance.Values);
            _codec0.WriteField(ref writer, 1U, _type0, instance.KeyComparer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.ImmutableSortedSetSurrogate<T> instance)
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
                    instance.Values = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.KeyComparer = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.ImmutableSortedSetSurrogate<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableSortedSetSurrogate<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.ImmutableSortedSetSurrogate<T>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ImmutableSortedSetSurrogate<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.ImmutableSortedSetSurrogate<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IComparer<T>> _copier0;
        private readonly global::Orleans.Serialization.Codecs.ListCopier<T> _copier1;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableSortedSetSurrogate<T> DeepCopy(global::Orleans.Serialization.Codecs.ImmutableSortedSetSurrogate<T> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier1.DeepCopy(result.Values, context);
            result.KeyComparer = _copier0.DeepCopy(result.KeyComparer, context);
            return result;
        }

        public Copier_ImmutableSortedSetSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IComparer<T>>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<T>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ImmutableStackSurrogate<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.ImmutableStackSurrogate<T>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.ImmutableStackSurrogate<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.ImmutableStackSurrogate<T>);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.List<T>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<T> _codec0;
        public Codec_ImmutableStackSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.ImmutableStackSurrogate<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Values);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.ImmutableStackSurrogate<T> instance)
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
                    instance.Values = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.ImmutableStackSurrogate<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableStackSurrogate<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.ImmutableStackSurrogate<T>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ImmutableStackSurrogate<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.ImmutableStackSurrogate<T>>
    {
        private readonly global::Orleans.Serialization.Codecs.ListCopier<T> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ImmutableStackSurrogate<T> DeepCopy(global::Orleans.Serialization.Codecs.ImmutableStackSurrogate<T> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier0.DeepCopy(result.Values, context);
            return result;
        }

        public Copier_ImmutableStackSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<T>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_NameValueCollectionSurrogate : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.NameValueCollectionSurrogate>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.NameValueCollectionSurrogate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.NameValueCollectionSurrogate);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.Dictionary<string, string>);
        private readonly global::Orleans.Serialization.Codecs.DictionaryCodec<string, string> _codec0;
        public Codec_NameValueCollectionSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCodec<string, string>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.NameValueCollectionSurrogate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Values);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.NameValueCollectionSurrogate instance)
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
                    instance.Values = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.NameValueCollectionSurrogate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.NameValueCollectionSurrogate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.NameValueCollectionSurrogate);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_NameValueCollectionSurrogate : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.NameValueCollectionSurrogate>
    {
        private readonly global::Orleans.Serialization.Codecs.DictionaryCopier<string, string> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.NameValueCollectionSurrogate DeepCopy(global::Orleans.Serialization.Codecs.NameValueCollectionSurrogate result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier0.DeepCopy(result.Values, context);
            return result;
        }

        public Copier_NameValueCollectionSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCopier<string, string>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ReadOnlyCollectionSurrogate<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.ReadOnlyCollectionSurrogate<T>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.ReadOnlyCollectionSurrogate<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.ReadOnlyCollectionSurrogate<T>);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.List<T>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<T> _codec0;
        public Codec_ReadOnlyCollectionSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.ReadOnlyCollectionSurrogate<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Values);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.ReadOnlyCollectionSurrogate<T> instance)
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
                    instance.Values = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.ReadOnlyCollectionSurrogate<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ReadOnlyCollectionSurrogate<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.ReadOnlyCollectionSurrogate<T>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ReadOnlyCollectionSurrogate<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.ReadOnlyCollectionSurrogate<T>>
    {
        private readonly global::Orleans.Serialization.Codecs.ListCopier<T> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ReadOnlyCollectionSurrogate<T> DeepCopy(global::Orleans.Serialization.Codecs.ReadOnlyCollectionSurrogate<T> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier0.DeepCopy(result.Values, context);
            return result;
        }

        public Copier_ReadOnlyCollectionSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<T>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ReadOnlyDictionarySurrogate<TKey, TValue> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.ReadOnlyDictionarySurrogate<TKey, TValue>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.ReadOnlyDictionarySurrogate<TKey, TValue>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.ReadOnlyDictionarySurrogate<TKey, TValue>);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.Dictionary<TKey, TValue>);
        private readonly global::Orleans.Serialization.Codecs.DictionaryCodec<TKey, TValue> _codec0;
        public Codec_ReadOnlyDictionarySurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCodec<TKey, TValue>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.ReadOnlyDictionarySurrogate<TKey, TValue> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Values);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.ReadOnlyDictionarySurrogate<TKey, TValue> instance)
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
                    instance.Values = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.ReadOnlyDictionarySurrogate<TKey, TValue> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ReadOnlyDictionarySurrogate<TKey, TValue> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.ReadOnlyDictionarySurrogate<TKey, TValue>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ReadOnlyDictionarySurrogate<TKey, TValue> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.ReadOnlyDictionarySurrogate<TKey, TValue>>
    {
        private readonly global::Orleans.Serialization.Codecs.DictionaryCopier<TKey, TValue> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.ReadOnlyDictionarySurrogate<TKey, TValue> DeepCopy(global::Orleans.Serialization.Codecs.ReadOnlyDictionarySurrogate<TKey, TValue> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier0.DeepCopy(result.Values, context);
            return result;
        }

        public Copier_ReadOnlyDictionarySurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCopier<TKey, TValue>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_SortedDictionarySurrogate<TKey, TValue> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.SortedDictionarySurrogate<TKey, TValue>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.SortedDictionarySurrogate<TKey, TValue>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.SortedDictionarySurrogate<TKey, TValue>);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.IComparer<TKey>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IComparer<TKey>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> _codec1;
        public Codec_SortedDictionarySurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IComparer<TKey>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.SortedDictionarySurrogate<TKey, TValue> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, instance.Values);
            _codec0.WriteField(ref writer, 1U, _type0, instance.Comparer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.SortedDictionarySurrogate<TKey, TValue> instance)
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
                    instance.Values = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.Comparer = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.SortedDictionarySurrogate<TKey, TValue> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.SortedDictionarySurrogate<TKey, TValue> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.SortedDictionarySurrogate<TKey, TValue>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_SortedDictionarySurrogate<TKey, TValue> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.SortedDictionarySurrogate<TKey, TValue>>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IComparer<TKey>> _copier0;
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> _copier1;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.SortedDictionarySurrogate<TKey, TValue> DeepCopy(global::Orleans.Serialization.Codecs.SortedDictionarySurrogate<TKey, TValue> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier1.DeepCopy(result.Values, context);
            result.Comparer = _copier0.DeepCopy(result.Comparer, context);
            return result;
        }

        public Copier_SortedDictionarySurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IComparer<TKey>>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_SortedListSurrogate<TKey, TValue> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.SortedListSurrogate<TKey, TValue>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.SortedListSurrogate<TKey, TValue>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.SortedListSurrogate<TKey, TValue>);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.IComparer<TKey>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IComparer<TKey>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> _codec1;
        public Codec_SortedListSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IComparer<TKey>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.SortedListSurrogate<TKey, TValue> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, instance.Values);
            _codec0.WriteField(ref writer, 1U, _type0, instance.Comparer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.SortedListSurrogate<TKey, TValue> instance)
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
                    instance.Values = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.Comparer = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.SortedListSurrogate<TKey, TValue> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.SortedListSurrogate<TKey, TValue> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.SortedListSurrogate<TKey, TValue>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_SortedListSurrogate<TKey, TValue> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.SortedListSurrogate<TKey, TValue>>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IComparer<TKey>> _copier0;
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> _copier1;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.SortedListSurrogate<TKey, TValue> DeepCopy(global::Orleans.Serialization.Codecs.SortedListSurrogate<TKey, TValue> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier1.DeepCopy(result.Values, context);
            result.Comparer = _copier0.DeepCopy(result.Comparer, context);
            return result;
        }

        public Copier_SortedListSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IComparer<TKey>>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_SortedSetSurrogate<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.SortedSetSurrogate<T>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.SortedSetSurrogate<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.SortedSetSurrogate<T>);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.IComparer<T>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IComparer<T>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Generic.List<T>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<T> _codec1;
        public Codec_SortedSetSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IComparer<T>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.SortedSetSurrogate<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, instance.Values);
            _codec0.WriteField(ref writer, 1U, _type0, instance.Comparer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.SortedSetSurrogate<T> instance)
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
                    instance.Values = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.Comparer = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.SortedSetSurrogate<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.SortedSetSurrogate<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.SortedSetSurrogate<T>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_SortedSetSurrogate<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Codecs.SortedSetSurrogate<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IComparer<T>> _copier0;
        private readonly global::Orleans.Serialization.Codecs.ListCopier<T> _copier1;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.SortedSetSurrogate<T> DeepCopy(global::Orleans.Serialization.Codecs.SortedSetSurrogate<T> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Values = _copier1.DeepCopy(result.Values, context);
            result.Comparer = _copier0.DeepCopy(result.Comparer, context);
            return result;
        }

        public Copier_SortedSetSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Generic.IComparer<T>>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<T>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_VersionSurrogate : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Codecs.VersionSurrogate>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.Codecs.VersionSurrogate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Codecs.VersionSurrogate);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.Codecs.VersionSurrogate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.Major);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.Minor);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.Build);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.Revision);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.Codecs.VersionSurrogate instance)
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
                    instance.Major = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.Minor = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.Build = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.Revision = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Codecs.VersionSurrogate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Codecs.VersionSurrogate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.Codecs.VersionSurrogate);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }
}
#pragma warning restore CS1591

namespace OrleansCodeGen.Orleans.Serialization
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_SerializerException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.SerializerException>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.SerializerException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.SerializerException);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Exception> _baseTypeSerializer;
        public Codec_SerializerException(global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Exception> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.SerializerException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.SerializerException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.SerializerException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.SerializerException))
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
        public global::Orleans.Serialization.SerializerException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.SerializerException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.SerializerException();
                ReferenceCodec.MarkValueField(reader.Session);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.SerializerException>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_SerializerException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.SerializerException, global::System.Exception>
    {
        public Copier_SerializerException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_SerializerException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.SerializerException>
    {
        public global::Orleans.Serialization.SerializerException Create() => new global::Orleans.Serialization.SerializerException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_FieldIdNotPresentException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.FieldIdNotPresentException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.FieldIdNotPresentException);
        private readonly OrleansCodeGen.Orleans.Serialization.Codec_SerializerException _baseTypeSerializer;
        public Codec_FieldIdNotPresentException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Codec_SerializerException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.FieldIdNotPresentException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.FieldIdNotPresentException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.FieldIdNotPresentException @value)
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
        public global::Orleans.Serialization.FieldIdNotPresentException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.FieldIdNotPresentException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Serialization.FieldIdNotPresentException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_FieldIdNotPresentException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.FieldIdNotPresentException, global::Orleans.Serialization.SerializerException>
    {
        public Copier_FieldIdNotPresentException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_FieldIdNotPresentException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.FieldIdNotPresentException>
    {
        public global::Orleans.Serialization.FieldIdNotPresentException Create() => new global::Orleans.Serialization.FieldIdNotPresentException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_SchemaTypeInvalidException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.SchemaTypeInvalidException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.SchemaTypeInvalidException);
        private readonly OrleansCodeGen.Orleans.Serialization.Codec_SerializerException _baseTypeSerializer;
        public Codec_SchemaTypeInvalidException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Codec_SerializerException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.SchemaTypeInvalidException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.SchemaTypeInvalidException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.SchemaTypeInvalidException @value)
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
        public global::Orleans.Serialization.SchemaTypeInvalidException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.SchemaTypeInvalidException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Serialization.SchemaTypeInvalidException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_SchemaTypeInvalidException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.SchemaTypeInvalidException, global::Orleans.Serialization.SerializerException>
    {
        public Copier_SchemaTypeInvalidException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_SchemaTypeInvalidException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.SchemaTypeInvalidException>
    {
        public global::Orleans.Serialization.SchemaTypeInvalidException Create() => new global::Orleans.Serialization.SchemaTypeInvalidException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_FieldTypeInvalidException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.FieldTypeInvalidException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.FieldTypeInvalidException);
        private readonly OrleansCodeGen.Orleans.Serialization.Codec_SerializerException _baseTypeSerializer;
        public Codec_FieldTypeInvalidException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Codec_SerializerException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.FieldTypeInvalidException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.FieldTypeInvalidException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.FieldTypeInvalidException @value)
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
        public global::Orleans.Serialization.FieldTypeInvalidException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.FieldTypeInvalidException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Serialization.FieldTypeInvalidException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_FieldTypeInvalidException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.FieldTypeInvalidException, global::Orleans.Serialization.SerializerException>
    {
        public Copier_FieldTypeInvalidException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_FieldTypeInvalidException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.FieldTypeInvalidException>
    {
        public global::Orleans.Serialization.FieldTypeInvalidException Create() => new global::Orleans.Serialization.FieldTypeInvalidException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_FieldTypeMissingException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.FieldTypeMissingException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.FieldTypeMissingException);
        private readonly OrleansCodeGen.Orleans.Serialization.Codec_SerializerException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.FieldTypeMissingException> _activator;
        public Codec_FieldTypeMissingException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.FieldTypeMissingException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Codec_SerializerException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.FieldTypeMissingException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.FieldTypeMissingException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.FieldTypeMissingException @value)
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
        public global::Orleans.Serialization.FieldTypeMissingException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.FieldTypeMissingException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_FieldTypeMissingException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.FieldTypeMissingException, global::Orleans.Serialization.SerializerException>
    {
        public Copier_FieldTypeMissingException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ExtendedWireTypeInvalidException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.ExtendedWireTypeInvalidException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.ExtendedWireTypeInvalidException);
        private readonly OrleansCodeGen.Orleans.Serialization.Codec_SerializerException _baseTypeSerializer;
        public Codec_ExtendedWireTypeInvalidException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Codec_SerializerException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.ExtendedWireTypeInvalidException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.ExtendedWireTypeInvalidException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.ExtendedWireTypeInvalidException @value)
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
        public global::Orleans.Serialization.ExtendedWireTypeInvalidException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.ExtendedWireTypeInvalidException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Serialization.ExtendedWireTypeInvalidException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ExtendedWireTypeInvalidException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.ExtendedWireTypeInvalidException, global::Orleans.Serialization.SerializerException>
    {
        public Copier_ExtendedWireTypeInvalidException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_ExtendedWireTypeInvalidException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.ExtendedWireTypeInvalidException>
    {
        public global::Orleans.Serialization.ExtendedWireTypeInvalidException Create() => new global::Orleans.Serialization.ExtendedWireTypeInvalidException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_UnsupportedWireTypeException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnsupportedWireTypeException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnsupportedWireTypeException);
        private readonly OrleansCodeGen.Orleans.Serialization.Codec_SerializerException _baseTypeSerializer;
        public Codec_UnsupportedWireTypeException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Codec_SerializerException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnsupportedWireTypeException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnsupportedWireTypeException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnsupportedWireTypeException @value)
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
        public global::Orleans.Serialization.UnsupportedWireTypeException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnsupportedWireTypeException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Serialization.UnsupportedWireTypeException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_UnsupportedWireTypeException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.UnsupportedWireTypeException, global::Orleans.Serialization.SerializerException>
    {
        public Copier_UnsupportedWireTypeException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_UnsupportedWireTypeException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnsupportedWireTypeException>
    {
        public global::Orleans.Serialization.UnsupportedWireTypeException Create() => new global::Orleans.Serialization.UnsupportedWireTypeException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ReferenceNotFoundException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.ReferenceNotFoundException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.ReferenceNotFoundException);
        private readonly OrleansCodeGen.Orleans.Serialization.Codec_SerializerException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.ReferenceNotFoundException> _activator;
        private static readonly global::System.Action<global::Orleans.Serialization.ReferenceNotFoundException, uint> setField0 = (global::System.Action<global::Orleans.Serialization.ReferenceNotFoundException, uint>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.ReferenceNotFoundException), "<TargetReference>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Serialization.ReferenceNotFoundException, global::System.Type> setField1 = (global::System.Action<global::Orleans.Serialization.ReferenceNotFoundException, global::System.Type>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.ReferenceNotFoundException), "<TargetReferenceType>k__BackingField");
        public Codec_ReferenceNotFoundException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.ReferenceNotFoundException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Codec_SerializerException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.ReferenceNotFoundException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.UInt32Codec.WriteField(ref writer, 0U, instance.TargetReference);
            global::Orleans.Serialization.Codecs.TypeSerializerCodec.WriteField(ref writer, 1U, instance.TargetReferenceType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.ReferenceNotFoundException instance)
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
                    setField0(instance, global::Orleans.Serialization.Codecs.UInt32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.TypeSerializerCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.ReferenceNotFoundException @value)
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
        public global::Orleans.Serialization.ReferenceNotFoundException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.ReferenceNotFoundException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ReferenceNotFoundException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.ReferenceNotFoundException, global::Orleans.Serialization.SerializerException>
    {
        private static readonly global::System.Action<global::Orleans.Serialization.ReferenceNotFoundException, uint> setField0 = (global::System.Action<global::Orleans.Serialization.ReferenceNotFoundException, uint>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.ReferenceNotFoundException), "<TargetReference>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Serialization.ReferenceNotFoundException, global::System.Type> setField1 = (global::System.Action<global::Orleans.Serialization.ReferenceNotFoundException, global::System.Type>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.ReferenceNotFoundException), "<TargetReferenceType>k__BackingField");
        public Copier_ReferenceNotFoundException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void DeepCopy(global::Orleans.Serialization.ReferenceNotFoundException input, global::Orleans.Serialization.ReferenceNotFoundException output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            base.DeepCopy(input, output, context);
            setField0(output, input.TargetReference);
            setField1(output, input.TargetReferenceType);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_UnknownReferencedTypeException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnknownReferencedTypeException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnknownReferencedTypeException);
        private readonly OrleansCodeGen.Orleans.Serialization.Codec_SerializerException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnknownReferencedTypeException> _activator;
        public Codec_UnknownReferencedTypeException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnknownReferencedTypeException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Codec_SerializerException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnknownReferencedTypeException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.UInt32Codec.WriteField(ref writer, 0U, instance.Reference);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnknownReferencedTypeException instance)
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
                    instance.Reference = global::Orleans.Serialization.Codecs.UInt32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnknownReferencedTypeException @value)
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
        public global::Orleans.Serialization.UnknownReferencedTypeException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnknownReferencedTypeException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_UnknownReferencedTypeException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.UnknownReferencedTypeException, global::Orleans.Serialization.SerializerException>
    {
        public Copier_UnknownReferencedTypeException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void DeepCopy(global::Orleans.Serialization.UnknownReferencedTypeException input, global::Orleans.Serialization.UnknownReferencedTypeException output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            base.DeepCopy(input, output, context);
            output.Reference = input.Reference;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ReferenceFieldNotSupportedException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.ReferenceFieldNotSupportedException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.ReferenceFieldNotSupportedException);
        private readonly OrleansCodeGen.Orleans.Serialization.Codec_SerializerException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.ReferenceFieldNotSupportedException> _activator;
        private static readonly global::System.Action<global::Orleans.Serialization.ReferenceFieldNotSupportedException, global::System.Type> setField0 = (global::System.Action<global::Orleans.Serialization.ReferenceFieldNotSupportedException, global::System.Type>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.ReferenceFieldNotSupportedException), "<TargetReferenceType>k__BackingField");
        public Codec_ReferenceFieldNotSupportedException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.ReferenceFieldNotSupportedException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Codec_SerializerException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.ReferenceFieldNotSupportedException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.TypeSerializerCodec.WriteField(ref writer, 0U, instance.TargetReferenceType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.ReferenceFieldNotSupportedException instance)
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
                    setField0(instance, global::Orleans.Serialization.Codecs.TypeSerializerCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.ReferenceFieldNotSupportedException @value)
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
        public global::Orleans.Serialization.ReferenceFieldNotSupportedException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.ReferenceFieldNotSupportedException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_ReferenceFieldNotSupportedException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.ReferenceFieldNotSupportedException, global::Orleans.Serialization.SerializerException>
    {
        private static readonly global::System.Action<global::Orleans.Serialization.ReferenceFieldNotSupportedException, global::System.Type> setField0 = (global::System.Action<global::Orleans.Serialization.ReferenceFieldNotSupportedException, global::System.Type>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.ReferenceFieldNotSupportedException), "<TargetReferenceType>k__BackingField");
        public Copier_ReferenceFieldNotSupportedException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void DeepCopy(global::Orleans.Serialization.ReferenceFieldNotSupportedException input, global::Orleans.Serialization.ReferenceFieldNotSupportedException output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            base.DeepCopy(input, output, context);
            setField0(output, input.TargetReferenceType);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_UnknownWellKnownTypeException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnknownWellKnownTypeException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnknownWellKnownTypeException);
        private readonly OrleansCodeGen.Orleans.Serialization.Codec_SerializerException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnknownWellKnownTypeException> _activator;
        public Codec_UnknownWellKnownTypeException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnknownWellKnownTypeException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Codec_SerializerException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnknownWellKnownTypeException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.UInt32Codec.WriteField(ref writer, 0U, instance.Id);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnknownWellKnownTypeException instance)
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
                    instance.Id = global::Orleans.Serialization.Codecs.UInt32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnknownWellKnownTypeException @value)
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
        public global::Orleans.Serialization.UnknownWellKnownTypeException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnknownWellKnownTypeException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_UnknownWellKnownTypeException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.UnknownWellKnownTypeException, global::Orleans.Serialization.SerializerException>
    {
        public Copier_UnknownWellKnownTypeException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void DeepCopy(global::Orleans.Serialization.UnknownWellKnownTypeException input, global::Orleans.Serialization.UnknownWellKnownTypeException output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            base.DeepCopy(input, output, context);
            output.Id = input.Id;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_IllegalTypeException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.IllegalTypeException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.IllegalTypeException);
        private readonly OrleansCodeGen.Orleans.Serialization.Codec_SerializerException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.IllegalTypeException> _activator;
        private static readonly global::System.Action<global::Orleans.Serialization.IllegalTypeException, string> setField0 = (global::System.Action<global::Orleans.Serialization.IllegalTypeException, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.IllegalTypeException), "<TypeName>k__BackingField");
        public Codec_IllegalTypeException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.IllegalTypeException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Codec_SerializerException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.IllegalTypeException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.TypeName);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.IllegalTypeException instance)
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
                    setField0(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.IllegalTypeException @value)
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
        public global::Orleans.Serialization.IllegalTypeException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.IllegalTypeException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_IllegalTypeException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.IllegalTypeException, global::Orleans.Serialization.SerializerException>
    {
        private static readonly global::System.Action<global::Orleans.Serialization.IllegalTypeException, string> setField0 = (global::System.Action<global::Orleans.Serialization.IllegalTypeException, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.IllegalTypeException), "<TypeName>k__BackingField");
        public Copier_IllegalTypeException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void DeepCopy(global::Orleans.Serialization.IllegalTypeException input, global::Orleans.Serialization.IllegalTypeException output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            base.DeepCopy(input, output, context);
            setField0(output, input.TypeName);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_TypeMissingException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.TypeMissingException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.TypeMissingException);
        private readonly OrleansCodeGen.Orleans.Serialization.Codec_SerializerException _baseTypeSerializer;
        public Codec_TypeMissingException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Codec_SerializerException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.TypeMissingException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.TypeMissingException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.TypeMissingException @value)
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
        public global::Orleans.Serialization.TypeMissingException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.TypeMissingException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Serialization.TypeMissingException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_TypeMissingException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.TypeMissingException, global::Orleans.Serialization.SerializerException>
    {
        public Copier_TypeMissingException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_TypeMissingException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.TypeMissingException>
    {
        public global::Orleans.Serialization.TypeMissingException Create() => new global::Orleans.Serialization.TypeMissingException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_RequiredFieldMissingException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.RequiredFieldMissingException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.RequiredFieldMissingException);
        private readonly OrleansCodeGen.Orleans.Serialization.Codec_SerializerException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.RequiredFieldMissingException> _activator;
        public Codec_RequiredFieldMissingException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.RequiredFieldMissingException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Codec_SerializerException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.RequiredFieldMissingException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.RequiredFieldMissingException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.RequiredFieldMissingException @value)
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
        public global::Orleans.Serialization.RequiredFieldMissingException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.RequiredFieldMissingException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_RequiredFieldMissingException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.RequiredFieldMissingException, global::Orleans.Serialization.SerializerException>
    {
        public Copier_RequiredFieldMissingException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_CodecNotFoundException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.CodecNotFoundException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.CodecNotFoundException);
        private readonly OrleansCodeGen.Orleans.Serialization.Codec_SerializerException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.CodecNotFoundException> _activator;
        public Codec_CodecNotFoundException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.CodecNotFoundException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Codec_SerializerException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.CodecNotFoundException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.CodecNotFoundException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.CodecNotFoundException @value)
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
        public global::Orleans.Serialization.CodecNotFoundException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.CodecNotFoundException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_CodecNotFoundException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.CodecNotFoundException, global::Orleans.Serialization.SerializerException>
    {
        public Copier_CodecNotFoundException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_UnexpectedLengthPrefixValueException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnexpectedLengthPrefixValueException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnexpectedLengthPrefixValueException);
        private readonly OrleansCodeGen.Orleans.Serialization.Codec_SerializerException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnexpectedLengthPrefixValueException> _activator;
        public Codec_UnexpectedLengthPrefixValueException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnexpectedLengthPrefixValueException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Codec_SerializerException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnexpectedLengthPrefixValueException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnexpectedLengthPrefixValueException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnexpectedLengthPrefixValueException @value)
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
        public global::Orleans.Serialization.UnexpectedLengthPrefixValueException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnexpectedLengthPrefixValueException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_UnexpectedLengthPrefixValueException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.UnexpectedLengthPrefixValueException, global::Orleans.Serialization.SerializerException>
    {
        public Copier_UnexpectedLengthPrefixValueException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_AggregateExceptionSurrogate : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.AggregateExceptionSurrogate>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.AggregateExceptionSurrogate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.AggregateExceptionSurrogate);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.Dictionary<object, object>);
        private readonly global::Orleans.Serialization.Codecs.DictionaryCodec<object, object> _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Exception>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Exception>> _codec1;
        public Codec_AggregateExceptionSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCodec<object, object>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Exception>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.AggregateExceptionSurrogate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.Message);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.StackTrace);
            _codec0.WriteField(ref writer, 1U, _type0, instance.Data);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.HResult);
            _codec1.WriteField(ref writer, 1U, _type1, instance.InnerExceptions);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.AggregateExceptionSurrogate instance)
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
                    instance.Message = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.StackTrace = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.Data = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.HResult = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 4U)
                {
                    instance.InnerExceptions = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.AggregateExceptionSurrogate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.AggregateExceptionSurrogate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.AggregateExceptionSurrogate);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_AggregateExceptionSurrogate : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.AggregateExceptionSurrogate>
    {
        private readonly global::Orleans.Serialization.Codecs.DictionaryCopier<object, object> _copier0;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Exception>> _copier1;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.AggregateExceptionSurrogate DeepCopy(global::Orleans.Serialization.AggregateExceptionSurrogate result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Data = _copier0.DeepCopy(result.Data, context);
            result.InnerExceptions = _copier1.DeepCopy(result.InnerExceptions, context);
            return result;
        }

        public Copier_AggregateExceptionSurrogate(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCopier<object, object>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Exception>>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Codec_SerializationEntrySurrogate : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.SerializationEntrySurrogate>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.SerializationEntrySurrogate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.SerializationEntrySurrogate);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.SerializationEntrySurrogate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.Name);
            global::Orleans.Serialization.Codecs.ObjectCodec.WriteField(ref writer, 1U, instance.Value);
            global::Orleans.Serialization.Codecs.TypeSerializerCodec.WriteField(ref writer, 1U, instance.ObjectType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.SerializationEntrySurrogate instance)
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
                    instance.Name = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.Value = global::Orleans.Serialization.Codecs.ObjectCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.ObjectType = global::Orleans.Serialization.Codecs.TypeSerializerCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.SerializationEntrySurrogate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.SerializationEntrySurrogate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.SerializationEntrySurrogate);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Copier_SerializationEntrySurrogate : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.SerializationEntrySurrogate>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.SerializationEntrySurrogate DeepCopy(global::Orleans.Serialization.SerializationEntrySurrogate result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.Value = global::Orleans.Serialization.Codecs.ObjectCopier.DeepCopy(result.Value, context);
            return result;
        }
    }
}

namespace OrleansCodeGen.Orleans.Serialization.Invocation
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_CompletedResponse : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Invocation.CompletedResponse>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Invocation.CompletedResponse);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.Invocation.CompletedResponse> _activator;
        public Codec_CompletedResponse(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.Invocation.CompletedResponse> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.Invocation.CompletedResponse instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.Invocation.CompletedResponse instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Invocation.CompletedResponse @value)
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
        public global::Orleans.Serialization.Invocation.CompletedResponse ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.Invocation.CompletedResponse, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ExceptionResponse : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Invocation.ExceptionResponse>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.Invocation.ExceptionResponse);
        private readonly global::System.Type _type0 = typeof(global::System.Exception);
        private readonly global::Orleans.Serialization.ExceptionCodec _codec0;
        public Codec_ExceptionResponse(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.ExceptionCodec>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.Invocation.ExceptionResponse instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Exception);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.Invocation.ExceptionResponse instance)
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
                    instance.Exception = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.Invocation.ExceptionResponse @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Invocation.ExceptionResponse ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.Invocation.ExceptionResponse, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Serialization.Invocation.ExceptionResponse();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_ExceptionResponse : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.Invocation.ExceptionResponse>
    {
        public global::Orleans.Serialization.Invocation.ExceptionResponse Create() => new global::Orleans.Serialization.Invocation.ExceptionResponse();
    }
}

namespace OrleansCodeGen.OrleansSerialization
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Metadata_OrleansSerialization : global::Orleans.Serialization.Configuration.TypeManifestProviderBase
    {
        protected override void ConfigureInner(global::Orleans.Serialization.Configuration.TypeManifestOptions config)
        {
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_ArrayListSurrogate));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_ConcurrentDictionarySurrogate<, >));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_ConcurrentQueueSurrogate<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_CultureInfoSurrogate));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_ImmutableArraySurrogate<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_ImmutableDictionarySurrogate<, >));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_ImmutableHashSetSurrogate<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_ImmutableListSurrogate<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_ImmutableQueueSurrogate<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_ImmutableSortedDictionarySurrogate<, >));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_ImmutableSortedSetSurrogate<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_ImmutableStackSurrogate<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_NameValueCollectionSurrogate));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_ReadOnlyCollectionSurrogate<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_ReadOnlyDictionarySurrogate<, >));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_SortedDictionarySurrogate<, >));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_SortedListSurrogate<, >));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_SortedSetSurrogate<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Codec_VersionSurrogate));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_SerializerException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_FieldIdNotPresentException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_SchemaTypeInvalidException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_FieldTypeInvalidException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_FieldTypeMissingException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_ExtendedWireTypeInvalidException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_UnsupportedWireTypeException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_ReferenceNotFoundException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_UnknownReferencedTypeException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_ReferenceFieldNotSupportedException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_UnknownWellKnownTypeException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_IllegalTypeException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_TypeMissingException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_RequiredFieldMissingException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_CodecNotFoundException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_UnexpectedLengthPrefixValueException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Invocation.Codec_CompletedResponse));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Invocation.Codec_ExceptionResponse));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_AggregateExceptionSurrogate));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codec_SerializationEntrySurrogate));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_ArrayListSurrogate));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_ConcurrentDictionarySurrogate<, >));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_ConcurrentQueueSurrogate<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Serialization.Codecs.CultureInfoSurrogate>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_ImmutableArraySurrogate<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_ImmutableDictionarySurrogate<, >));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_ImmutableHashSetSurrogate<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_ImmutableListSurrogate<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_ImmutableQueueSurrogate<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_ImmutableSortedDictionarySurrogate<, >));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_ImmutableSortedSetSurrogate<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_ImmutableStackSurrogate<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_NameValueCollectionSurrogate));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_ReadOnlyCollectionSurrogate<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_ReadOnlyDictionarySurrogate<, >));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_SortedDictionarySurrogate<, >));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_SortedListSurrogate<, >));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Codecs.Copier_SortedSetSurrogate<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Serialization.Codecs.VersionSurrogate>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_SerializerException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_FieldIdNotPresentException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_SchemaTypeInvalidException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_FieldTypeInvalidException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_FieldTypeMissingException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_ExtendedWireTypeInvalidException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_UnsupportedWireTypeException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_ReferenceNotFoundException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_UnknownReferencedTypeException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_ReferenceFieldNotSupportedException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_UnknownWellKnownTypeException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_IllegalTypeException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_TypeMissingException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_RequiredFieldMissingException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_CodecNotFoundException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_UnexpectedLengthPrefixValueException));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Serialization.Invocation.CompletedResponse>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Serialization.Invocation.ExceptionResponse>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_AggregateExceptionSurrogate));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Copier_SerializationEntrySurrogate));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ArrayCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ReadOnlyMemoryCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.MemoryCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ArraySegmentCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ArrayListCopier));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ByteArrayCopier));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ReadOnlyMemoryOfByteCopier));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ArraySegmentOfByteCopier));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.MemoryOfByteCopier));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.PooledBufferCopier));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.CollectionCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ConcurrentDictionaryCopier<, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ConcurrentQueueCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.CultureInfoCopier));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.DictionaryCopier<, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.HashSetCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableArrayCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableDictionaryCopier<, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableHashSetCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableListCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableQueueCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableSortedDictionaryCopier<, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableSortedSetCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableStackCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.IPAddressCopier));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.EndPointCopier));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.KeyValuePairCopier<, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ListCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.NameValueCollectionCopier));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.NullableCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ObjectCopier));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.QueueCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ReadOnlyCollectionCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ReadOnlyDictionaryCopier<, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.SortedDictionaryCopier<, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.SortedListCopier<, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.SortedSetCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.StackCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCopier<, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCopier<,, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCopier<,,, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCopier<,,,, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCopier<,,,,, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCopier<,,,,,, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCopier<,,,,,,, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.UriCopier));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCopier));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCopier<, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCopier<,, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCopier<,,, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCopier<,,,, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCopier<,,,,, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCopier<,,,,,, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCopier<,,,,,,, >));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.EqualityComparerBaseCodec<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Codecs.ComparerBaseCodec<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Invocation.PooledResponseCopier<>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.ExceptionCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ArrayCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ReadOnlyMemoryCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.MemoryCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ArraySegmentCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ArrayListCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.BitVector32Codec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ByteArrayCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ReadOnlyMemoryOfByteCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.MemoryOfByteCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.PooledBufferCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.CollectionCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.CompareInfoCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ConcurrentDictionaryCodec<, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ConcurrentQueueCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.CultureInfoCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.DateOnlyCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.DateTimeCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.DateTimeOffsetCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.DictionaryCodec<, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.DictionaryBaseCodec<, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.DateTimeKindCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.DayOfWeekCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.FloatCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.DoubleCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.DecimalCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.HalfCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.GuidCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.HashSetCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableArrayCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableDictionaryCodec<, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableHashSetCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableListCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableQueueCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableSortedDictionaryCodec<, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableSortedSetCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ImmutableStackCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.BoolCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.CharCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ByteCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.SByteCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.UInt16Codec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.Int16Codec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.UInt32Codec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.Int32Codec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.Int64Codec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.UInt64Codec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.Int128Codec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.UInt128Codec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.IPAddressCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.IPEndPointCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.KeyValuePairCodec<, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ListCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.NameValueCollectionCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.NullableCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ObjectCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.QueueCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ReadOnlyCollectionCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ReadOnlyDictionaryCodec<, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.SortedDictionaryCodec<, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.SortedListCodec<, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.SortedSetCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.StackCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.StringCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.TimeOnlyCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.TimeSpanCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCodec<, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCodec<,, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCodec<,,, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCodec<,,,, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCodec<,,,,, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCodec<,,,,,, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.TupleCodec<,,,,,,, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.TypeSerializerCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.UriCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCodec<, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCodec<,, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCodec<,,, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCodec<,,,, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCodec<,,,,, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCodec<,,,,,, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ValueTupleCodec<,,,,,,, >));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.VersionCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.EqualityComparerBaseCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Codecs.ComparerBaseCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.Invocation.PooledResponseCodec<>));
            config.Serializers.Add(typeof(global::Orleans.Serialization.ExceptionCodec));
            config.Serializers.Add(typeof(global::Orleans.Serialization.AggregateExceptionCodec));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.Activator_SerializerException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.Activator_FieldIdNotPresentException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.Activator_SchemaTypeInvalidException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.Activator_FieldTypeInvalidException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.Activator_ExtendedWireTypeInvalidException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.Activator_UnsupportedWireTypeException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.Activator_TypeMissingException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.Invocation.Activator_ExceptionResponse));
            config.Activators.Add(typeof(global::Orleans.Serialization.Invocation.CompletedResponseActivator));
            config.Activators.Add(typeof(global::Orleans.Serialization.Invocation.PooledResponseActivator<>));
            config.WellKnownTypeAliases.Add("StringComparer", typeof(global::Orleans.Serialization.Codecs.WellKnownStringComparerCodec));
            config.WellKnownTypeAliases.Add("ISerializable", typeof(global::Orleans.Serialization.DotNetSerializableCodec));
            config.WellKnownTypeAliases.Add("Exception", typeof(global::Orleans.Serialization.ExceptionCodec));
        }
    }
}