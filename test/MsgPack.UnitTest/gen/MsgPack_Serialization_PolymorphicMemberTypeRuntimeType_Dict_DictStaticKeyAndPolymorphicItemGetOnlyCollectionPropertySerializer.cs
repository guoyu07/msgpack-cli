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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionPropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty> this_PackValueOfDictStaticKeyAndPolymorphicItemDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty>> _packOperationTable;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfDictStaticKeyAndPolymorphicItemAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>> this_SetUnpackedValueOfDictStaticKeyAndPolymorphicItemDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int> this_UnpackValueOfDictStaticKeyAndPolymorphicItemDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int>> _unpackOperationTable;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfDictStaticKeyAndPolymorphicItemAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionPropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema valuesSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            valuesSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedDictionary(typeof(System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>), null, valuesSchema0);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty>(this.PackValueOfDictStaticKeyAndPolymorphicItem);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDictStaticKeyAndPolymorphicItemAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty>>(1);
            packOperationTable["DictStaticKeyAndPolymorphicItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty>(this.PackValueOfDictStaticKeyAndPolymorphicItem);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["DictStaticKeyAndPolymorphicItem"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDictStaticKeyAndPolymorphicItemAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int>(this.UnpackValueOfDictStaticKeyAndPolymorphicItem);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDictStaticKeyAndPolymorphicItemAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int>>(1);
            unpackOperationTable["DictStaticKeyAndPolymorphicItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int>(this.UnpackValueOfDictStaticKeyAndPolymorphicItem);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["DictStaticKeyAndPolymorphicItem"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDictStaticKeyAndPolymorphicItemAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "DictStaticKeyAndPolymorphicItem"};
            this.this_PackValueOfDictStaticKeyAndPolymorphicItemDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty>(this.PackValueOfDictStaticKeyAndPolymorphicItem);
            this.this_PackValueOfDictStaticKeyAndPolymorphicItemAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDictStaticKeyAndPolymorphicItemAsync);
            this.this_SetUnpackedValueOfDictStaticKeyAndPolymorphicItemDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>>(this.SetUnpackedValueOfDictStaticKeyAndPolymorphicItem);
            this.this_UnpackValueOfDictStaticKeyAndPolymorphicItemDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int>(this.UnpackValueOfDictStaticKeyAndPolymorphicItem);
            this.this_UnpackValueOfDictStaticKeyAndPolymorphicItemAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDictStaticKeyAndPolymorphicItemAsync);
        }
        
        private void PackValueOfDictStaticKeyAndPolymorphicItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictStaticKeyAndPolymorphicItem);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task PackValueOfDictStaticKeyAndPolymorphicItemAsync(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.DictStaticKeyAndPolymorphicItem, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty objectTree, System.Threading.CancellationToken cancellationToken) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                return MsgPack.Serialization.PackHelpers.PackToArrayAsync(packer, objectTree, this._packOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.PackHelpers.PackToMapAsync(packer, objectTree, this._packOperationTableAsync, cancellationToken);
            }
        }
        
        private void SetUnpackedValueOfDictStaticKeyAndPolymorphicItem(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty unpackingContext, System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry> unpackedValue) {
            System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry> existent = default(System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>);
            existent = unpackingContext.DictStaticKeyAndPolymorphicItem;
            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, MsgPack.Serialization.FileSystemEntry>> enumerator = unpackedValue.GetEnumerator();
            System.Collections.Generic.KeyValuePair<string, MsgPack.Serialization.FileSystemEntry> current;
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
        
        private void UnpackValueOfDictStaticKeyAndPolymorphicItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>), "DictStaticKeyAndPolymorphicItem", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfDictStaticKeyAndPolymorphicItemDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfDictStaticKeyAndPolymorphicItemAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>), "DictStaticKeyAndPolymorphicItem", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfDictStaticKeyAndPolymorphicItemDelegate, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
