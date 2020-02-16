ISAD251_AndyLam
==================

Please note that this uses Asp.net Identity Code First migration which means the database is generated from the code. To do this the first time simply compile the app and run: 

    update-database
    
From the package manager console and then run the app. 

To login as an admin try the following

Admin Account

    user: admin@gmail.com
    password: abc123

Guest Account
    
    user: guest@guest.com
    password: guest1

# ISAD251-Coursework
##### Links:
- YouTube Video : https://www.youtube.com/watch?v=sKgK2xljjJc

### Application Factsheet
#### The Application
This application is designed to be a minimum viable product for a system that allows a customer of a pub to order drinks or snacks from the pub's website. Customers can view and add different types of products for sale to their order. The types of products include Alcoholic Beverages, Soft Drinks and Bar Snacks. The application also allows admins (owners of the pub) to add, view, edit or withdraw products that they sell. Admins are also able to view any past customer orders by either entering a Customer ID or viewing ALL past orders. These are the top 5 functions/features of the application:
* Customers can add multiple different types of products to their order basket to order.
* Customers can remove any products they no longer wish to order from their basket.
* Admins can add new products to be sold.
* Admins can View or Edit product details or Withdraw a product from sale.
* Admins can view all past orders of customers or search for a specific customer's past orders using a Customer ID.

#### How It Works
The application uses HTML and C# to communicate with a MSSQL database to retrieve details of the products for sale and any past orders. **IMPORTANT:** To access Admin functionality enter **"admin"** as the **Username** and the **Password**.
