using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Primera.NETyApp
{
    public class DownloadService
    {
        public byte[] Download(string songName)
        {
            Thread.Sleep(1000);
            return new byte[] { };
        }

        public Task <byte[]> DownloadAsync(string songName)
        {
            Thread.Sleep(1000);
            return Task.FromResult(new byte[] {});
        }
    }
}
