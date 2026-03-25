namespace GithubStats.Models
{
    public class GitHubUser
    {
        public string login { get; set; } = "";
        public string name { get; set; } = "";
        public string bio { get; set; } = "";
        public string avatar_url { get; set; } = "";
        public int public_repos { get; set; }
        public int followers { get; set; }
        public int following { get; set; }
    }
}
