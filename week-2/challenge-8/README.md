# Challenge 8: Build an Incident Status Page

![The Elves' Incidents](https://res.cloudinary.com/jen-looper/image/upload/v1575132446/images/challenge-8_ryfir2.jpg)

It's December 8th and Santa and his team are hard at work preparing for the big night, including replacing many of the servers and applications that run the reindeer guidance and delivery systems.

If something goes wrong with any part of that critical system, they need a way to report the status of disruptions to everyone involved in a successful Christmas morning. 

They need a basic version of what you can find at [status.azure.com](https://status.azure.com).

During these tense disruptions, elves are actively diagnosing and working as quickly as possible to bring important systems back online. While response and remediation efforts are underway, it's important everyone who has a stake in the successful delivery of gifts stay "in the know".

We are tasked with building a method for Santa and his team to communicate the current status of service disruptions to a global audience. A "Status Page" solution.

## Challenge

Your challenge is to create a simple solution that helps inform elves and helpers all over the world when there is a problem with Santa's Reindeer Guidance & Delivery System - a "Status Page" to inform everyone what is known, what is being done, and when to expect additional information.

## Tips

There are many approaches to broadcasting critical information like this.
For simplicity, we might consider keeping the team informed by setting and broadcasting the current "Status" as 1 of 3 states:

* *Open*
* *Closed*
* *Ongoing* (or update)

The "*Open*" state means **we have a problem** (Service Disruption / Offline).
The "*Closed*" state means **our problem is resolved** (Service Restored / Online).
The "*Ongoing*" state means **we are still investigating** (Standby for more updates).


## Resources/Tools Used 🚀

✅ **Microsoft Azure:**

* Free account: [https://azure.microsoft.com/](https://azure.microsoft.com/?WT.mc_id=25daysofserverless-github-cxa)

✅ **Azure Functions:**

* Docs: [Azure Function](https://docs.microsoft.com/en-us/azure/azure-functions/?WT.mc_id=25daysofserverless-github-cxa)
* Learn: [https://docs.microsoft.com/learn/modules/create-serverless-logic-with-azure-functions/](https://docs.microsoft.com/learn/modules/create-serverless-logic-with-azure-functions/?WT.mc_id=25daysofserverless-github-cxa)
* How To Get Started (Video): [https://azure.microsoft.com/resources/videos/get-started-with-azure-functions/](https://azure.microsoft.com/resources/videos/get-started-with-azure-functions/?WT.mc_id=25daysofserverless-github-cxa)
* Supported Languages: [https://docs.microsoft.com/azure/azure-functions/supported-languages/](https://docs.microsoft.com/azure/azure-functions/supported-languages/?WT.mc_id=25daysofserverless-github-cxa)

✅ **Azure Storage:**

* Product: [https://azure.microsoft.com/services/storage/](https://azure.microsoft.com/services/storage/?WT.mc_id=25daysofserverless-github-cxa)
* Docs: [https://docs.microsoft.com/azure/storage/](https://docs.microsoft.com/azure/storage/?WT.mc_id=25daysofserverless-github-cxa)
* Learn: [https://docs.microsoft.com/en-us/learn/modules/create-azure-storage-account/](https://docs.microsoft.com/en-us/learn/modules/create-azure-storage-account/?WT.mc_id=25daysofserverless-github-cxa)

✅ **SignalR:**

* Product: [https://azure.microsoft.com/services/signalr-service/](https://azure.microsoft.com/services/signalr-service/?WT.mc_id=25daysofserverless-github-cxa)
* Docs: [https://docs.microsoft.com/azure/azure-signalr/signalr-overview/](https://docs.microsoft.com/azure/azure-signalr/signalr-overview/?WT.mc_id=25daysofserverless-github-cxa)
* w/ Azure Functions: [https://docs.microsoft.com/azure/azure-signalr/signalr-concept-azure-functions/](https://docs.microsoft.com/azure/azure-signalr/signalr-concept-azure-functions/?WT.mc_id=25daysofserverless-github-cxa)
* Learn: [https://docs.microsoft.com/learn/modules/automatic-update-of-a-webapp-using-azure-functions-and-signalr/](https://docs.microsoft.com/learn/modules/automatic-update-of-a-webapp-using-azure-functions-and-signalr/?WT.mc_id=25daysofserverless-github-cxa)

## Next Steps 🏃

Learn more about serverless technologies with free training!

* ✅ **[Free Serverless Courses](https://docs.microsoft.com/learn/browse/?term=azure%20functions&WT.mc_id=25daysofserverless-github-cxa)**

* ✅ **[Free E-Book - Azure Serverless Computing Cookbook, Second Edition](https://azure.microsoft.com/resources/azure-serverless-computing-cookbook/?WT.mc_id=25daysofserverless-github-cxa)**

## Questions? Comments?

If you have any questions about the challenge, feel free to open an **[ISSUE HERE](https://github.com/microsoft/25-days-of-serverless/issues)**. As soon as possible we will be answering any questions/doubts that you may have!
