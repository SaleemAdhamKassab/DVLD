using DVLD_DataAccess;
using Sahred.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class ApplicationType
    {
        public byte Id { get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }


        public static ApplicationTypeDto get(byte id) => ApplicationTypeData.get(id);

        public static DataTable get() => ApplicationTypeData.get();

        public static bool put(ApplicationTypeDto applicationTypeDto) => ApplicationTypeData.put(applicationTypeDto);
    }
}
