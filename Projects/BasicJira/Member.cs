using System;
using System.Collections.Generic;
using System.Text;

namespace BasicJira
{
    public enum MemberRole { PM, Programmer, QA }
    class Member
    {
        private MemberRole role;

        public MemberRole Role { get; }
    }
}
