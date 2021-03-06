﻿using System.Configuration;

namespace ConsoleTest
{
    public class TestConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("TestValue")]
        public string TestValue
        {
            get
            {
                return (string)this["TestValue"];
            }
            set
            {
                this["TestValue"] = value;
            }
        }
    }
}
