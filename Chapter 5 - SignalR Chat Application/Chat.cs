using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter5
{
    public class Chat:Hub
    {
        public Task Send(string sender, string message)
        {
            return Clients.All.InvokeAsync("UpdateChat", sender, message);
        }

        public Task ArchiveChat(string archivedBy, string path, string messages)
        {
            string fileName = "ChatArchive_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm") + ".txt";
            System.IO.File.WriteAllText(path + "\\" + fileName, messages);
            return Clients.All.InvokeAsync("Archived", "Chat archived by "+ archivedBy);
        }
    }
}
