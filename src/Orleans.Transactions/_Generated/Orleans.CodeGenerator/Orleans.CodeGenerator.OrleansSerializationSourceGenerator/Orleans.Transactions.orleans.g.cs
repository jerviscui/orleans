#pragma warning disable CS1591
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Transactions")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Core.Abstractions")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Serialization")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Core")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Runtime")]
[assembly: global::Orleans.Serialization.Configuration.TypeManifestProviderAttribute(typeof(OrleansCodeGen.OrleansTransactions.Metadata_OrleansTransactions))]
namespace OrleansCodeGen.Orleans.Transactions.Abstractions
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), "Ext", typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension), typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension), "1BB071FE")]
    public sealed class Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE : global::Orleans.TransactionTaskRequest<global::Orleans.Transactions.TransactionalStatus>
    {
        public string arg0;
        public global::System.Guid arg1;
        public global::Orleans.Transactions.Abstractions.AccessCounter arg2;
        public global::System.DateTime arg3;
        global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension), "CommitReadOnly", null, new[] { typeof(string), typeof(global::System.Guid), typeof(global::Orleans.Transactions.Abstractions.AccessCounter), typeof(global::System.DateTime) });
        public Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> base0, global::System.IServiceProvider base1) : base(base0, base1)
        {
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.AlwaysInterleave);
            SetTransactionOptions(global::Orleans.TransactionOption.Suppress);
        }

        public override int GetArgumentCount() => 4;
        public override string GetMethodName() => "CommitReadOnly";
        public override string GetInterfaceName() => "Orleans.Transactions.Abstractions.ITransactionalResourceExtension";
        public override string GetActivityName() => "ITransactionalResourceExtension/CommitReadOnly";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetComponent<global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            arg3 = default;
            target = default;
            base.Dispose();
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
                case 3:
                    return arg3;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 3);
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
                    arg1 = (global::System.Guid)value;
                    return;
                case 2:
                    arg2 = (global::Orleans.Transactions.Abstractions.AccessCounter)value;
                    return;
                case 3:
                    arg3 = (global::System.DateTime)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 3);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.Transactions.TransactionalStatus> InvokeInner() => target.CommitReadOnly(arg0, arg1, arg2, arg3);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), "Ext", typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension), typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension), "BD051D23")]
    public sealed class Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23 : global::Orleans.TransactionTaskRequest
    {
        public string arg0;
        public global::System.Guid arg1;
        global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension), "Abort", null, new[] { typeof(string), typeof(global::System.Guid) });
        public Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> base0, global::System.IServiceProvider base1) : base(base0, base1)
        {
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.AlwaysInterleave);
            SetTransactionOptions(global::Orleans.TransactionOption.Suppress);
        }

        public override int GetArgumentCount() => 2;
        public override string GetMethodName() => "Abort";
        public override string GetInterfaceName() => "Orleans.Transactions.Abstractions.ITransactionalResourceExtension";
        public override string GetActivityName() => "ITransactionalResourceExtension/Abort";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetComponent<global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            target = default;
            base.Dispose();
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
                    arg1 = (global::System.Guid)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 1);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.Abort(arg0, arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), "Ext", typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension), typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension), "80028AB9")]
    public sealed class Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9 : global::Orleans.TransactionTaskRequest
    {
        public string arg0;
        public global::System.Guid arg1;
        public global::System.DateTime arg2;
        public global::Orleans.Transactions.TransactionalStatus arg3;
        global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension), "Cancel", null, new[] { typeof(string), typeof(global::System.Guid), typeof(global::System.DateTime), typeof(global::Orleans.Transactions.TransactionalStatus) });
        public Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> base0, global::System.IServiceProvider base1) : base(base0, base1)
        {
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.AlwaysInterleave);
            SetTransactionOptions(global::Orleans.TransactionOption.Suppress);
        }

        public override int GetArgumentCount() => 4;
        public override string GetMethodName() => "Cancel";
        public override string GetInterfaceName() => "Orleans.Transactions.Abstractions.ITransactionalResourceExtension";
        public override string GetActivityName() => "ITransactionalResourceExtension/Cancel";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetComponent<global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            arg3 = default;
            target = default;
            base.Dispose();
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
                case 3:
                    return arg3;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 3);
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
                    arg1 = (global::System.Guid)value;
                    return;
                case 2:
                    arg2 = (global::System.DateTime)value;
                    return;
                case 3:
                    arg3 = (global::Orleans.Transactions.TransactionalStatus)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 3);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.Cancel(arg0, arg1, arg2, arg3);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), "Ext", typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension), typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension), "5DDDE6F0")]
    public sealed class Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0 : global::Orleans.TransactionTaskRequest
    {
        public string arg0;
        public global::System.Guid arg1;
        public global::System.DateTime arg2;
        global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension), "Confirm", null, new[] { typeof(string), typeof(global::System.Guid), typeof(global::System.DateTime) });
        public Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> base0, global::System.IServiceProvider base1) : base(base0, base1)
        {
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.AlwaysInterleave);
            SetTransactionOptions(global::Orleans.TransactionOption.Suppress);
        }

        public override int GetArgumentCount() => 3;
        public override string GetMethodName() => "Confirm";
        public override string GetInterfaceName() => "Orleans.Transactions.Abstractions.ITransactionalResourceExtension";
        public override string GetActivityName() => "ITransactionalResourceExtension/Confirm";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetComponent<global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            target = default;
            base.Dispose();
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
                    arg0 = (string)value;
                    return;
                case 1:
                    arg1 = (global::System.Guid)value;
                    return;
                case 2:
                    arg2 = (global::System.DateTime)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.Confirm(arg0, arg1, arg2);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), "Ext", typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension), typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension), "2ADCC608")]
    public sealed class Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608 : global::Orleans.TransactionTaskRequest
    {
        public string arg0;
        public global::System.Guid arg1;
        public global::Orleans.Transactions.Abstractions.AccessCounter arg2;
        public global::System.DateTime arg3;
        public global::Orleans.Transactions.ParticipantId arg4;
        global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension), "Prepare", null, new[] { typeof(string), typeof(global::System.Guid), typeof(global::Orleans.Transactions.Abstractions.AccessCounter), typeof(global::System.DateTime), typeof(global::Orleans.Transactions.ParticipantId) });
        public Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> base0, global::System.IServiceProvider base1) : base(base0, base1)
        {
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.AlwaysInterleave);
            SetTransactionOptions(global::Orleans.TransactionOption.Suppress);
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.OneWay);
        }

        public override int GetArgumentCount() => 5;
        public override string GetMethodName() => "Prepare";
        public override string GetInterfaceName() => "Orleans.Transactions.Abstractions.ITransactionalResourceExtension";
        public override string GetActivityName() => "ITransactionalResourceExtension/Prepare";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetComponent<global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            arg3 = default;
            arg4 = default;
            target = default;
            base.Dispose();
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
                case 3:
                    return arg3;
                case 4:
                    return arg4;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 4);
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
                    arg1 = (global::System.Guid)value;
                    return;
                case 2:
                    arg2 = (global::Orleans.Transactions.Abstractions.AccessCounter)value;
                    return;
                case 3:
                    arg3 = (global::System.DateTime)value;
                    return;
                case 4:
                    arg4 = (global::Orleans.Transactions.ParticipantId)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 4);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.Prepare(arg0, arg1, arg2, arg3, arg4);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_ITransactionalResourceExtension : global::Orleans.Runtime.GrainReference, global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension
    {
        public Proxy_ITransactionalResourceExtension(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.Task<global::Orleans.Transactions.TransactionalStatus> global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension.CommitReadOnly(string arg0, global::System.Guid arg1, global::Orleans.Transactions.Abstractions.AccessCounter arg2, global::System.DateTime arg3)
        {
            var request = this.GetInvokable<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE>();
            request.arg0 = arg0;
            request.arg1 = arg1;
            request.arg2 = arg2;
            request.arg3 = arg3;
            return base.InvokeAsync<global::Orleans.Transactions.TransactionalStatus>(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension.Abort(string arg0, global::System.Guid arg1)
        {
            var request = this.GetInvokable<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23>();
            request.arg0 = arg0;
            request.arg1 = arg1;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension.Cancel(string arg0, global::System.Guid arg1, global::System.DateTime arg2, global::Orleans.Transactions.TransactionalStatus arg3)
        {
            var request = this.GetInvokable<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9>();
            request.arg0 = arg0;
            request.arg1 = arg1;
            request.arg2 = arg2;
            request.arg3 = arg3;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension.Confirm(string arg0, global::System.Guid arg1, global::System.DateTime arg2)
        {
            var request = this.GetInvokable<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0>();
            request.arg0 = arg0;
            request.arg1 = arg1;
            request.arg2 = arg2;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension.Prepare(string arg0, global::System.Guid arg1, global::Orleans.Transactions.Abstractions.AccessCounter arg2, global::System.DateTime arg3, global::Orleans.Transactions.ParticipantId arg4)
        {
            var request = this.GetInvokable<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608>();
            request.arg0 = arg0;
            request.arg1 = arg1;
            request.arg2 = arg2;
            request.arg3 = arg3;
            request.arg4 = arg4;
            return base.InvokeAsync(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), "Ext", typeof(global::Orleans.Transactions.Abstractions.ITransactionManagerExtension), typeof(global::Orleans.Transactions.Abstractions.ITransactionManagerExtension), "B024EFA6")]
    public sealed class Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6 : global::Orleans.TransactionTaskRequest<global::Orleans.Transactions.TransactionalStatus>
    {
        public string arg0;
        public global::System.Guid arg1;
        public global::Orleans.Transactions.Abstractions.AccessCounter arg2;
        public global::System.DateTime arg3;
        public global::System.Collections.Generic.List<global::Orleans.Transactions.ParticipantId> arg4;
        public int arg5;
        global::Orleans.Transactions.Abstractions.ITransactionManagerExtension target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Transactions.Abstractions.ITransactionManagerExtension), "PrepareAndCommit", null, new[] { typeof(string), typeof(global::System.Guid), typeof(global::Orleans.Transactions.Abstractions.AccessCounter), typeof(global::System.DateTime), typeof(global::System.Collections.Generic.List<global::Orleans.Transactions.ParticipantId>), typeof(int) });
        public Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> base0, global::System.IServiceProvider base1) : base(base0, base1)
        {
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.AlwaysInterleave);
            SetTransactionOptions(global::Orleans.TransactionOption.Suppress);
        }

        public override int GetArgumentCount() => 6;
        public override string GetMethodName() => "PrepareAndCommit";
        public override string GetInterfaceName() => "Orleans.Transactions.Abstractions.ITransactionManagerExtension";
        public override string GetActivityName() => "ITransactionManagerExtension/PrepareAndCommit";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Transactions.Abstractions.ITransactionManagerExtension);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetComponent<global::Orleans.Transactions.Abstractions.ITransactionManagerExtension>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            arg3 = default;
            arg4 = default;
            arg5 = default;
            target = default;
            base.Dispose();
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
                case 3:
                    return arg3;
                case 4:
                    return arg4;
                case 5:
                    return arg5;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 5);
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
                    arg1 = (global::System.Guid)value;
                    return;
                case 2:
                    arg2 = (global::Orleans.Transactions.Abstractions.AccessCounter)value;
                    return;
                case 3:
                    arg3 = (global::System.DateTime)value;
                    return;
                case 4:
                    arg4 = (global::System.Collections.Generic.List<global::Orleans.Transactions.ParticipantId>)value;
                    return;
                case 5:
                    arg5 = (int)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 5);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.Transactions.TransactionalStatus> InvokeInner() => target.PrepareAndCommit(arg0, arg1, arg2, arg3, arg4, arg5);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), "Ext", typeof(global::Orleans.Transactions.Abstractions.ITransactionManagerExtension), typeof(global::Orleans.Transactions.Abstractions.ITransactionManagerExtension), "12BEFA17")]
    public sealed class Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17 : global::Orleans.TransactionTaskRequest
    {
        public string arg0;
        public global::System.Guid arg1;
        public global::System.DateTime arg2;
        public global::Orleans.Transactions.ParticipantId arg3;
        public global::Orleans.Transactions.TransactionalStatus arg4;
        global::Orleans.Transactions.Abstractions.ITransactionManagerExtension target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Transactions.Abstractions.ITransactionManagerExtension), "Prepared", null, new[] { typeof(string), typeof(global::System.Guid), typeof(global::System.DateTime), typeof(global::Orleans.Transactions.ParticipantId), typeof(global::Orleans.Transactions.TransactionalStatus) });
        public Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> base0, global::System.IServiceProvider base1) : base(base0, base1)
        {
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.AlwaysInterleave);
            SetTransactionOptions(global::Orleans.TransactionOption.Suppress);
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.OneWay);
        }

        public override int GetArgumentCount() => 5;
        public override string GetMethodName() => "Prepared";
        public override string GetInterfaceName() => "Orleans.Transactions.Abstractions.ITransactionManagerExtension";
        public override string GetActivityName() => "ITransactionManagerExtension/Prepared";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Transactions.Abstractions.ITransactionManagerExtension);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetComponent<global::Orleans.Transactions.Abstractions.ITransactionManagerExtension>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            arg3 = default;
            arg4 = default;
            target = default;
            base.Dispose();
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
                case 3:
                    return arg3;
                case 4:
                    return arg4;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 4);
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
                    arg1 = (global::System.Guid)value;
                    return;
                case 2:
                    arg2 = (global::System.DateTime)value;
                    return;
                case 3:
                    arg3 = (global::Orleans.Transactions.ParticipantId)value;
                    return;
                case 4:
                    arg4 = (global::Orleans.Transactions.TransactionalStatus)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 4);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.Prepared(arg0, arg1, arg2, arg3, arg4);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Runtime.GrainReference), "Ext", typeof(global::Orleans.Transactions.Abstractions.ITransactionManagerExtension), typeof(global::Orleans.Transactions.Abstractions.ITransactionManagerExtension), "AC4A9AEB")]
    public sealed class Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB : global::Orleans.TransactionTaskRequest
    {
        public string arg0;
        public global::System.Guid arg1;
        public global::System.DateTime arg2;
        public global::Orleans.Transactions.ParticipantId arg3;
        global::Orleans.Transactions.Abstractions.ITransactionManagerExtension target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Transactions.Abstractions.ITransactionManagerExtension), "Ping", null, new[] { typeof(string), typeof(global::System.Guid), typeof(global::System.DateTime), typeof(global::Orleans.Transactions.ParticipantId) });
        public Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> base0, global::System.IServiceProvider base1) : base(base0, base1)
        {
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.AlwaysInterleave);
            SetTransactionOptions(global::Orleans.TransactionOption.Suppress);
            AddInvokeMethodOptions(global::Orleans.CodeGeneration.InvokeMethodOptions.OneWay);
        }

        public override int GetArgumentCount() => 4;
        public override string GetMethodName() => "Ping";
        public override string GetInterfaceName() => "Orleans.Transactions.Abstractions.ITransactionManagerExtension";
        public override string GetActivityName() => "ITransactionManagerExtension/Ping";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Transactions.Abstractions.ITransactionManagerExtension);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => target = holder.GetComponent<global::Orleans.Transactions.Abstractions.ITransactionManagerExtension>();
        public override object GetTarget() => target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            arg3 = default;
            target = default;
            base.Dispose();
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
                case 3:
                    return arg3;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 3);
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
                    arg1 = (global::System.Guid)value;
                    return;
                case 2:
                    arg2 = (global::System.DateTime)value;
                    return;
                case 3:
                    arg3 = (global::Orleans.Transactions.ParticipantId)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 3);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task InvokeInner() => target.Ping(arg0, arg1, arg2, arg3);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Proxy_ITransactionManagerExtension : global::Orleans.Runtime.GrainReference, global::Orleans.Transactions.Abstractions.ITransactionManagerExtension
    {
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Transactions.ParticipantId> _copier0;
        public Proxy_ITransactionManagerExtension(global::Orleans.Runtime.GrainReferenceShared arg0, global::Orleans.Runtime.IdSpan arg1) : base(arg0, arg1)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Transactions.ParticipantId>>(this, CodecProvider);
        }

        global::System.Threading.Tasks.Task<global::Orleans.Transactions.TransactionalStatus> global::Orleans.Transactions.Abstractions.ITransactionManagerExtension.PrepareAndCommit(string arg0, global::System.Guid arg1, global::Orleans.Transactions.Abstractions.AccessCounter arg2, global::System.DateTime arg3, global::System.Collections.Generic.List<global::Orleans.Transactions.ParticipantId> arg4, int arg5)
        {
            var request = this.GetInvokable<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6>();
            request.arg0 = arg0;
            request.arg1 = arg1;
            request.arg2 = arg2;
            request.arg3 = arg3;
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg4 = _copier0.DeepCopy(arg4, copyContext);
            request.arg5 = arg5;
            return base.InvokeAsync<global::Orleans.Transactions.TransactionalStatus>(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Transactions.Abstractions.ITransactionManagerExtension.Prepared(string arg0, global::System.Guid arg1, global::System.DateTime arg2, global::Orleans.Transactions.ParticipantId arg3, global::Orleans.Transactions.TransactionalStatus arg4)
        {
            var request = this.GetInvokable<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17>();
            request.arg0 = arg0;
            request.arg1 = arg1;
            request.arg2 = arg2;
            request.arg3 = arg3;
            request.arg4 = arg4;
            return base.InvokeAsync(request).AsTask();
        }

        global::System.Threading.Tasks.Task global::Orleans.Transactions.Abstractions.ITransactionManagerExtension.Ping(string arg0, global::System.Guid arg1, global::System.DateTime arg2, global::Orleans.Transactions.ParticipantId arg3)
        {
            var request = this.GetInvokable<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB>();
            request.arg0 = arg0;
            request.arg1 = arg1;
            request.arg2 = arg2;
            request.arg3 = arg3;
            return base.InvokeAsync(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE);
        private readonly OrleansCodeGen.Orleans.Codec_TransactionRequestBase _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE> _activator;
        private readonly global::System.Type _type0 = typeof(global::Orleans.Transactions.Abstractions.AccessCounter);
        private readonly OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_AccessCounter _codec0;
        public Codec_Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Codec_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_AccessCounter>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 1U, instance.arg1);
            _codec0.WriteField(ref writer, 1U, _type0, instance.arg2);
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 1U, instance.arg3);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE instance)
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
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.arg2 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.arg3 = global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE @value)
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
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE>
    {
        private readonly OrleansCodeGen.Orleans.Copier_TransactionRequestBase _baseTypeCopier;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE> _activator;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE DeepCopy(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = _activator.Create();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            result.arg2 = original.arg2;
            result.arg3 = original.arg3;
            return result;
        }

        public Copier_Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE> _activator)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Copier_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE : global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE>
    {
        private readonly global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> _arg0;
        private readonly global::System.IServiceProvider _arg1;
        public Activator_Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> arg0, global::System.IServiceProvider arg1)
        {
            _arg0 = OrleansGeneratedCodeHelper.UnwrapService(this, arg0);
            _arg1 = OrleansGeneratedCodeHelper.UnwrapService(this, arg1);
        }

        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE Create() => new OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE(_arg0, _arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23);
        private readonly OrleansCodeGen.Orleans.Codec_TransactionRequestBase _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23> _activator;
        public Codec_Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Codec_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 1U, instance.arg1);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23 instance)
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
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23 @value)
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
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23>
    {
        private readonly OrleansCodeGen.Orleans.Copier_TransactionRequestBase _baseTypeCopier;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23> _activator;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23 DeepCopy(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = _activator.Create();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            return result;
        }

        public Copier_Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23> _activator)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Copier_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23 : global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23>
    {
        private readonly global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> _arg0;
        private readonly global::System.IServiceProvider _arg1;
        public Activator_Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> arg0, global::System.IServiceProvider arg1)
        {
            _arg0 = OrleansGeneratedCodeHelper.UnwrapService(this, arg0);
            _arg1 = OrleansGeneratedCodeHelper.UnwrapService(this, arg1);
        }

        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23 Create() => new OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23(_arg0, _arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9);
        private readonly OrleansCodeGen.Orleans.Codec_TransactionRequestBase _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9> _activator;
        private readonly global::System.Type _type0 = typeof(global::Orleans.Transactions.TransactionalStatus);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.TransactionalStatus> _codec0;
        public Codec_Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Codec_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.TransactionalStatus>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 1U, instance.arg1);
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 1U, instance.arg2);
            _codec0.WriteField(ref writer, 1U, _type0, instance.arg3);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9 instance)
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
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.arg2 = global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.arg3 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9 @value)
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
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9>
    {
        private readonly OrleansCodeGen.Orleans.Copier_TransactionRequestBase _baseTypeCopier;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9> _activator;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9 DeepCopy(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = _activator.Create();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            result.arg2 = original.arg2;
            result.arg3 = original.arg3;
            return result;
        }

        public Copier_Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9> _activator)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Copier_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9 : global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9>
    {
        private readonly global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> _arg0;
        private readonly global::System.IServiceProvider _arg1;
        public Activator_Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> arg0, global::System.IServiceProvider arg1)
        {
            _arg0 = OrleansGeneratedCodeHelper.UnwrapService(this, arg0);
            _arg1 = OrleansGeneratedCodeHelper.UnwrapService(this, arg1);
        }

        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9 Create() => new OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9(_arg0, _arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0);
        private readonly OrleansCodeGen.Orleans.Codec_TransactionRequestBase _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0> _activator;
        public Codec_Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Codec_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 1U, instance.arg1);
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 1U, instance.arg2);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0 instance)
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
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.arg2 = global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0 @value)
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
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0>
    {
        private readonly OrleansCodeGen.Orleans.Copier_TransactionRequestBase _baseTypeCopier;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0> _activator;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0 DeepCopy(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = _activator.Create();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            result.arg2 = original.arg2;
            return result;
        }

        public Copier_Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0> _activator)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Copier_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0 : global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0>
    {
        private readonly global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> _arg0;
        private readonly global::System.IServiceProvider _arg1;
        public Activator_Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> arg0, global::System.IServiceProvider arg1)
        {
            _arg0 = OrleansGeneratedCodeHelper.UnwrapService(this, arg0);
            _arg1 = OrleansGeneratedCodeHelper.UnwrapService(this, arg1);
        }

        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0 Create() => new OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0(_arg0, _arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608);
        private readonly OrleansCodeGen.Orleans.Codec_TransactionRequestBase _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608> _activator;
        private readonly global::System.Type _type0 = typeof(global::Orleans.Transactions.Abstractions.AccessCounter);
        private readonly OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_AccessCounter _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Transactions.ParticipantId);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_ParticipantId _codec1;
        public Codec_Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Codec_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_AccessCounter>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_ParticipantId>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 1U, instance.arg1);
            _codec0.WriteField(ref writer, 1U, _type0, instance.arg2);
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 1U, instance.arg3);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg4);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608 instance)
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
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.arg2 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.arg3 = global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 4U)
                {
                    instance.arg4 = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608 @value)
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
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608>
    {
        private readonly OrleansCodeGen.Orleans.Copier_TransactionRequestBase _baseTypeCopier;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608> _activator;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608 DeepCopy(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = _activator.Create();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            result.arg2 = original.arg2;
            result.arg3 = original.arg3;
            result.arg4 = original.arg4;
            return result;
        }

        public Copier_Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608> _activator)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Copier_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608 : global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608>
    {
        private readonly global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> _arg0;
        private readonly global::System.IServiceProvider _arg1;
        public Activator_Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> arg0, global::System.IServiceProvider arg1)
        {
            _arg0 = OrleansGeneratedCodeHelper.UnwrapService(this, arg0);
            _arg1 = OrleansGeneratedCodeHelper.UnwrapService(this, arg1);
        }

        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608 Create() => new OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608(_arg0, _arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_PendingTransactionState<TState> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.Abstractions.PendingTransactionState<TState>> where TState : class, new()
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.Abstractions.PendingTransactionState<TState>);
        private readonly global::System.Type _type0 = typeof(TState);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<TState> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Transactions.ParticipantId);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_ParticipantId _codec1;
        public Codec_PendingTransactionState(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<TState>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_ParticipantId>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.Abstractions.PendingTransactionState<TState> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 0U, instance.SequenceId);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.TransactionId);
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 1U, instance.TimeStamp);
            _codec1.WriteField(ref writer, 1U, _type1, instance.TransactionManager);
            _codec0.WriteField(ref writer, 1U, _type0, instance.State);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.Abstractions.PendingTransactionState<TState> instance)
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
                    instance.SequenceId = global::Orleans.Serialization.Codecs.Int64Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.TransactionId = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.TimeStamp = global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.TransactionManager = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 4U)
                {
                    instance.State = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.Abstractions.PendingTransactionState<TState> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Transactions.Abstractions.PendingTransactionState<TState> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.Abstractions.PendingTransactionState<TState>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Transactions.Abstractions.PendingTransactionState<TState>();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_PendingTransactionState<TState> : global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Transactions.Abstractions.PendingTransactionState<TState>> where TState : class, new()
    {
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_PendingTransactionState<TState> : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.Abstractions.PendingTransactionState<TState>> where TState : class, new()
    {
        public global::Orleans.Transactions.Abstractions.PendingTransactionState<TState> Create() => new global::Orleans.Transactions.Abstractions.PendingTransactionState<TState>();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_TransactionalStorageLoadResponse<TState> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.Abstractions.TransactionalStorageLoadResponse<TState>> where TState : class, new()
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.Abstractions.TransactionalStorageLoadResponse<TState>);
        private readonly global::System.Type _type0 = typeof(TState);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<TState> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Transactions.Abstractions.TransactionalStateMetaData);
        private readonly OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_TransactionalStateMetaData _codec1;
        private readonly global::System.Type _type2 = typeof(global::System.Collections.Generic.IReadOnlyList<global::Orleans.Transactions.Abstractions.PendingTransactionState<TState>>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IReadOnlyList<global::Orleans.Transactions.Abstractions.PendingTransactionState<TState>>> _codec2;
        public Codec_TransactionalStorageLoadResponse(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<TState>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_TransactionalStateMetaData>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Generic.IReadOnlyList<global::Orleans.Transactions.Abstractions.PendingTransactionState<TState>>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.Abstractions.TransactionalStorageLoadResponse<TState> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.ETag);
            _codec0.WriteField(ref writer, 1U, _type0, instance.CommittedState);
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 1U, instance.CommittedSequenceId);
            _codec1.WriteField(ref writer, 1U, _type1, instance.Metadata);
            _codec2.WriteField(ref writer, 1U, _type2, instance.PendingStates);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.Abstractions.TransactionalStorageLoadResponse<TState> instance)
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
                    instance.ETag = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.CommittedState = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.CommittedSequenceId = global::Orleans.Serialization.Codecs.Int64Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.Metadata = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 4U)
                {
                    instance.PendingStates = _codec2.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.Abstractions.TransactionalStorageLoadResponse<TState> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Transactions.Abstractions.TransactionalStorageLoadResponse<TState> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.Abstractions.TransactionalStorageLoadResponse<TState>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Transactions.Abstractions.TransactionalStorageLoadResponse<TState>();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_TransactionalStorageLoadResponse<TState> : global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Transactions.Abstractions.TransactionalStorageLoadResponse<TState>> where TState : class, new()
    {
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_TransactionalStorageLoadResponse<TState> : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.Abstractions.TransactionalStorageLoadResponse<TState>> where TState : class, new()
    {
        public global::Orleans.Transactions.Abstractions.TransactionalStorageLoadResponse<TState> Create() => new global::Orleans.Transactions.Abstractions.TransactionalStorageLoadResponse<TState>();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_TransactionalStateMetaData : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.Abstractions.TransactionalStateMetaData>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.Abstractions.TransactionalStateMetaData);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.Dictionary<global::System.Guid, global::Orleans.Transactions.Abstractions.CommitRecord>);
        private readonly global::Orleans.Serialization.Codecs.DictionaryCodec<global::System.Guid, global::Orleans.Transactions.Abstractions.CommitRecord> _codec0;
        public Codec_TransactionalStateMetaData(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCodec<global::System.Guid, global::Orleans.Transactions.Abstractions.CommitRecord>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.Abstractions.TransactionalStateMetaData instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 0U, instance.TimeStamp);
            _codec0.WriteField(ref writer, 1U, _type0, instance.CommitRecords);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.Abstractions.TransactionalStateMetaData instance)
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
                    instance.TimeStamp = global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.CommitRecords = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.Abstractions.TransactionalStateMetaData @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Transactions.Abstractions.TransactionalStateMetaData ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.Abstractions.TransactionalStateMetaData, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Transactions.Abstractions.TransactionalStateMetaData();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_TransactionalStateMetaData : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Transactions.Abstractions.TransactionalStateMetaData>
    {
        private readonly global::Orleans.Serialization.Codecs.DictionaryCopier<global::System.Guid, global::Orleans.Transactions.Abstractions.CommitRecord> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Transactions.Abstractions.TransactionalStateMetaData DeepCopy(global::Orleans.Transactions.Abstractions.TransactionalStateMetaData original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Transactions.Abstractions.TransactionalStateMetaData existing))
                return existing;
            var result = new global::Orleans.Transactions.Abstractions.TransactionalStateMetaData();
            context.RecordCopy(original, result);
            result.TimeStamp = original.TimeStamp;
            result.CommitRecords = _copier0.DeepCopy(original.CommitRecords, context);
            return result;
        }

        public Copier_TransactionalStateMetaData(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCopier<global::System.Guid, global::Orleans.Transactions.Abstractions.CommitRecord>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_TransactionalStateMetaData : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.Abstractions.TransactionalStateMetaData>
    {
        public global::Orleans.Transactions.Abstractions.TransactionalStateMetaData Create() => new global::Orleans.Transactions.Abstractions.TransactionalStateMetaData();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_CommitRecord : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.Abstractions.CommitRecord>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.Abstractions.CommitRecord);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.List<global::Orleans.Transactions.ParticipantId>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Transactions.ParticipantId> _codec0;
        public Codec_CommitRecord(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Transactions.ParticipantId>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.Abstractions.CommitRecord instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 0U, instance.Timestamp);
            _codec0.WriteField(ref writer, 1U, _type0, instance.WriteParticipants);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.Abstractions.CommitRecord instance)
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
                    instance.Timestamp = global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.WriteParticipants = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.Abstractions.CommitRecord @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Transactions.Abstractions.CommitRecord ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.Abstractions.CommitRecord, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Transactions.Abstractions.CommitRecord();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_CommitRecord : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.Abstractions.CommitRecord>
    {
        public global::Orleans.Transactions.Abstractions.CommitRecord Create() => new global::Orleans.Transactions.Abstractions.CommitRecord();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_AccessCounter : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.Abstractions.AccessCounter>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Transactions.Abstractions.AccessCounter>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.Abstractions.AccessCounter);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Transactions.Abstractions.AccessCounter instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.Reads);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.Writes);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Transactions.Abstractions.AccessCounter instance)
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
                    instance.Reads = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.Writes = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.Abstractions.AccessCounter @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Transactions.Abstractions.AccessCounter ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Transactions.Abstractions.AccessCounter);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6);
        private readonly OrleansCodeGen.Orleans.Codec_TransactionRequestBase _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6> _activator;
        private readonly global::System.Type _type0 = typeof(global::Orleans.Transactions.Abstractions.AccessCounter);
        private readonly OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_AccessCounter _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Generic.List<global::Orleans.Transactions.ParticipantId>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Transactions.ParticipantId> _codec1;
        public Codec_Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Codec_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_AccessCounter>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Transactions.ParticipantId>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 1U, instance.arg1);
            _codec0.WriteField(ref writer, 1U, _type0, instance.arg2);
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 1U, instance.arg3);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg4);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.arg5);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6 instance)
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
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.arg2 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.arg3 = global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 4U)
                {
                    instance.arg4 = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 5U)
                {
                    instance.arg5 = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6 @value)
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
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6>
    {
        private readonly OrleansCodeGen.Orleans.Copier_TransactionRequestBase _baseTypeCopier;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6> _activator;
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Transactions.ParticipantId> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6 DeepCopy(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = _activator.Create();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            result.arg2 = original.arg2;
            result.arg3 = original.arg3;
            result.arg4 = _copier0.DeepCopy(original.arg4, context);
            result.arg5 = original.arg5;
            return result;
        }

        public Copier_Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6> _activator)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Copier_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Transactions.ParticipantId>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6 : global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6>
    {
        private readonly global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> _arg0;
        private readonly global::System.IServiceProvider _arg1;
        public Activator_Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> arg0, global::System.IServiceProvider arg1)
        {
            _arg0 = OrleansGeneratedCodeHelper.UnwrapService(this, arg0);
            _arg1 = OrleansGeneratedCodeHelper.UnwrapService(this, arg1);
        }

        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6 Create() => new OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6(_arg0, _arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17);
        private readonly OrleansCodeGen.Orleans.Codec_TransactionRequestBase _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17> _activator;
        private readonly global::System.Type _type0 = typeof(global::Orleans.Transactions.ParticipantId);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_ParticipantId _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Transactions.TransactionalStatus);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.TransactionalStatus> _codec1;
        public Codec_Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Codec_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_ParticipantId>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.TransactionalStatus>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 1U, instance.arg1);
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 1U, instance.arg2);
            _codec0.WriteField(ref writer, 1U, _type0, instance.arg3);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg4);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17 instance)
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
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.arg2 = global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.arg3 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 4U)
                {
                    instance.arg4 = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17 @value)
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
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17>
    {
        private readonly OrleansCodeGen.Orleans.Copier_TransactionRequestBase _baseTypeCopier;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17> _activator;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17 DeepCopy(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = _activator.Create();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            result.arg2 = original.arg2;
            result.arg3 = original.arg3;
            result.arg4 = original.arg4;
            return result;
        }

        public Copier_Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17> _activator)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Copier_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17 : global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17>
    {
        private readonly global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> _arg0;
        private readonly global::System.IServiceProvider _arg1;
        public Activator_Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> arg0, global::System.IServiceProvider arg1)
        {
            _arg0 = OrleansGeneratedCodeHelper.UnwrapService(this, arg0);
            _arg1 = OrleansGeneratedCodeHelper.UnwrapService(this, arg1);
        }

        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17 Create() => new OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17(_arg0, _arg1);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB);
        private readonly OrleansCodeGen.Orleans.Codec_TransactionRequestBase _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB> _activator;
        private readonly global::System.Type _type0 = typeof(global::Orleans.Transactions.ParticipantId);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_ParticipantId _codec0;
        public Codec_Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Codec_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_ParticipantId>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 1U, instance.arg1);
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 1U, instance.arg2);
            _codec0.WriteField(ref writer, 1U, _type0, instance.arg3);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB instance)
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
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.arg2 = global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.arg3 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB @value)
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
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB>
    {
        private readonly OrleansCodeGen.Orleans.Copier_TransactionRequestBase _baseTypeCopier;
        private readonly global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB> _activator;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB DeepCopy(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = _activator.Create();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = original.arg0;
            result.arg1 = original.arg1;
            result.arg2 = original.arg2;
            result.arg3 = original.arg3;
            return result;
        }

        public Copier_Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB> _activator)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Copier_TransactionRequestBase>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB : global::Orleans.Serialization.Activators.IActivator<OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB>
    {
        private readonly global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> _arg0;
        private readonly global::System.IServiceProvider _arg1;
        public Activator_Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB(global::Orleans.Serialization.Serializer<global::Orleans.Transactions.OrleansTransactionAbortedException> arg0, global::System.IServiceProvider arg1)
        {
            _arg0 = OrleansGeneratedCodeHelper.UnwrapService(this, arg0);
            _arg1 = OrleansGeneratedCodeHelper.UnwrapService(this, arg1);
        }

        public OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB Create() => new OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB(_arg0, _arg1);
    }
}
#pragma warning restore CS1591

namespace OrleansCodeGen.Orleans.Transactions
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_ParticipantId : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.ParticipantId>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Transactions.ParticipantId>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.ParticipantId);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Runtime.GrainReference);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GrainReference> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Transactions.ParticipantId.Role);
        private readonly OrleansCodeGen.Orleans.Transactions.ParticipantId.Codec_Role _codec1;
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Transactions.ParticipantId, string> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Transactions.ParticipantId, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Transactions.ParticipantId), "<Name>k__BackingField");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Transactions.ParticipantId, global::Orleans.Runtime.GrainReference> setField1 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Transactions.ParticipantId, global::Orleans.Runtime.GrainReference>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Transactions.ParticipantId), "<Reference>k__BackingField");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Transactions.ParticipantId, global::Orleans.Transactions.ParticipantId.Role> setField2 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Transactions.ParticipantId, global::Orleans.Transactions.ParticipantId.Role>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Transactions.ParticipantId), "<SupportedRoles>k__BackingField");
        public Codec_ParticipantId(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Runtime.GrainReference>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.ParticipantId.Codec_Role>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Transactions.ParticipantId instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.Name);
            _codec0.WriteField(ref writer, 1U, _type0, instance.Reference);
            _codec1.WriteField(ref writer, 1U, _type1, instance.SupportedRoles);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Transactions.ParticipantId instance)
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
                    setField0(ref instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(ref instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField2(ref instance, _codec1.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.ParticipantId @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Transactions.ParticipantId ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Transactions.ParticipantId);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_TransactionInfo : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.TransactionInfo>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.TransactionInfo);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.Dictionary<global::Orleans.Transactions.ParticipantId, global::Orleans.Transactions.Abstractions.AccessCounter>);
        private readonly global::Orleans.Serialization.Codecs.DictionaryCodec<global::Orleans.Transactions.ParticipantId, global::Orleans.Transactions.Abstractions.AccessCounter> _codec0;
        private static readonly global::System.Action<global::Orleans.Transactions.TransactionInfo, bool> setField0 = (global::System.Action<global::Orleans.Transactions.TransactionInfo, bool>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Transactions.TransactionInfo), "<IsReadOnly>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Transactions.TransactionInfo, global::System.Collections.Generic.Dictionary<global::Orleans.Transactions.ParticipantId, global::Orleans.Transactions.Abstractions.AccessCounter>> setField2 = (global::System.Action<global::Orleans.Transactions.TransactionInfo, global::System.Collections.Generic.Dictionary<global::Orleans.Transactions.ParticipantId, global::Orleans.Transactions.Abstractions.AccessCounter>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Transactions.TransactionInfo), "<Participants>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Transactions.TransactionInfo, global::System.Guid> setField5 = (global::System.Action<global::Orleans.Transactions.TransactionInfo, global::System.Guid>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Transactions.TransactionInfo), "<TransactionId>k__BackingField");
        public Codec_TransactionInfo(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCodec<global::Orleans.Transactions.ParticipantId, global::Orleans.Transactions.Abstractions.AccessCounter>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.TransactionInfo instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 0U, instance.TransactionId);
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 1U, instance.TimeStamp);
            global::Orleans.Serialization.Codecs.DateTimeCodec.WriteField(ref writer, 1U, instance.Priority);
            global::Orleans.Serialization.Codecs.BoolCodec.WriteField(ref writer, 1U, instance.IsReadOnly);
            global::Orleans.Serialization.Codecs.ByteArrayCodec.WriteField(ref writer, 1U, instance.OriginalException);
            _codec0.WriteField(ref writer, 1U, _type0, instance.Participants);
            global::Orleans.Serialization.Codecs.BoolCodec.WriteField(ref writer, 1U, instance.TryToCommit);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.TransactionInfo instance)
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
                    setField5(instance, global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.TimeStamp = global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.Priority = global::Orleans.Serialization.Codecs.DateTimeCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.BoolCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 4U)
                {
                    instance.OriginalException = global::Orleans.Serialization.Codecs.ByteArrayCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 5U)
                {
                    setField2(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 6U)
                {
                    instance.TryToCommit = global::Orleans.Serialization.Codecs.BoolCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.TransactionInfo @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Transactions.TransactionInfo ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.TransactionInfo, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Transactions.TransactionInfo();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_TransactionInfo : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Transactions.TransactionInfo>
    {
        private readonly global::Orleans.Serialization.Codecs.DictionaryCopier<global::Orleans.Transactions.ParticipantId, global::Orleans.Transactions.Abstractions.AccessCounter> _copier0;
        private static readonly global::System.Action<global::Orleans.Transactions.TransactionInfo, bool> setField0 = (global::System.Action<global::Orleans.Transactions.TransactionInfo, bool>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Transactions.TransactionInfo), "<IsReadOnly>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Transactions.TransactionInfo, global::System.Collections.Generic.Dictionary<global::Orleans.Transactions.ParticipantId, global::Orleans.Transactions.Abstractions.AccessCounter>> setField2 = (global::System.Action<global::Orleans.Transactions.TransactionInfo, global::System.Collections.Generic.Dictionary<global::Orleans.Transactions.ParticipantId, global::Orleans.Transactions.Abstractions.AccessCounter>>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Transactions.TransactionInfo), "<Participants>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Transactions.TransactionInfo, global::System.Guid> setField5 = (global::System.Action<global::Orleans.Transactions.TransactionInfo, global::System.Guid>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Transactions.TransactionInfo), "<TransactionId>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Transactions.TransactionInfo DeepCopy(global::Orleans.Transactions.TransactionInfo original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Transactions.TransactionInfo existing))
                return existing;
            var result = new global::Orleans.Transactions.TransactionInfo();
            context.RecordCopy(original, result);
            setField5(result, original.TransactionId);
            result.TimeStamp = original.TimeStamp;
            result.Priority = original.Priority;
            setField0(result, original.IsReadOnly);
            result.OriginalException = global::Orleans.Serialization.Codecs.ByteArrayCopier.DeepCopy(original.OriginalException, context);
            setField2(result, _copier0.DeepCopy(original.Participants, context));
            result.TryToCommit = original.TryToCommit;
            return result;
        }

        public Copier_TransactionInfo(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.DictionaryCopier<global::Orleans.Transactions.ParticipantId, global::Orleans.Transactions.Abstractions.AccessCounter>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_TransactionInfo : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.TransactionInfo>
    {
        public global::Orleans.Transactions.TransactionInfo Create() => new global::Orleans.Transactions.TransactionInfo();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansTransactionException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.OrleansTransactionException>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Transactions.OrleansTransactionException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.OrleansTransactionException);
        private readonly OrleansCodeGen.Orleans.Runtime.Codec_OrleansException _baseTypeSerializer;
        public Codec_OrleansTransactionException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Runtime.Codec_OrleansException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.OrleansTransactionException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.OrleansTransactionException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.OrleansTransactionException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Transactions.OrleansTransactionException))
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
        public global::Orleans.Transactions.OrleansTransactionException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.OrleansTransactionException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Transactions.OrleansTransactionException();
                ReferenceCodec.MarkValueField(reader.Session);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Transactions.OrleansTransactionException>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansTransactionException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Transactions.OrleansTransactionException, global::Orleans.Runtime.OrleansException>
    {
        public Copier_OrleansTransactionException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_OrleansTransactionException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansTransactionException>
    {
        public global::Orleans.Transactions.OrleansTransactionException Create() => new global::Orleans.Transactions.OrleansTransactionException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansTransactionsDisabledException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.OrleansTransactionsDisabledException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.OrleansTransactionsDisabledException);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionException _baseTypeSerializer;
        public Codec_OrleansTransactionsDisabledException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.OrleansTransactionsDisabledException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.OrleansTransactionsDisabledException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.OrleansTransactionsDisabledException @value)
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
        public global::Orleans.Transactions.OrleansTransactionsDisabledException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.OrleansTransactionsDisabledException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Transactions.OrleansTransactionsDisabledException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansTransactionsDisabledException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Transactions.OrleansTransactionsDisabledException, global::Orleans.Transactions.OrleansTransactionException>
    {
        public Copier_OrleansTransactionsDisabledException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_OrleansTransactionsDisabledException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansTransactionsDisabledException>
    {
        public global::Orleans.Transactions.OrleansTransactionsDisabledException Create() => new global::Orleans.Transactions.OrleansTransactionsDisabledException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansStartTransactionFailedException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.OrleansStartTransactionFailedException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.OrleansStartTransactionFailedException);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansStartTransactionFailedException> _activator;
        public Codec_OrleansStartTransactionFailedException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansStartTransactionFailedException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.OrleansStartTransactionFailedException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.OrleansStartTransactionFailedException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.OrleansStartTransactionFailedException @value)
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
        public global::Orleans.Transactions.OrleansStartTransactionFailedException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.OrleansStartTransactionFailedException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansStartTransactionFailedException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Transactions.OrleansStartTransactionFailedException, global::Orleans.Transactions.OrleansTransactionException>
    {
        public Copier_OrleansStartTransactionFailedException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansTransactionOverloadException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.OrleansTransactionOverloadException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.OrleansTransactionOverloadException);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionException _baseTypeSerializer;
        public Codec_OrleansTransactionOverloadException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.OrleansTransactionOverloadException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.OrleansTransactionOverloadException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.OrleansTransactionOverloadException @value)
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
        public global::Orleans.Transactions.OrleansTransactionOverloadException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.OrleansTransactionOverloadException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Transactions.OrleansTransactionOverloadException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansTransactionOverloadException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Transactions.OrleansTransactionOverloadException, global::Orleans.Transactions.OrleansTransactionException>
    {
        public Copier_OrleansTransactionOverloadException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_OrleansTransactionOverloadException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansTransactionOverloadException>
    {
        public global::Orleans.Transactions.OrleansTransactionOverloadException Create() => new global::Orleans.Transactions.OrleansTransactionOverloadException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansTransactionInDoubtException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.OrleansTransactionInDoubtException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.OrleansTransactionInDoubtException);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansTransactionInDoubtException> _activator;
        private static readonly global::System.Action<global::Orleans.Transactions.OrleansTransactionInDoubtException, string> setField0 = (global::System.Action<global::Orleans.Transactions.OrleansTransactionInDoubtException, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Transactions.OrleansTransactionInDoubtException), "<TransactionId>k__BackingField");
        public Codec_OrleansTransactionInDoubtException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansTransactionInDoubtException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.OrleansTransactionInDoubtException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.TransactionId);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.OrleansTransactionInDoubtException instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.OrleansTransactionInDoubtException @value)
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
        public global::Orleans.Transactions.OrleansTransactionInDoubtException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.OrleansTransactionInDoubtException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansTransactionInDoubtException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Transactions.OrleansTransactionInDoubtException, global::Orleans.Transactions.OrleansTransactionException>
    {
        private static readonly global::System.Action<global::Orleans.Transactions.OrleansTransactionInDoubtException, string> setField0 = (global::System.Action<global::Orleans.Transactions.OrleansTransactionInDoubtException, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Transactions.OrleansTransactionInDoubtException), "<TransactionId>k__BackingField");
        public Copier_OrleansTransactionInDoubtException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void DeepCopy(global::Orleans.Transactions.OrleansTransactionInDoubtException input, global::Orleans.Transactions.OrleansTransactionInDoubtException output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            base.DeepCopy(input, output, context);
            setField0(output, input.TransactionId);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansTransactionAbortedException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.OrleansTransactionAbortedException>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Transactions.OrleansTransactionAbortedException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.OrleansTransactionAbortedException);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansTransactionAbortedException> _activator;
        private static readonly global::System.Action<global::Orleans.Transactions.OrleansTransactionAbortedException, string> setField0 = (global::System.Action<global::Orleans.Transactions.OrleansTransactionAbortedException, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Transactions.OrleansTransactionAbortedException), "<TransactionId>k__BackingField");
        public Codec_OrleansTransactionAbortedException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansTransactionAbortedException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.OrleansTransactionAbortedException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.TransactionId);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.OrleansTransactionAbortedException instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.OrleansTransactionAbortedException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Transactions.OrleansTransactionAbortedException))
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
        public global::Orleans.Transactions.OrleansTransactionAbortedException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.OrleansTransactionAbortedException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.MarkValueField(reader.Session);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Transactions.OrleansTransactionAbortedException>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansTransactionAbortedException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Transactions.OrleansTransactionAbortedException, global::Orleans.Transactions.OrleansTransactionException>
    {
        private static readonly global::System.Action<global::Orleans.Transactions.OrleansTransactionAbortedException, string> setField0 = (global::System.Action<global::Orleans.Transactions.OrleansTransactionAbortedException, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Transactions.OrleansTransactionAbortedException), "<TransactionId>k__BackingField");
        public Copier_OrleansTransactionAbortedException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void DeepCopy(global::Orleans.Transactions.OrleansTransactionAbortedException input, global::Orleans.Transactions.OrleansTransactionAbortedException output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            base.DeepCopy(input, output, context);
            setField0(output, input.TransactionId);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansCascadingAbortException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.OrleansCascadingAbortException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.OrleansCascadingAbortException);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionTransientFailureException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansCascadingAbortException> _activator;
        private static readonly global::System.Action<global::Orleans.Transactions.OrleansCascadingAbortException, string> setField0 = (global::System.Action<global::Orleans.Transactions.OrleansCascadingAbortException, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Transactions.OrleansCascadingAbortException), "<DependentTransactionId>k__BackingField");
        public Codec_OrleansCascadingAbortException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansCascadingAbortException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionTransientFailureException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.OrleansCascadingAbortException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.DependentTransactionId);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.OrleansCascadingAbortException instance)
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
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.OrleansCascadingAbortException @value)
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
        public global::Orleans.Transactions.OrleansCascadingAbortException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.OrleansCascadingAbortException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansCascadingAbortException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Transactions.OrleansCascadingAbortException, global::Orleans.Transactions.OrleansTransactionTransientFailureException>
    {
        private static readonly global::System.Action<global::Orleans.Transactions.OrleansCascadingAbortException, string> setField0 = (global::System.Action<global::Orleans.Transactions.OrleansCascadingAbortException, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Transactions.OrleansCascadingAbortException), "<DependentTransactionId>k__BackingField");
        public Copier_OrleansCascadingAbortException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void DeepCopy(global::Orleans.Transactions.OrleansCascadingAbortException input, global::Orleans.Transactions.OrleansCascadingAbortException output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            base.DeepCopy(input, output, context);
            setField0(output, input.DependentTransactionId);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansOrphanCallException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.OrleansOrphanCallException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.OrleansOrphanCallException);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionAbortedException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansOrphanCallException> _activator;
        public Codec_OrleansOrphanCallException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansOrphanCallException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionAbortedException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.OrleansOrphanCallException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.OrleansOrphanCallException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.OrleansOrphanCallException @value)
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
        public global::Orleans.Transactions.OrleansOrphanCallException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.OrleansOrphanCallException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansOrphanCallException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Transactions.OrleansOrphanCallException, global::Orleans.Transactions.OrleansTransactionAbortedException>
    {
        public Copier_OrleansOrphanCallException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansReadOnlyViolatedException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.OrleansReadOnlyViolatedException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.OrleansReadOnlyViolatedException);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionAbortedException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansReadOnlyViolatedException> _activator;
        public Codec_OrleansReadOnlyViolatedException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansReadOnlyViolatedException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionAbortedException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.OrleansReadOnlyViolatedException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.OrleansReadOnlyViolatedException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.OrleansReadOnlyViolatedException @value)
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
        public global::Orleans.Transactions.OrleansReadOnlyViolatedException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.OrleansReadOnlyViolatedException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansReadOnlyViolatedException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Transactions.OrleansReadOnlyViolatedException, global::Orleans.Transactions.OrleansTransactionAbortedException>
    {
        public Copier_OrleansReadOnlyViolatedException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansTransactionServiceNotAvailableException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.OrleansTransactionServiceNotAvailableException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.OrleansTransactionServiceNotAvailableException);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionException _baseTypeSerializer;
        public Codec_OrleansTransactionServiceNotAvailableException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionException>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.OrleansTransactionServiceNotAvailableException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.OrleansTransactionServiceNotAvailableException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.OrleansTransactionServiceNotAvailableException @value)
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
        public global::Orleans.Transactions.OrleansTransactionServiceNotAvailableException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.OrleansTransactionServiceNotAvailableException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Transactions.OrleansTransactionServiceNotAvailableException();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansTransactionServiceNotAvailableException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Transactions.OrleansTransactionServiceNotAvailableException, global::Orleans.Transactions.OrleansTransactionException>
    {
        public Copier_OrleansTransactionServiceNotAvailableException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_OrleansTransactionServiceNotAvailableException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansTransactionServiceNotAvailableException>
    {
        public global::Orleans.Transactions.OrleansTransactionServiceNotAvailableException Create() => new global::Orleans.Transactions.OrleansTransactionServiceNotAvailableException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansBrokenTransactionLockException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.OrleansBrokenTransactionLockException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.OrleansBrokenTransactionLockException);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionTransientFailureException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansBrokenTransactionLockException> _activator;
        public Codec_OrleansBrokenTransactionLockException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansBrokenTransactionLockException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionTransientFailureException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.OrleansBrokenTransactionLockException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.OrleansBrokenTransactionLockException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.OrleansBrokenTransactionLockException @value)
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
        public global::Orleans.Transactions.OrleansBrokenTransactionLockException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.OrleansBrokenTransactionLockException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansBrokenTransactionLockException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Transactions.OrleansBrokenTransactionLockException, global::Orleans.Transactions.OrleansTransactionTransientFailureException>
    {
        public Copier_OrleansBrokenTransactionLockException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansTransactionLockUpgradeException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.OrleansTransactionLockUpgradeException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.OrleansTransactionLockUpgradeException);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionTransientFailureException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansTransactionLockUpgradeException> _activator;
        public Codec_OrleansTransactionLockUpgradeException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansTransactionLockUpgradeException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionTransientFailureException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.OrleansTransactionLockUpgradeException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.OrleansTransactionLockUpgradeException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.OrleansTransactionLockUpgradeException @value)
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
        public global::Orleans.Transactions.OrleansTransactionLockUpgradeException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.OrleansTransactionLockUpgradeException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansTransactionLockUpgradeException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Transactions.OrleansTransactionLockUpgradeException, global::Orleans.Transactions.OrleansTransactionTransientFailureException>
    {
        public Copier_OrleansTransactionLockUpgradeException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansTransactionPrepareTimeoutException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.OrleansTransactionPrepareTimeoutException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.OrleansTransactionPrepareTimeoutException);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionTransientFailureException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansTransactionPrepareTimeoutException> _activator;
        public Codec_OrleansTransactionPrepareTimeoutException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansTransactionPrepareTimeoutException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionTransientFailureException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.OrleansTransactionPrepareTimeoutException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.OrleansTransactionPrepareTimeoutException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.OrleansTransactionPrepareTimeoutException @value)
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
        public global::Orleans.Transactions.OrleansTransactionPrepareTimeoutException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.OrleansTransactionPrepareTimeoutException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansTransactionPrepareTimeoutException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Transactions.OrleansTransactionPrepareTimeoutException, global::Orleans.Transactions.OrleansTransactionTransientFailureException>
    {
        public Copier_OrleansTransactionPrepareTimeoutException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OrleansTransactionTransientFailureException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.OrleansTransactionTransientFailureException>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Transactions.OrleansTransactionTransientFailureException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.OrleansTransactionTransientFailureException);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionAbortedException _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansTransactionTransientFailureException> _activator;
        public Codec_OrleansTransactionTransientFailureException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.OrleansTransactionTransientFailureException> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionAbortedException>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.OrleansTransactionTransientFailureException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.OrleansTransactionTransientFailureException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.OrleansTransactionTransientFailureException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Transactions.OrleansTransactionTransientFailureException))
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
        public global::Orleans.Transactions.OrleansTransactionTransientFailureException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.OrleansTransactionTransientFailureException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.MarkValueField(reader.Session);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Transactions.OrleansTransactionTransientFailureException>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OrleansTransactionTransientFailureException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Transactions.OrleansTransactionTransientFailureException, global::Orleans.Transactions.OrleansTransactionAbortedException>
    {
        public Copier_OrleansTransactionTransientFailureException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_TransactionalStateRecord<TState> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.TransactionalStateRecord<TState>> where TState : class, new()
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.TransactionalStateRecord<TState>);
        private readonly global::System.Type _type0 = typeof(TState);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<TState> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Transactions.Abstractions.TransactionalStateMetaData);
        private readonly OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_TransactionalStateMetaData _codec1;
        private readonly global::System.Type _type2 = typeof(global::System.Collections.Generic.List<global::Orleans.Transactions.Abstractions.PendingTransactionState<TState>>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Transactions.Abstractions.PendingTransactionState<TState>> _codec2;
        public Codec_TransactionalStateRecord(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<TState>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_TransactionalStateMetaData>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Transactions.Abstractions.PendingTransactionState<TState>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.TransactionalStateRecord<TState> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.CommittedState);
            global::Orleans.Serialization.Codecs.Int64Codec.WriteField(ref writer, 1U, instance.CommittedSequenceId);
            _codec1.WriteField(ref writer, 1U, _type1, instance.Metadata);
            _codec2.WriteField(ref writer, 1U, _type2, instance.PendingStates);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.TransactionalStateRecord<TState> instance)
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
                    instance.CommittedState = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.CommittedSequenceId = global::Orleans.Serialization.Codecs.Int64Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.Metadata = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.PendingStates = _codec2.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.TransactionalStateRecord<TState> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Transactions.TransactionalStateRecord<TState> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.TransactionalStateRecord<TState>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Transactions.TransactionalStateRecord<TState>();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_TransactionalStateRecord<TState> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Transactions.TransactionalStateRecord<TState>> where TState : class, new()
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<TState> _copier0;
        private readonly OrleansCodeGen.Orleans.Transactions.Abstractions.Copier_TransactionalStateMetaData _copier1;
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Transactions.Abstractions.PendingTransactionState<TState>> _copier2;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Transactions.TransactionalStateRecord<TState> DeepCopy(global::Orleans.Transactions.TransactionalStateRecord<TState> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Transactions.TransactionalStateRecord<TState> existing))
                return existing;
            var result = new global::Orleans.Transactions.TransactionalStateRecord<TState>();
            context.RecordCopy(original, result);
            result.CommittedState = _copier0.DeepCopy(original.CommittedState, context);
            result.CommittedSequenceId = original.CommittedSequenceId;
            result.Metadata = _copier1.DeepCopy(original.Metadata, context);
            result.PendingStates = _copier2.DeepCopy(original.PendingStates, context);
            return result;
        }

        public Copier_TransactionalStateRecord(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<TState>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Abstractions.Copier_TransactionalStateMetaData>(this, codecProvider);
            _copier2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Transactions.Abstractions.PendingTransactionState<TState>>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_TransactionalStateRecord<TState> : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.TransactionalStateRecord<TState>> where TState : class, new()
    {
        public global::Orleans.Transactions.TransactionalStateRecord<TState> Create() => new global::Orleans.Transactions.TransactionalStateRecord<TState>();
    }
}

namespace OrleansCodeGen.Orleans.Transactions.ParticipantId
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_Role : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.ParticipantId.Role>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.ParticipantId.Role);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.ParticipantId.Role @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, fieldIdDelta, expectedType, (int)@value, _codecFieldType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Transactions.ParticipantId.Role ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            return (global::Orleans.Transactions.ParticipantId.Role)global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_IdComparer : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.ParticipantId.IdComparer>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.ParticipantId.IdComparer);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.ParticipantId.IdComparer instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.ParticipantId.IdComparer instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.ParticipantId.IdComparer @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Transactions.ParticipantId.IdComparer ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.ParticipantId.IdComparer, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Transactions.ParticipantId.IdComparer();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_IdComparer : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.ParticipantId.IdComparer>
    {
        public global::Orleans.Transactions.ParticipantId.IdComparer Create() => new global::Orleans.Transactions.ParticipantId.IdComparer();
    }
}

namespace OrleansCodeGen.Orleans.Transactions.TransactionCommitter
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_OperationState<TService> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.TransactionCommitter<TService>.OperationState> where TService : class
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Transactions.TransactionCommitter<TService>.OperationState);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Transactions.Abstractions.ITransactionCommitOperation<TService>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.Abstractions.ITransactionCommitOperation<TService>> _codec0;
        public Codec_OperationState(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Transactions.Abstractions.ITransactionCommitOperation<TService>>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Transactions.TransactionCommitter<TService>.OperationState instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Operation);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Transactions.TransactionCommitter<TService>.OperationState instance)
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
                    instance.Operation = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Transactions.TransactionCommitter<TService>.OperationState @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Transactions.TransactionCommitter<TService>.OperationState ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Transactions.TransactionCommitter<TService>.OperationState, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Transactions.TransactionCommitter<TService>.OperationState();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_OperationState<TService> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Transactions.TransactionCommitter<TService>.OperationState> where TService : class
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Transactions.Abstractions.ITransactionCommitOperation<TService>> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Transactions.TransactionCommitter<TService>.OperationState DeepCopy(global::Orleans.Transactions.TransactionCommitter<TService>.OperationState original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Transactions.TransactionCommitter<TService>.OperationState existing))
                return existing;
            var result = new global::Orleans.Transactions.TransactionCommitter<TService>.OperationState();
            context.RecordCopy(original, result);
            result.Operation = _copier0.DeepCopy(original.Operation, context);
            return result;
        }

        public Copier_OperationState(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Transactions.Abstractions.ITransactionCommitOperation<TService>>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_OperationState<TService> : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Transactions.TransactionCommitter<TService>.OperationState> where TService : class
    {
        public global::Orleans.Transactions.TransactionCommitter<TService>.OperationState Create() => new global::Orleans.Transactions.TransactionCommitter<TService>.OperationState();
    }
}

namespace OrleansCodeGen.Orleans
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_TransactionRequestBase : global::Orleans.Serialization.Serializers.AbstractTypeSerializer<global::Orleans.TransactionRequestBase>
    {
        private readonly global::System.Type _type0 = typeof(global::Orleans.Transactions.TransactionInfo);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_TransactionInfo _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.TransactionOption);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.TransactionOption> _codec1;
        public Codec_TransactionRequestBase(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_TransactionInfo>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.TransactionOption>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.TransactionRequestBase instance)
        {
            _codec1.WriteField(ref writer, 0U, _type1, instance.TransactionOption);
            _codec0.WriteField(ref writer, 1U, _type0, instance.TransactionInfo);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.TransactionRequestBase instance)
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
                    instance.TransactionOption = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.TransactionInfo = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_TransactionRequestBase : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.TransactionRequestBase>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.TransactionRequestBase>
    {
        private readonly OrleansCodeGen.Orleans.Transactions.Copier_TransactionInfo _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.TransactionRequestBase DeepCopy(global::Orleans.TransactionRequestBase original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return context.DeepCopy(original);
        }

        public Copier_TransactionRequestBase(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Copier_TransactionInfo>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.TransactionRequestBase input, global::Orleans.TransactionRequestBase output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.TransactionOption = input.TransactionOption;
            output.TransactionInfo = _copier0.DeepCopy(input.TransactionInfo, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Codec_TransactionResponse : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.TransactionResponse>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.TransactionResponse);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Serialization.Invocation.Response);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Invocation.Response> _codec0;
        private readonly global::System.Type _type1 = typeof(global::Orleans.Transactions.TransactionInfo);
        private readonly OrleansCodeGen.Orleans.Transactions.Codec_TransactionInfo _codec1;
        private static readonly global::System.Func<global::Orleans.TransactionResponse, global::Orleans.Serialization.Invocation.Response> getField0 = (global::System.Func<global::Orleans.TransactionResponse, global::Orleans.Serialization.Invocation.Response>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.TransactionResponse), "_response");
        private static readonly global::System.Action<global::Orleans.TransactionResponse, global::Orleans.Serialization.Invocation.Response> setField0 = (global::System.Action<global::Orleans.TransactionResponse, global::Orleans.Serialization.Invocation.Response>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.TransactionResponse), "_response");
        public Codec_TransactionResponse(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.Invocation.Response>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Codec_TransactionInfo>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.TransactionResponse instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, getField0(instance));
            _codec1.WriteField(ref writer, 1U, _type1, instance.TransactionInfo);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.TransactionResponse instance)
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
                    instance.TransactionInfo = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.TransactionResponse @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.TransactionResponse ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.TransactionResponse, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.TransactionResponse();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class Copier_TransactionResponse : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.TransactionResponse>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Invocation.Response> _copier0;
        private readonly OrleansCodeGen.Orleans.Transactions.Copier_TransactionInfo _copier1;
        private static readonly global::System.Func<global::Orleans.TransactionResponse, global::Orleans.Serialization.Invocation.Response> getField0 = (global::System.Func<global::Orleans.TransactionResponse, global::Orleans.Serialization.Invocation.Response>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.TransactionResponse), "_response");
        private static readonly global::System.Action<global::Orleans.TransactionResponse, global::Orleans.Serialization.Invocation.Response> setField0 = (global::System.Action<global::Orleans.TransactionResponse, global::Orleans.Serialization.Invocation.Response>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.TransactionResponse), "_response");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.TransactionResponse DeepCopy(global::Orleans.TransactionResponse original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.TransactionResponse existing))
                return existing;
            var result = new global::Orleans.TransactionResponse();
            context.RecordCopy(original, result);
            setField0(result, _copier0.DeepCopy(getField0(original), context));
            result.TransactionInfo = _copier1.DeepCopy(original.TransactionInfo, context);
            return result;
        }

        public Copier_TransactionResponse(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Invocation.Response>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Transactions.Copier_TransactionInfo>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Activator_TransactionResponse : global::Orleans.Serialization.Activators.IActivator<global::Orleans.TransactionResponse>
    {
        public global::Orleans.TransactionResponse Create() => new global::Orleans.TransactionResponse();
    }
}

namespace OrleansCodeGen.OrleansTransactions
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "8.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class Metadata_OrleansTransactions : global::Orleans.Serialization.Configuration.TypeManifestProviderBase
    {
        protected override void ConfigureInner(global::Orleans.Serialization.Configuration.TypeManifestOptions config)
        {
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_PendingTransactionState<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_TransactionalStorageLoadResponse<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_TransactionalStateMetaData));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_CommitRecord));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_AccessCounter));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Codec_Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_ParticipantId));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.ParticipantId.Codec_Role));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.ParticipantId.Codec_IdComparer));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_TransactionInfo));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionsDisabledException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_OrleansStartTransactionFailedException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionOverloadException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionInDoubtException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionAbortedException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_OrleansCascadingAbortException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_OrleansOrphanCallException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_OrleansReadOnlyViolatedException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionServiceNotAvailableException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_OrleansBrokenTransactionLockException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionLockUpgradeException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionPrepareTimeoutException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_OrleansTransactionTransientFailureException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Codec_TransactionalStateRecord<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Transactions.TransactionCommitter.Codec_OperationState<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_TransactionRequestBase));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Codec_TransactionResponse));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Copier_Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Copier_Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Copier_Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Copier_Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Copier_Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Copier_PendingTransactionState<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Copier_TransactionalStorageLoadResponse<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Copier_TransactionalStateMetaData));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Transactions.Abstractions.CommitRecord>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Transactions.Abstractions.AccessCounter>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Copier_Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Copier_Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Copier_Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Transactions.ParticipantId>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Transactions.ParticipantId.IdComparer>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_TransactionInfo));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_OrleansTransactionException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_OrleansTransactionsDisabledException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_OrleansStartTransactionFailedException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_OrleansTransactionOverloadException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_OrleansTransactionInDoubtException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_OrleansTransactionAbortedException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_OrleansCascadingAbortException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_OrleansOrphanCallException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_OrleansReadOnlyViolatedException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_OrleansTransactionServiceNotAvailableException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_OrleansBrokenTransactionLockException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_OrleansTransactionLockUpgradeException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_OrleansTransactionPrepareTimeoutException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_OrleansTransactionTransientFailureException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.Copier_TransactionalStateRecord<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Transactions.TransactionCommitter.Copier_OperationState<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_TransactionRequestBase));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Copier_TransactionResponse));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Proxy_ITransactionalResourceExtension));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Proxy_ITransactionManagerExtension));
            config.Interfaces.Add(typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension));
            config.Interfaces.Add(typeof(global::Orleans.Transactions.Abstractions.ITransactionManagerExtension));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Transactions.TransactionalResourceExtension));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Transactions.TransactionManagerExtension));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Activator_Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Activator_Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Activator_Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Activator_Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Activator_Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Activator_PendingTransactionState<>));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Activator_TransactionalStorageLoadResponse<>));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Activator_TransactionalStateMetaData));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Activator_CommitRecord));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Activator_Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Activator_Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Activator_Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.ParticipantId.Activator_IdComparer));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Activator_TransactionInfo));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Activator_OrleansTransactionException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Activator_OrleansTransactionsDisabledException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Activator_OrleansTransactionOverloadException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Activator_OrleansTransactionServiceNotAvailableException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.Activator_TransactionalStateRecord<>));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Transactions.TransactionCommitter.Activator_OperationState<>));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Activator_TransactionResponse));
            var n1 = config.CompoundTypeAliases.Add("inv");
            var n2 = n1.Add(typeof(global::Orleans.Runtime.GrainReference));
            var n3 = n2.Add("Ext");
            var n4 = n3.Add(typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension));
            var n5 = n4.Add(typeof(global::Orleans.Transactions.Abstractions.ITransactionalResourceExtension));
            n5.Add("1BB071FE", typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_1BB071FE));
            n5.Add("BD051D23", typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_BD051D23));
            n5.Add("80028AB9", typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_80028AB9));
            n5.Add("5DDDE6F0", typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_5DDDE6F0));
            n5.Add("2ADCC608", typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionalResourceExtension_GrainReference_Ext_2ADCC608));
            var n11 = n3.Add(typeof(global::Orleans.Transactions.Abstractions.ITransactionManagerExtension));
            var n12 = n11.Add(typeof(global::Orleans.Transactions.Abstractions.ITransactionManagerExtension));
            n12.Add("B024EFA6", typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_B024EFA6));
            n12.Add("12BEFA17", typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_12BEFA17));
            n12.Add("AC4A9AEB", typeof(OrleansCodeGen.Orleans.Transactions.Abstractions.Invokable_ITransactionManagerExtension_GrainReference_Ext_AC4A9AEB));
        }
    }
}