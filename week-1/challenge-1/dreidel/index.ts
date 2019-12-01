import { AzureFunction, Context, HttpRequest } from "@azure/functions";

const httpTrigger: AzureFunction = async function(
  context: Context,
  req: HttpRequest
): Promise<void> {
  const diceValues = ["נ", "ג", "ה", "ש"];
  context.res = {
    headers: {
      "content-type": "text/html"
    },
    body: `<div style="display: flex; flex-direction: column; align-items: center; justify-content: center;text-align: center;">
              <div style="width: 200px; height: 200px; font-size: 120px; background-color: #2f77ff;color: #ffb215;align-items: center;height: 100%;">
              ${diceValues[Math.floor(Math.random() * diceValues.length)]}<br/>
              </div>
              <div style="font-size: 12px; align-items: center;height: 100%;">
              ${new Date().toLocaleString()}
              </div>
           </div>`
  };
};

export default httpTrigger;
