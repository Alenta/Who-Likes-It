namespace Who_Likes_It;

class Program
{
    static void Main(string[] args)
    {
        string[] names = {"Lasse", "Petter", "Jonas"};
        Console.WriteLine(Likes(names));
    }

    public static string Likes(string[] name)
    {
        string reply = "";
        if(name.Count() == 0) reply = "No one likes this";
        else {
            for (int i = 0; i < name.Count(); i++)
            {
                
                if(i+2<=name.Count())reply+= name[i] + ", "; //There are more than two names left
                else if(i + 1 <=name.Count())reply+="and " + name[i] +" "; //There is one name left
                else reply+= reply += name[i] + " "; //This should be the last name
            }
            reply += "likes this.";
        }
        return reply;
    }
}
