﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObjectSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject> {
        
        private MsgPack.Serialization.MessagePackSerializer<object> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject> this_PackValueOfStringDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>> _packOperationTable;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfStringAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject> this_CreateInstanceFromContextDelegate;
        
        private System.Action<UnpackingContext, object> this_SetUnpackedValueOfStringDelegate;
        
        private System.Action<MsgPack.Unpacker, UnpackingContext, int, int> this_UnpackValueOfStringDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationTable;
        
        private System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfStringAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObjectSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<object>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>(this.PackValueOfString);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfStringAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>>(1);
            packOperationTable["String"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>(this.PackValueOfString);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["String"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfStringAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfString);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfStringAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>(1);
            unpackOperationTable["String"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfString);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["String"] = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfStringAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "String"};
            this.this_PackValueOfStringDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>(this.PackValueOfString);
            this.this_PackValueOfStringAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfStringAsync);
            this.this_CreateInstanceFromContextDelegate = new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject>(this.CreateInstanceFromContext);
            this.this_SetUnpackedValueOfStringDelegate = new System.Action<UnpackingContext, object>(this.SetUnpackedValueOfString);
            this.this_UnpackValueOfStringDelegate = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfString);
            this.this_UnpackValueOfStringAsyncDelegate = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfStringAsync);
        }
        
        private void PackValueOfString(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject objectTree) {
            this._serializer0.PackTo(packer, objectTree.String);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task PackValueOfStringAsync(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.String, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject objectTree, System.Threading.CancellationToken cancellationToken) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                return MsgPack.Serialization.PackHelpers.PackToArrayAsync(packer, objectTree, this._packOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.PackHelpers.PackToMapAsync(packer, objectTree, this._packOperationTableAsync, cancellationToken);
            }
        }
        
        private MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject(unpackingContext.String);
            return result;
        }
        
        private void SetUnpackedValueOfString(UnpackingContext unpackingContext, object unpackedValue) {
            unpackingContext.String = unpackedValue;
        }
        
        private void UnpackValueOfString(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(object), "String", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfStringDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            object ctorArg0 = default(object);
            ctorArg0 = null;
            unpackingContext = new UnpackingContext(ctorArg0);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfStringAsync(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(object), "String", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfStringDelegate, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringGetOnlyPropertyAndConstructorAsObject> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            object ctorArg0 = default(object);
            ctorArg0 = null;
            unpackingContext = new UnpackingContext(ctorArg0);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._unpackOperationTableAsync, cancellationToken);
            }
        }
        
        public class UnpackingContext {
            
            public object String;
            
            public UnpackingContext(object String) {
                this.String = String;
            }
        }
    }
}
