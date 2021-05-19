using System;

namespace RaidManager.Domain.Dto
{
    public class User : DtoBase
    {
        public string UserName { get; set; }
        public DateTime CreationDate { get; set; }
    }
}