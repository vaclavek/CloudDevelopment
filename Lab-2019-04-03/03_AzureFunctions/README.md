# CloudDevelopment
## Azure Functions

*Task: Create an Azure Function which will get your zodiac sign by date of birth. Than deploy it to Azure.*

1. Create a new project for Azure Function

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/af_1_create_project.png)
![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/af_2_create.png)

2. Write code. You can use [attached project](https://github.com/vaclavek/CloudDevelopment/blob/master/Lab-2019-04-03/03_AzureFunctions/ZodiacFunctions.sln).

3. Test it locally (just start debugging with F5 key)

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/af_3_run.png)

4. Make a web request ([by browser](http://localhost:7071/api/GetSign?dateOfBirth=2000-05-03))

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/af_4_run.png)

5. Now you can publish the Function to Azure

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/af_5_publish.png)
![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/af_6_publish.png)

Make sure you have set hosting plan size to **Consumtion**.

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/af_7_publish.png)
![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/af_8_publish.png)

6. Copy URL of created Function to be able to use it

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/af_9_publish.png)

7. Look at the Azure portal

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/af_10_portal.png)
![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/af_11_portal.png)

8. Because we published function "as package file" (see 5), the Function is not editable. But we can test it.

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/af_12_test.png)
![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/af_13_result.png)

9. We can now use it anywhere. For example in browser :)

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/af_14_result.png)