# Authentication UI
Create a SPA consuming this backend service. Backend service is mimicking authentication flow and authorized users will be able to access specific resource, list of users in this case.

There will be two pages.

1. Login page : Receive email and password from user. Post credentials to /login endpoint and get token in response. Email validation is required on front end. If authentication is successful user will be redirected to second page.
2. User List page : This page will list users from backend if user is authorized. On right top corner user name will be presented on "my profile" segment.

There are two types of user in backend 
Admin : It has the access right to user list endpoint (/users). It has access right to get /myprofile endpoint.
User : It has access right to get /myprofile endpoint. If user list page is requested, there will be popup prompting "you are not authorised to see this page"
Anonymous users will be rejected to see user list page and redirected to login page.


**Unit tests are required for FE.**

**Deploying back end and front end services to cloud are big plus**
