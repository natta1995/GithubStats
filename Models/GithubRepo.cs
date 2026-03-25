namespace GithubStats.Models
{
    public class GitHubRepo
    {
        public string name { get; set; } = "";
        public string description { get; set; } = "";
        public string language { get; set; } = "";
        public int stargazers_count { get; set; }
        public int forks_count { get; set; }
        public string html_url { get; set; } = "";
        public DateTime updated_at { get; set; }
    }
}