﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8670
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Version> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor> this_PackValueOfReferenceDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor>> _packOperationTable;
        
        private System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor> this_CreateInstanceFromContextDelegate;
        
        private System.Action<UnpackingContext, System.Version> this_SetUnpackedValueOfReferenceDelegate;
        
        private System.Action<MsgPack.Unpacker, UnpackingContext, int, int> this_UnpackValueOfReferenceDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Version>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor>(this.PackValueOfReference);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor>>(1);
            packOperationTable["Reference"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor>(this.PackValueOfReference);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfReference);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>(1);
            unpackOperationTable["Reference"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfReference);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Reference"};
            this.this_PackValueOfReferenceDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor>(this.PackValueOfReference);
            this.this_CreateInstanceFromContextDelegate = new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor>(this.CreateInstanceFromContext);
            this.this_SetUnpackedValueOfReferenceDelegate = new System.Action<UnpackingContext, System.Version>(this.SetUnpackedValueOfReference);
            this.this_UnpackValueOfReferenceDelegate = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfReference);
        }
        
        private void PackValueOfReference(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor objectTree) {
            this._serializer0.PackTo(packer, objectTree.Reference);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor(unpackingContext.Reference);
            return result;
        }
        
        private void SetUnpackedValueOfReference(UnpackingContext unpackingContext, System.Version unpackedValue) {
            unpackingContext.Reference = unpackedValue;
        }
        
        private void UnpackValueOfReference(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Version), "Reference", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfReferenceDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_ReferenceReadOnlyFieldAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            System.Version ctorArg0 = default(System.Version);
            ctorArg0 = null;
            unpackingContext = new UnpackingContext(ctorArg0);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._unpackOperationTable);
            }
        }
        
        public class UnpackingContext {
            
            public System.Version Reference;
            
            public UnpackingContext(System.Version Reference) {
                this.Reference = Reference;
            }
        }
    }
}
