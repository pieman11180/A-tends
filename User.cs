using System;
using System.Collections.Generic;
using System.Text;

namespace A__endance
{
    abstract class User
    {
        protected int ID;
        protected String name;

        public User()
        {
            this.ID = 0;
            this.name = "";
        }

        public User(int id, String Name){
            this.ID = id;
            this.name = Name;
        }

        public int getID() { return ID; }
        public String getName() { return name; }
    }
}
