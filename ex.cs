public class WebPageManagerFactory
{
    public WebPageManager Create(int websiteChannelID, int userID)
    {
        // Logic to create and return a WebPageManager instance
        return new WebPageManager(websiteChannelID, userID);
    }
}

public class WebsiteChannelContext
{
    public int WebsiteChannelID { get; set; }
}

public class User
{
    public int UserID { get; set; }
}

public class WebPageManager
{
    private int _websiteChannelID;
    private int _userID;

    public WebPageManager(int websiteChannelID, int userID)
    {
        _websiteChannelID = websiteChannelID;
        _userID = userID;
    }

    // Other methods and properties
}

// Usage example
WebsiteChannelContext websiteChannelContext = new WebsiteChannelContext { WebsiteChannelID = 123 };
User user = new User { UserID = 456 };
WebPageManagerFactory webPageManagerFactory = new WebPageManagerFactory();

WebPageManager webPageManager = webPageManagerFactory.Create(websiteChannelContext.WebsiteChannelID, user.UserID);
