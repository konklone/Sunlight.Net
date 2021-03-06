﻿using System;
using System.Collections.Generic;

namespace SunlightAPI.Congress
{
    public class Legislator
    {
        public string bioguide_id { get; set; }
        public DateTime birthday { get; set; }
        public string chamber { get; set; }
        public string contact_form { get; set; }
        public string crp_id { get; set; }
        public int? district { get; set; }
        public string facebook_id { get; set; }
        public string fax { get; set; }
        public List<string> fec_ids { get; set; }
        public string first_name { get; set; }
        public string gender { get; set; }
        public string govtrack_id { get; set; }
        public int icpsr_id { get; set; }
        public bool in_office { get; set; }
        public string last_name { get; set; }
        public string middle_name { get; set; }
        public string name_suffix { get; set; }
        public string nickname { get; set; }
        public string ocd_id { get; set; }
        public string office { get; set; }
        public string party { get; set; }
        public string phone { get; set; }
        public string state { get; set; }
        public string state_name { get; set; }
        public DateTime? term_end { get; set; }
        public DateTime? term_start { get; set; }
        public string thomas_id { get; set; }
        public string title { get; set; }
        public string twitter_id { get; set; }
        public int votesmart_id { get; set; }
        public string website { get; set; }
        public string youtube_id { get; set; }
    }
}
