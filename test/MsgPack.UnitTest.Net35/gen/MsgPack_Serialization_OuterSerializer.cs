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
    public class MsgPack_Serialization_OuterSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.Outer> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.Outer> this_PackValueOfADelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.Inner> _serializer1;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.Outer> this_PackValueOfInnerDelegate;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.Outer> this_PackValueOfODelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>> _packOperationTable;
        
        private System.Action<MsgPack.Serialization.Outer, string> this_SetUnpackedValueOfADelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, string> MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int> this_UnpackValueOfADelegate;
        
        private System.Action<MsgPack.Serialization.Outer, MsgPack.Serialization.Inner> this_SetUnpackedValueOfInnerDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int> this_UnpackValueOfInnerDelegate;
        
        private System.Action<MsgPack.Serialization.Outer, string> this_SetUnpackedValueOfODelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int> this_UnpackValueOfODelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_OuterSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<MsgPack.Serialization.Inner>(schema1);
            System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>[3];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>(this.PackValueOfA);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>(this.PackValueOfInner);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>(this.PackValueOfO);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>>(3);
            packOperationTable["A"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>(this.PackValueOfA);
            packOperationTable["Inner"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>(this.PackValueOfInner);
            packOperationTable["O"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>(this.PackValueOfO);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>[3];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>(this.UnpackValueOfA);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>(this.UnpackValueOfInner);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>(this.UnpackValueOfO);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>>(3);
            unpackOperationTable["A"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>(this.UnpackValueOfA);
            unpackOperationTable["Inner"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>(this.UnpackValueOfInner);
            unpackOperationTable["O"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>(this.UnpackValueOfO);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "A",
                    "Inner",
                    "O"};
            this.this_PackValueOfADelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>(this.PackValueOfA);
            this.this_PackValueOfInnerDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>(this.PackValueOfInner);
            this.this_PackValueOfODelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>(this.PackValueOfO);
            this.this_SetUnpackedValueOfADelegate = new System.Action<MsgPack.Serialization.Outer, string>(this.SetUnpackedValueOfA);
            this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, string>(MsgPack.Serialization.UnpackHelpers.UnpackStringValue);
            this.this_UnpackValueOfADelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>(this.UnpackValueOfA);
            this.this_SetUnpackedValueOfInnerDelegate = new System.Action<MsgPack.Serialization.Outer, MsgPack.Serialization.Inner>(this.SetUnpackedValueOfInner);
            this.this_UnpackValueOfInnerDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>(this.UnpackValueOfInner);
            this.this_SetUnpackedValueOfODelegate = new System.Action<MsgPack.Serialization.Outer, string>(this.SetUnpackedValueOfO);
            this.this_UnpackValueOfODelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>(this.UnpackValueOfO);
        }
        
        private void PackValueOfA(MsgPack.Packer packer, MsgPack.Serialization.Outer objectTree) {
            this._serializer0.PackTo(packer, objectTree.A);
        }
        
        private void PackValueOfInner(MsgPack.Packer packer, MsgPack.Serialization.Outer objectTree) {
            this._serializer1.PackTo(packer, objectTree.Inner);
        }
        
        private void PackValueOfO(MsgPack.Packer packer, MsgPack.Serialization.Outer objectTree) {
            this._serializer0.PackTo(packer, objectTree.O);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.Outer objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfA(MsgPack.Serialization.Outer unpackingContext, string unpackedValue) {
            unpackingContext.A = unpackedValue;
        }
        
        private void UnpackValueOfA(MsgPack.Unpacker unpacker, MsgPack.Serialization.Outer unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(string), "A", MsgPack.Serialization.NilImplication.MemberDefault, this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate, this.this_SetUnpackedValueOfADelegate);
        }
        
        private void SetUnpackedValueOfInner(MsgPack.Serialization.Outer unpackingContext, MsgPack.Serialization.Inner unpackedValue) {
            unpackingContext.Inner = unpackedValue;
        }
        
        private void UnpackValueOfInner(MsgPack.Unpacker unpacker, MsgPack.Serialization.Outer unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer1, itemsCount, indexOfItem, typeof(MsgPack.Serialization.Inner), "Inner", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfInnerDelegate);
        }
        
        private void SetUnpackedValueOfO(MsgPack.Serialization.Outer unpackingContext, string unpackedValue) {
            unpackingContext.O = unpackedValue;
        }
        
        private void UnpackValueOfO(MsgPack.Unpacker unpacker, MsgPack.Serialization.Outer unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(string), "O", MsgPack.Serialization.NilImplication.MemberDefault, this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate, this.this_SetUnpackedValueOfODelegate);
        }
        
        protected internal override MsgPack.Serialization.Outer UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.Outer result = default(MsgPack.Serialization.Outer);
            result = new MsgPack.Serialization.Outer();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.Outer>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.Outer>(), this._unpackOperationTable);
            }
        }
    }
}
