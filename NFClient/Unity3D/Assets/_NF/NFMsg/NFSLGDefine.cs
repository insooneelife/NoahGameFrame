//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: NFSLGDefine.proto
// Note: requires additional types generated from: NFMsgBase.proto
namespace NFMsg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqAckBuyObjectFormShop")]
  public partial class ReqAckBuyObjectFormShop : global::ProtoBuf.IExtensible
  {
    public ReqAckBuyObjectFormShop() {}
    
    private string _config_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"config_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string config_id
    {
      get { return _config_id; }
      set { _config_id = value; }
    }
    private float _x;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private float _z;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float z
    {
      get { return _z; }
      set { _z = value; }
    }
    private string _Shop_id;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Shop_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Shop_id
    {
      get { return _Shop_id; }
      set { _Shop_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqAckMoveBuildObject")]
  public partial class ReqAckMoveBuildObject : global::ProtoBuf.IExtensible
  {
    public ReqAckMoveBuildObject() {}
    
    private int _row = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"row", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int row
    {
      get { return _row; }
      set { _row = value; }
    }
    private NFMsg.Ident _object_guid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"object_guid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident object_guid
    {
      get { return _object_guid; }
      set { _object_guid = value; }
    }
    private float _x;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private float _z;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float z
    {
      get { return _z; }
      set { _z = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqUpBuildLv")]
  public partial class ReqUpBuildLv : global::ProtoBuf.IExtensible
  {
    public ReqUpBuildLv() {}
    
    private int _row = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"row", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int row
    {
      get { return _row; }
      set { _row = value; }
    }
    private NFMsg.Ident _object_guid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"object_guid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident object_guid
    {
      get { return _object_guid; }
      set { _object_guid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqCreateItem")]
  public partial class ReqCreateItem : global::ProtoBuf.IExtensible
  {
    public ReqCreateItem() {}
    
    private int _row = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"row", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int row
    {
      get { return _row; }
      set { _row = value; }
    }
    private NFMsg.Ident _object_guid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"object_guid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident object_guid
    {
      get { return _object_guid; }
      set { _object_guid = value; }
    }
    private string _config_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"config_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string config_id
    {
      get { return _config_id; }
      set { _config_id = value; }
    }
    private int _count;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int count
    {
      get { return _count; }
      set { _count = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqBuildOperate")]
  public partial class ReqBuildOperate : global::ProtoBuf.IExtensible
  {
    public ReqBuildOperate() {}
    
    private int _row = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"row", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int row
    {
      get { return _row; }
      set { _row = value; }
    }
    private NFMsg.Ident _object_guid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"object_guid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident object_guid
    {
      get { return _object_guid; }
      set { _object_guid = value; }
    }
    private NFMsg.ESLGFuncType _functype;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"functype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public NFMsg.ESLGFuncType functype
    {
      get { return _functype; }
      set { _functype = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"ESLGBuildingType")]
    public enum ESLGBuildingType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBT_BASE", Value=0)]
      EBT_BASE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBT_DEFENSE", Value=1)]
      EBT_DEFENSE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBT_ARMY", Value=2)]
      EBT_ARMY = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBT_RESOURCE", Value=3)]
      EBT_RESOURCE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBT_GUILD", Value=4)]
      EBT_GUILD = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBT_TEMPLE", Value=5)]
      EBT_TEMPLE = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBT_NUCLEAR", Value=6)]
      EBT_NUCLEAR = 6
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ESLGBuildingSubType")]
    public enum ESLGBuildingSubType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_HALL", Value=0)]
      EBST_HALL = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_MASHROOM", Value=70)]
      EBST_MASHROOM = 70,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_BUSH", Value=71)]
      EBST_BUSH = 71,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_BRANCH_1", Value=72)]
      EBST_BRANCH_1 = 72,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_BRANCH_2", Value=73)]
      EBST_BRANCH_2 = 73,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_BRANCH_3", Value=74)]
      EBST_BRANCH_3 = 74,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_TREE_1", Value=75)]
      EBST_TREE_1 = 75,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_TREE_2", Value=76)]
      EBST_TREE_2 = 76,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_TREE_3", Value=77)]
      EBST_TREE_3 = 77,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_STONE_1", Value=78)]
      EBST_STONE_1 = 78,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_STONE_2", Value=79)]
      EBST_STONE_2 = 79,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_STONE_3", Value=80)]
      EBST_STONE_3 = 80,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_TOMB", Value=81)]
      EBST_TOMB = 81,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_DARK_TOMB", Value=82)]
      EBST_DARK_TOMB = 82,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_PYXIS", Value=83)]
      EBST_PYXIS = 83,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_TORCH", Value=84)]
      EBST_TORCH = 84,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST__WHITE_FLAG", Value=85)]
      EBST__WHITE_FLAG = 85,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_CANNON", Value=101)]
      EBST_CANNON = 101,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_MORTAR", Value=102)]
      EBST_MORTAR = 102,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_ARCHER_TOWER", Value=103)]
      EBST_ARCHER_TOWER = 103,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_WIZARD_TOWER", Value=104)]
      EBST_WIZARD_TOWER = 104,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_AIR_TOWER", Value=105)]
      EBST_AIR_TOWER = 105,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_TESLA_TOWER", Value=106)]
      EBST_TESLA_TOWER = 106,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_WALL", Value=107)]
      EBST_WALL = 107,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_X_BOW", Value=108)]
      EBST_X_BOW = 108,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_BOMB", Value=109)]
      EBST_BOMB = 109,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_AIR_BOMB", Value=110)]
      EBST_AIR_BOMB = 110,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_SPRING_TRAP", Value=111)]
      EBST_SPRING_TRAP = 111,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_HELL_TOWER", Value=112)]
      EBST_HELL_TOWER = 112,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_CAMP", Value=200)]
      EBST_CAMP = 200,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_BARRACK", Value=201)]
      EBST_BARRACK = 201,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_TEC_FACTORY", Value=202)]
      EBST_TEC_FACTORY = 202,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_DARK_BARRACK", Value=203)]
      EBST_DARK_BARRACK = 203,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_DRUG_FACTORY", Value=204)]
      EBST_DRUG_FACTORY = 204,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_KING_ALTAR", Value=205)]
      EBST_KING_ALTAR = 205,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_QUEEN_ALTAR", Value=206)]
      EBST_QUEEN_ALTAR = 206,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_GOLD_COLLECTOR", Value=300)]
      EBST_GOLD_COLLECTOR = 300,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_GOLD_STORAGE", Value=301)]
      EBST_GOLD_STORAGE = 301,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_STONE_COLLECTOR", Value=302)]
      EBST_STONE_COLLECTOR = 302,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_STONE_STORAGE", Value=303)]
      EBST_STONE_STORAGE = 303,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_STEEL_COLLECTOR", Value=304)]
      EBST_STEEL_COLLECTOR = 304,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_STEEL_STORAGE", Value=305)]
      EBST_STEEL_STORAGE = 305,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_DIAMOND_COLLECTOR", Value=306)]
      EBST_DIAMOND_COLLECTOR = 306,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_DIAMOND_STORAGE", Value=307)]
      EBST_DIAMOND_STORAGE = 307,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_HUT", Value=308)]
      EBST_HUT = 308,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_GUILD_CASTLE", Value=400)]
      EBST_GUILD_CASTLE = 400,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_GUILD_CRYPT", Value=401)]
      EBST_GUILD_CRYPT = 401,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_ELEMENT_LAB", Value=500)]
      EBST_ELEMENT_LAB = 500,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBST_NUCLEAR_FACTORY", Value=600)]
      EBST_NUCLEAR_FACTORY = 600
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ESLGArmyType")]
    public enum ESLGArmyType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EAT_FOOTMAN", Value=0)]
      EAT_FOOTMAN = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EAT_ARCHER", Value=1)]
      EAT_ARCHER = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EAT_GOBLIN", Value=2)]
      EAT_GOBLIN = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EAT_GIANT", Value=3)]
      EAT_GIANT = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EAT_WALL_BREAKER", Value=4)]
      EAT_WALL_BREAKER = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EAT_BALLOON", Value=5)]
      EAT_BALLOON = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EAT_HEALER", Value=6)]
      EAT_HEALER = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EAT_WIZARD", Value=7)]
      EAT_WIZARD = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EAT_DRAGON", Value=8)]
      EAT_DRAGON = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EAT_PEKKA", Value=9)]
      EAT_PEKKA = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EAT_MINION", Value=20)]
      EAT_MINION = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EAT_HOG_RIDER", Value=21)]
      EAT_HOG_RIDER = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EAT_VALKYRIE", Value=22)]
      EAT_VALKYRIE = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EAT_GOLEM", Value=23)]
      EAT_GOLEM = 23
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ESLGFuncType")]
    public enum ESLGFuncType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFT_INFO", Value=0)]
      EFT_INFO = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFT_BOOOST", Value=1)]
      EFT_BOOOST = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFT_LVLUP", Value=2)]
      EFT_LVLUP = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFT_CREATE_SOLDER", Value=3)]
      EFT_CREATE_SOLDER = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFT_CREATE_SPEEL", Value=4)]
      EFT_CREATE_SPEEL = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFT_RESEARCH", Value=5)]
      EFT_RESEARCH = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFT_COLLECT_GOLD", Value=6)]
      EFT_COLLECT_GOLD = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFT_COLLECT_STONE", Value=7)]
      EFT_COLLECT_STONE = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFT_COLLECT_STEEL", Value=8)]
      EFT_COLLECT_STEEL = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFT_COLLECT_DIAMOND", Value=9)]
      EFT_COLLECT_DIAMOND = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFT_SELL", Value=10)]
      EFT_SELL = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFT_REPAIR", Value=11)]
      EFT_REPAIR = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFT_CANCEL", Value=12)]
      EFT_CANCEL = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EFT_FINISH", Value=13)]
      EFT_FINISH = 13
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ESLGBuildingState")]
    public enum ESLGBuildingState
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBS_IDLE", Value=0)]
      EBS_IDLE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBS_BOOST", Value=1)]
      EBS_BOOST = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBS_UPGRADE", Value=2)]
      EBS_UPGRADE = 2
    }
  
}