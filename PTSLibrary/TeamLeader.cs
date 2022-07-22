﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    [Serializable]
    public class TeamLeader : User
    {
        public TeamLeader() { }

        private int teamId;

        public int TeamId
        {
            get { return teamId; }
            set { teamId = value; }
        }
        public TeamLeader(string name, int id, int teamId)
        {
            this.name = name;
            this.id = id;
            this.teamId = teamId;
        }
    }
}
