# Client-Api communications


## HomeController

### GET /
- List of Property with {address{street, muncipality}, id, price, livingspace, rooms, image, description excerpt}, Agency {name, logo}
- List of muncipalities

## GET /Search

## GET /All

## GET /Agents

## GET /Contact CustomerService?


## AccountController

### POST /Account/Login
- Email, Password

### GET /Account/Register
- List of Agencies
### POST /Account/Register
- {FirstName, LastName, Email, Phone, ProfileImage, Agency}

### GET /Account/Profile
- {FirstName, LastName, Email, Phone, ProfileImage}
### POST /Account/Profile
- {FirstName, LastName, Email, Phone, ProfileImage}


## DashboardController

### GET /Dashboard/Index
- {NumberOfSold, NumberOfProperties, Views}

### GET /Dashboard/MyProperties
- For filtering {muncipalities, propertytypes}
- List of properties {Id, image, address{street, city}, muncipality, listprice, rooms, livingspace, propertytype}

### GET /Dashboard/Agency
- {Name, Presentation, LogoUrl}
- List of Agents {profileimage, FirstName, LastName}
### POST /Dashboard/Agency
- {Name, Presentation, LogoUrl}


## Property (PropertyController)
### GET /Property/Create
- List of Agents (from own agency)
- list of PropertyTypes
- list of muncipalities

### POST /Property/Create
- {PropertyType(int), BuildYear, Address, LivingSpace, Rooms, SecondaryArea, Lotsize, monthlyfee, operationalcostperyear, listingprice, description, list of imageurls, agentid }

### GET /Property/Edit/1
- list of all muncipalities
- list of all agents
- {PropertyType(int), BuildYear, Address, LivingSpace, Rooms, SecondaryArea, Lotsize, monthlyfee, operationalcostperyear, listingprice, description, list of imageurls, agentid }

### POST /Property/Edit/1
- {PropertyType(int), BuildYear, Address, LivingSpace, Rooms, SecondaryArea, Lotsize, monthlyfee, operationalcostperyear, listingprice, description, list of imageurls, agentid }
