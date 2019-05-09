using System;
using System.Collections.Generic;

namespace ObjectOrientedProgramming.StaticStuff
{
    public class StaticData
    {
        public IEnumerable<UserInfo> GetAllUserInfo()
        {
            return new List<UserInfo>
        {
            new  UserInfo {ID=101,FirstName = "Ibe", LastName = "Batuta",Country="Bangladesh",NID="111222"},
            new  UserInfo {ID=102,FirstName = "Jak", LastName = "Ma",Country="Chiana",NID="999888"},
            new  UserInfo {ID=103,FirstName = "Mark", LastName = "Jukar",Country="USA",NID="777666"},
            new  UserInfo {ID=104,FirstName = "Hilary", LastName = "Duff",Country="UK",NID="4445555"},
            new  UserInfo {ID=105,FirstName = "Shon", LastName = "Tait",Country="AUS",NID="2222888"}
        };
        }
    }
}