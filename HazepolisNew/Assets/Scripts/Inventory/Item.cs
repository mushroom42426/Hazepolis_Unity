using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inventory.UI;
using Newtonsoft.Json;

public class Item
{
    public enum ItemTypes { Consumable, Quest}
    public List<BaseStat> Stats { get; set; }
    public string ObjectSlug { get; set; }
    public string Description { get; set; }
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public ItemTypes ItemType { get; set; }
    public string ActionName { get; set; }
    public string ItemName { get; set; }
    public bool ItemModifier { get; set; }

    public Item(List<BaseStat> _Stat, string _ObjectSlug)
    {
        this.Stats = _Stat;
        this.ObjectSlug = _ObjectSlug;
    }

    [Newtonsoft.Json.JsonConstructor]
    public Item(List<BaseStat> _Stat, string _ObjectSlug, string _Description, ItemTypes _ItemTypes, string _ActionName, string _ItemName, bool _ItemModifier)
    {
        this.Stats = _Stat;
        this.ObjectSlug = _ObjectSlug;
        this.Description = _Description;
        this.ItemType = _ItemTypes;
        this.ActionName = _ActionName;
        this.ItemName = _ItemName;
        this.ItemModifier = _ItemModifier;
    }
}
