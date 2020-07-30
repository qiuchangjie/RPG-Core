﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Station
{
    [CreateAssetMenu]
    public class SoundsDb : DictGenericDatabase<SoundCategory>
    {

        [Serializable] public class ElementDictionary : SerializableDictionary<string, SoundCategory> {}
        [SerializeField] private ElementDictionary _db = new ElementDictionary();
    
        public override IDictionary<string, SoundCategory> Db
        {
            get => _db;
            set => _db.CopyFrom (value);
        }
        
        public override string ObjectName()
        {
            return "Npc";
        }
        
        public override string[] ListEntryNames()
        {
            return _db.Select(entry => entry.Value.CategoryName).ToArray();
        }
    }
}