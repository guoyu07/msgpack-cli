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
    public class MsgPack_Serialization_VersioningTestTargetSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.VersioningTestTarget> {
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget> this_PackValueOfField1Delegate;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget> this_PackValueOfField2Delegate;
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer1;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget> this_PackValueOfField3Delegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>> _packOperationTable;
        
        private System.Action<MsgPack.Serialization.VersioningTestTarget, int> this_SetUnpackedValueOfField1Delegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, int> MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int> this_UnpackValueOfField1Delegate;
        
        private System.Action<MsgPack.Serialization.VersioningTestTarget, int> this_SetUnpackedValueOfField2Delegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int> this_UnpackValueOfField2Delegate;
        
        private System.Action<MsgPack.Serialization.VersioningTestTarget, string> this_SetUnpackedValueOfField3Delegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, string> MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int> this_UnpackValueOfField3Delegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_VersioningTestTargetSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<int>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<string>(schema1);
            System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>[3];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>(this.PackValueOfField1);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>(this.PackValueOfField2);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>(this.PackValueOfField3);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>>(3);
            packOperationTable["Field1"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>(this.PackValueOfField1);
            packOperationTable["Field2"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>(this.PackValueOfField2);
            packOperationTable["Field3"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>(this.PackValueOfField3);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>[3];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>(this.UnpackValueOfField1);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>(this.UnpackValueOfField2);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>(this.UnpackValueOfField3);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>>(3);
            unpackOperationTable["Field1"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>(this.UnpackValueOfField1);
            unpackOperationTable["Field2"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>(this.UnpackValueOfField2);
            unpackOperationTable["Field3"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>(this.UnpackValueOfField3);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Field1",
                    "Field2",
                    "Field3"};
            this.this_PackValueOfField1Delegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>(this.PackValueOfField1);
            this.this_PackValueOfField2Delegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>(this.PackValueOfField2);
            this.this_PackValueOfField3Delegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.VersioningTestTarget>(this.PackValueOfField3);
            this.this_SetUnpackedValueOfField1Delegate = new System.Action<MsgPack.Serialization.VersioningTestTarget, int>(this.SetUnpackedValueOfField1);
            this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, int>(MsgPack.Serialization.UnpackHelpers.UnpackInt32Value);
            this.this_UnpackValueOfField1Delegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>(this.UnpackValueOfField1);
            this.this_SetUnpackedValueOfField2Delegate = new System.Action<MsgPack.Serialization.VersioningTestTarget, int>(this.SetUnpackedValueOfField2);
            this.this_UnpackValueOfField2Delegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>(this.UnpackValueOfField2);
            this.this_SetUnpackedValueOfField3Delegate = new System.Action<MsgPack.Serialization.VersioningTestTarget, string>(this.SetUnpackedValueOfField3);
            this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, string>(MsgPack.Serialization.UnpackHelpers.UnpackStringValue);
            this.this_UnpackValueOfField3Delegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.VersioningTestTarget, int, int>(this.UnpackValueOfField3);
        }
        
        private void PackValueOfField1(MsgPack.Packer packer, MsgPack.Serialization.VersioningTestTarget objectTree) {
            this._serializer0.PackTo(packer, objectTree.Field1);
        }
        
        private void PackValueOfField2(MsgPack.Packer packer, MsgPack.Serialization.VersioningTestTarget objectTree) {
            this._serializer0.PackTo(packer, objectTree.Field2);
        }
        
        private void PackValueOfField3(MsgPack.Packer packer, MsgPack.Serialization.VersioningTestTarget objectTree) {
            this._serializer1.PackTo(packer, objectTree.Field3);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.VersioningTestTarget objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfField1(MsgPack.Serialization.VersioningTestTarget unpackingContext, int unpackedValue) {
            unpackingContext.Field1 = unpackedValue;
        }
        
        private void UnpackValueOfField1(MsgPack.Unpacker unpacker, MsgPack.Serialization.VersioningTestTarget unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(int), "Field1", MsgPack.Serialization.NilImplication.MemberDefault, this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate, this.this_SetUnpackedValueOfField1Delegate);
        }
        
        private void SetUnpackedValueOfField2(MsgPack.Serialization.VersioningTestTarget unpackingContext, int unpackedValue) {
            unpackingContext.Field2 = unpackedValue;
        }
        
        private void UnpackValueOfField2(MsgPack.Unpacker unpacker, MsgPack.Serialization.VersioningTestTarget unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(int), "Field2", MsgPack.Serialization.NilImplication.MemberDefault, this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate, this.this_SetUnpackedValueOfField2Delegate);
        }
        
        private void SetUnpackedValueOfField3(MsgPack.Serialization.VersioningTestTarget unpackingContext, string unpackedValue) {
            unpackingContext.Field3 = unpackedValue;
        }
        
        private void UnpackValueOfField3(MsgPack.Unpacker unpacker, MsgPack.Serialization.VersioningTestTarget unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer1, itemsCount, indexOfItem, typeof(string), "Field3", MsgPack.Serialization.NilImplication.MemberDefault, this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate, this.this_SetUnpackedValueOfField3Delegate);
        }
        
        protected internal override MsgPack.Serialization.VersioningTestTarget UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.VersioningTestTarget result = default(MsgPack.Serialization.VersioningTestTarget);
            result = new MsgPack.Serialization.VersioningTestTarget();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.VersioningTestTarget>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.VersioningTestTarget>(), this._unpackOperationTable);
            }
        }
    }
}
