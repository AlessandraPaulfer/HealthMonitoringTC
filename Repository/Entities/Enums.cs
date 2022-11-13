using System.Runtime.Serialization;

namespace Repository.Entities
{
    public enum Language
    {
        [EnumMember(Value = "pt-BR")]
        pt_BR = 1,
        [EnumMember(Value = "en-US")]
        en_US = 2,
    }

    public enum ChangeOrderPosition
    {
        Before = 1,
        After = 2,
        Inside = 3
    }
    public enum ModuleDomainType
    {
        Erp = 1,
        Sales = 2,
        PatioControl = 3,
        Wms = 4,
    }
    public enum ModuleType
    {
        Item = 1,
        Group = 2,
    }
    public enum ModulePageType
    {
        Page = 1,
        Tab = 2,
    }
    public enum ModulePermission
    {
        See = 1,
        Edit = 2,
        Hide = 3
    }
}
