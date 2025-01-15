# ArticleHub

ArticleHub is a Blazor application designed to fetch and display articles from a REST API. The application provides a user-friendly interface to browse articles and view detailed information about each article.

## Features

- Fetch and display a list of articles from an API.
- View detailed information about a selected article.
- Error handling for failed data fetching or rendering issues.
- State management to ensure smooth UI rendering.
- Clean and minimalistic UI design.


## API Endpoints

1. **Get All Articles**  
   `GET https://ps-dev-1-partnergateway.patientsky.dev/assignment/articles`  
   Fetches a list of articles.

2. **Get Article by ID**  
   `GET https://ps-dev-1-partnergateway.patientsky.dev/assignment/articles/{id}`  
   Fetches the details of a specific article by its ID.

---

## Getting Started

### Prerequisites

- [.NET SDK 6.0+](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (or any compatible IDE)
- API Endpoint: Make sure the API for fetching articles is accessible.

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/ArticleHub.git
   cd ArticleHub
