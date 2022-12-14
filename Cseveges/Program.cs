using System.Text;

namespace Cseveges {
    internal class Program {
        static void Main(string[] args)
        {
            List<Beszelgetes> calls = new List<Beszelgetes>();
            List<string> members = new List<string>();
            // 3. feladat
            StreamReader sr = new StreamReader("./csevegesek.txt", Encoding.UTF8);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                calls.Add(new Beszelgetes(sr.ReadLine()));
            }
            sr.Close();

            sr = new StreamReader("./tagok.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                members.Add(sr.ReadLine());
            }
            sr.Close();

            // 4. feladat
            Console.WriteLine($"4. feladat: Tagok száma: {members.Count}fő - Beszélgetések: {calls.Count}db");

            // 5. feladat

            TimeSpan longestCall = calls[0].end - calls[0].begin;
            int longestCallIndex = 0;
            for (int i = 1; i < calls.Count; i++)
            {
                if (calls[i].end - calls[i].begin > longestCall)
                {
                    longestCall = calls[i].end - calls[i].begin;
                    longestCallIndex = i;
                }
            }
            Console.WriteLine($"5. feladat: Leghosszabb beszélegetés adatai" +
                $"\n\tKezdeményező: {calls[longestCallIndex].callerName}" +
                $"\n\tFogadó: {calls[longestCallIndex].calledName}" +
                $"\n\tKezdete: {calls[longestCallIndex].begin}" +
                $"\n\tVége: {calls[longestCallIndex].end}" +
                $"\n\tHossz {longestCall.TotalSeconds}mp");

            // 6. feladat
            Console.Write("6. feladat: Adja meg egy tag nevét: ");
            string name = Console.ReadLine().ToLower();
            TimeSpan callsTime = new TimeSpan();
            foreach (var call in calls)
            {
                if (name == call.callerName.ToLower() || name == call.calledName.ToLower())
                {
                    callsTime += call.end - call.begin;
                }
            }
            Console.WriteLine($"\tA beszélgetések összes ideje: {callsTime.Hours}:{callsTime.Minutes}:{callsTime.Seconds} ");
            
            // 7. feladat
            Console.WriteLine("7. feladat: Nem beszélgettek senkivel");
            Dictionary<string, TimeSpan> memberCalls = new Dictionary<string, TimeSpan>();

            for (int i = 0; i < members.Count; i++)
            {
                for (int j = 0; j < calls.Count; j++)
                {
                    if (members[i] == calls[j].callerName ||members[i] == calls[j].calledName)
                    {

                        if (!memberCalls.ContainsKey(members[i]))
                            memberCalls.Add(members[i], calls[j].end - calls[j].begin);

                        else
                            memberCalls[members[i]] += calls[j].end - calls[j].begin;
                    }
                }

                if (!memberCalls.ContainsKey(members[i]))
                    Console.WriteLine($"\t{members[i]}");
            }

            // 8. feladat
            DateTime maxSilenceBegin = new DateTime(2021, 9, 27, 15, 0, 0);
            DateTime maxSilenceEnd = calls[0].begin;
            DateTime currentSilenceEnd = calls[0].end;
            TimeSpan maxSilenceLength = maxSilenceEnd - maxSilenceBegin;

            foreach (var call in calls.Skip(1))
            {
                if (call.begin > currentSilenceEnd) { 
                    TimeSpan currentSilence = call.begin - currentSilenceEnd;
                    if (currentSilence > maxSilenceLength)
                    {
                        maxSilenceLength = currentSilence;
                        maxSilenceBegin = currentSilenceEnd;
                        maxSilenceEnd = call.begin;
                    }
                }
                if (call.end > currentSilenceEnd) currentSilenceEnd = call.end;
            }

            Console.WriteLine($"8. feladat: Leghosszabb csendes időszak 15h-tól" +
                $"\n\tKezdete: {maxSilenceBegin}" +
                $"\n\tVége: {maxSilenceEnd}" +
                $"\n\tHossza: {maxSilenceLength}");

        }
    }
}