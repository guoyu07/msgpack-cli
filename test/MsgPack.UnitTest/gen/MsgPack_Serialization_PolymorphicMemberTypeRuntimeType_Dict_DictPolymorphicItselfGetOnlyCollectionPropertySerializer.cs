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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionPropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<string, string>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty> this_PackValueOfDictPolymorphicItselfDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty>> _packOperationTable;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfDictPolymorphicItselfAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, System.Collections.Generic.IDictionary<string, string>> this_SetUnpackedValueOfDictPolymorphicItselfDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int> this_UnpackValueOfDictPolymorphicItselfDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int>> _unpackOperationTable;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfDictPolymorphicItselfAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionPropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicDictionary(typeof(System.Collections.Generic.IDictionary<string, string>), null, null);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<string, string>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty>(this.PackValueOfDictPolymorphicItself);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDictPolymorphicItselfAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty>>(1);
            packOperationTable["DictPolymorphicItself"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty>(this.PackValueOfDictPolymorphicItself);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["DictPolymorphicItself"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDictPolymorphicItselfAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int>(this.UnpackValueOfDictPolymorphicItself);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDictPolymorphicItselfAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int>>(1);
            unpackOperationTable["DictPolymorphicItself"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int>(this.UnpackValueOfDictPolymorphicItself);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["DictPolymorphicItself"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDictPolymorphicItselfAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "DictPolymorphicItself"};
            this.this_PackValueOfDictPolymorphicItselfDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty>(this.PackValueOfDictPolymorphicItself);
            this.this_PackValueOfDictPolymorphicItselfAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDictPolymorphicItselfAsync);
            this.this_SetUnpackedValueOfDictPolymorphicItselfDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, System.Collections.Generic.IDictionary<string, string>>(this.SetUnpackedValueOfDictPolymorphicItself);
            this.this_UnpackValueOfDictPolymorphicItselfDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int>(this.UnpackValueOfDictPolymorphicItself);
            this.this_UnpackValueOfDictPolymorphicItselfAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDictPolymorphicItselfAsync);
        }
        
        private void PackValueOfDictPolymorphicItself(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictPolymorphicItself);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task PackValueOfDictPolymorphicItselfAsync(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.DictPolymorphicItself, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty objectTree, System.Threading.CancellationToken cancellationToken) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                return MsgPack.Serialization.PackHelpers.PackToArrayAsync(packer, objectTree, this._packOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.PackHelpers.PackToMapAsync(packer, objectTree, this._packOperationTableAsync, cancellationToken);
            }
        }
        
        private void SetUnpackedValueOfDictPolymorphicItself(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty unpackingContext, System.Collections.Generic.IDictionary<string, string> unpackedValue) {
            System.Collections.Generic.IDictionary<string, string> existent = default(System.Collections.Generic.IDictionary<string, string>);
            existent = unpackingContext.DictPolymorphicItself;
            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> enumerator = unpackedValue.GetEnumerator();
            System.Collections.Generic.KeyValuePair<string, string> current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    existent.Add(current.Key, current.Value);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfDictPolymorphicItself(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.IDictionary<string, string>), "DictPolymorphicItself", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfDictPolymorphicItselfDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfDictPolymorphicItselfAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.IDictionary<string, string>), "DictPolymorphicItself", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfDictPolymorphicItselfDelegate, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfGetOnlyCollectionProperty>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
