# GitHub Stats Dashboard

A small Blazor application that fetches data from the GitHub API and visualizes a user's repositories and most used programming languages.

## 🚀 Features

- Search for any GitHub user
- Display profile information (name, bio, followers, repos)
- List repositories sorted by latest update
- Show programming languages used across repositories
- Visualize language distribution using a custom pie chart

## 🧠 Tech Stack

- Blazor (Server / Interactive)
- C#
- .NET
- GitHub REST API
- CSS (including `conic-gradient` for chart visualization)

## 📊 How it works

1. User enters a GitHub username  
2. App fetches data from:
   - `/users/{username}`
   - `/users/{username}/repos`
3. Repositories are grouped by language  
4. Data is transformed into percentages  
5. A dynamic pie chart is generated using CSS  

## 🎨 Pie Chart Implementation

The pie chart is built using:

```css
conic-gradient(...)