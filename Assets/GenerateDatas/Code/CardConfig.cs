
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg
{
public sealed partial class CardConfig : Luban.BeanBase
{
    public CardConfig(JSONNode _buf) 
    {
        { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
        { if(!_buf["CardName"].IsString) { throw new SerializationException(); }  CardName = _buf["CardName"]; }
        { if(!_buf["describe"].IsString) { throw new SerializationException(); }  Describe = _buf["describe"]; }
        { if(!_buf["imgPath"].IsString) { throw new SerializationException(); }  ImgPath = _buf["imgPath"]; }
        { if(!_buf["cardType"].IsNumber) { throw new SerializationException(); }  CardType = (CardTypeConfig.CardTypeEnum)_buf["cardType"].AsInt; }
        { var __json0 = _buf["affordableElems"]; if(!__json0.IsArray) { throw new SerializationException(); } AffordableElems = new System.Collections.Generic.List<ElemTypeConfig.ElemTypeEnum>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { ElemTypeConfig.ElemTypeEnum __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = (ElemTypeConfig.ElemTypeEnum)__e0.AsInt; }  AffordableElems.Add(__v0); }   }
        { var __json0 = _buf["neededElems"]; if(!__json0.IsArray) { throw new SerializationException(); } NeededElems = new System.Collections.Generic.List<ElemTypeConfig.ElemTypeEnum>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { ElemTypeConfig.ElemTypeEnum __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = (ElemTypeConfig.ElemTypeEnum)__e0.AsInt; }  NeededElems.Add(__v0); }   }
    }

    public static CardConfig DeserializeCardConfig(JSONNode _buf)
    {
        return new CardConfig(_buf);
    }

    /// <summary>
    /// Id
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 名称
    /// </summary>
    public readonly string CardName;
    /// <summary>
    /// 卡牌描述
    /// </summary>
    public readonly string Describe;
    /// <summary>
    /// 图片路径
    /// </summary>
    public readonly string ImgPath;
    /// <summary>
    /// 卡牌类型
    /// </summary>
    public readonly CardTypeConfig.CardTypeEnum CardType;
    /// <summary>
    /// 提供元素
    /// </summary>
    public readonly System.Collections.Generic.List<ElemTypeConfig.ElemTypeEnum> AffordableElems;
    /// <summary>
    /// 需要元素
    /// </summary>
    public readonly System.Collections.Generic.List<ElemTypeConfig.ElemTypeEnum> NeededElems;
   
    public const int __ID__ = -2113914222;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        
        
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "CardName:" + CardName + ","
        + "describe:" + Describe + ","
        + "imgPath:" + ImgPath + ","
        + "cardType:" + CardType + ","
        + "affordableElems:" + Luban.StringUtil.CollectionToString(AffordableElems) + ","
        + "neededElems:" + Luban.StringUtil.CollectionToString(NeededElems) + ","
        + "}";
    }
}

}