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
    public class MsgPack_Serialization_EnumUInt32Serializer : MsgPack.Serialization.EnumMessagePackSerializer<MsgPack.Serialization.EnumUInt32> {
        
        public MsgPack_Serialization_EnumUInt32Serializer(MsgPack.Serialization.SerializationContext context) : 
                this(context, MsgPack.Serialization.EnumSerializationMethod.ByName) {
        }
        
        public MsgPack_Serialization_EnumUInt32Serializer(MsgPack.Serialization.SerializationContext context, MsgPack.Serialization.EnumSerializationMethod enumSerializationMethod) : 
                base(context, enumSerializationMethod) {
        }
        
        protected internal override void PackUnderlyingValueTo(MsgPack.Packer packer, MsgPack.Serialization.EnumUInt32 enumValue) {
            packer.Pack(((uint)(enumValue)));
        }
        
        protected internal override MsgPack.Serialization.EnumUInt32 UnpackFromUnderlyingValue(MsgPack.MessagePackObject messagePackObject) {
            return ((MsgPack.Serialization.EnumUInt32)(messagePackObject.AsUInt32()));
        }
        
        protected internal override System.Threading.Tasks.Task PackUnderlyingValueToAsync(MsgPack.Packer packer, MsgPack.Serialization.EnumUInt32 enumValue, System.Threading.CancellationToken cancellationToken) {
            return packer.PackAsync(((uint)(enumValue)), cancellationToken);
        }
    }
}
