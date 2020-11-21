﻿/**
 * Copyright (C) 2020 Kamarudin (http://coding4ever.net/)
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 *
 * The latest version of this file can be found at https://github.com/k4m4r82/OnlineTestWABot
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Dapper.Contrib.Extensions;

namespace OnlineTestWABot.Model.Entity
{
    [Table("sesi")]
    public class Sesi
    {
        public Sesi()
        {
            tanggal = DateTime.Now;
        }

        [Key]
        public int sesi_id { get; set; }
        public string user_id { get; set; }
        public DateTime tanggal { get; set; }
        public bool is_timeout { get; set; }
    }
}
