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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Normal_ValueReadWritePropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty> this_PackValueOfValueDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty>> _packOperationTable;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfValueAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, System.DateTime> this_SetUnpackedValueOfValueDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int> this_UnpackValueOfValueDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int>> _unpackOperationTable;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfValueAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Normal_ValueReadWritePropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            this._serializer0 = context.GetSerializer<System.DateTime>(MsgPack.Serialization.DateTimeMessagePackSerializerHelpers.DetermineDateTimeConversionMethod(context, MsgPack.Serialization.DateTimeMemberConversionMethod.Default));
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty>(this.PackValueOfValue);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfValueAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty>>(1);
            packOperationTable["Value"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty>(this.PackValueOfValue);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["Value"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfValueAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int>(this.UnpackValueOfValue);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfValueAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int>>(1);
            unpackOperationTable["Value"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int>(this.UnpackValueOfValue);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["Value"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfValueAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "Value"};
            this.this_PackValueOfValueDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty>(this.PackValueOfValue);
            this.this_PackValueOfValueAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfValueAsync);
            this.this_SetUnpackedValueOfValueDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, System.DateTime>(this.SetUnpackedValueOfValue);
            this.this_UnpackValueOfValueDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int>(this.UnpackValueOfValue);
            this.this_UnpackValueOfValueAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfValueAsync);
        }
        
        private void PackValueOfValue(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.Value);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task PackValueOfValueAsync(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.Value, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty objectTree, System.Threading.CancellationToken cancellationToken) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                return MsgPack.Serialization.PackHelpers.PackToArrayAsync(packer, objectTree, this._packOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.PackHelpers.PackToMapAsync(packer, objectTree, this._packOperationTableAsync, cancellationToken);
            }
        }
        
        private void SetUnpackedValueOfValue(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty unpackingContext, System.DateTime unpackedValue) {
            unpackingContext.Value = unpackedValue;
        }
        
        private void UnpackValueOfValue(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.DateTime), "Value", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfValueDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfValueAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValueAsync(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.DateTime), "Value", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfValueDelegate, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ValueReadWriteProperty>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
