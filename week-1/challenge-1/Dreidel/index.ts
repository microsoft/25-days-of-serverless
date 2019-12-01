import { AzureFunction, Context, HttpRequest } from "@azure/functions"

const httpTrigger: AzureFunction = async function (context: Context, req: HttpRequest): Promise<void> {

    const dreidelValues = ["נ", "ג", "ה", "ש"];
    const dreidelColors = ["blue", "green", "#d00000", "#ff9900"];
    const randomNumber = Math.floor(Math.random() * dreidelValues.length);

    const returnValue = `<style>
    .bordered {
      border-style: solid;
      border-width: 1px;
    }
    .center-container {
      display: flex;
      justify-content: center;
      flex-direction: column;
      align-items: center;
    }
    .main-bg {
      background-color: #C19A6B;
    }
    .triangle-down {
      width: 0;
      height: 0;
      border-left: 55px solid transparent;
      border-right: 55px solid transparent;
      border-top: 25px solid #ba9465;
      margin-left: -14px;
    }
    .square {
      height: 80px;
      width: 110px;
      color: black;
      margin-left: -7px;
      font-size: 78px;
      margin-top: -1px;
      text-align: center;
      vertical-align: middle;
      line-height: 70px;
    }
    .rectangle {
      height: 35px;
      width: 20px;
    }
    .parallelogram {
      position: relative;
      height: 40px;
      width: 110px;
      transform: skew(-20deg);
      -webkit-transform: skew(-20deg);
      background-color: #d2af85;
    }
    .side-paralleogram {
      position: relative;
      height: 80px;
      width: 14px;
      transform: skew(0, -70deg);
      -webkit-transform: skew(0, -70deg);
      margin-top: -21px;
      margin-right: -7px;
      background-color: #9a7a53;
    }
  </style>
  <div class="dreidel center-container">
    <div style="z-index: 1; margin-bottom: -20px;">
      <div class="mini-rectangel main-bg" style="position: relative;
        height: 10px;
        width: 20px;
        transform: skew(-20deg);
        -webkit-transform: skew(-20deg);
        background-color: #d2af85;"></div>
      <div style="display: flex;margin-left: -2px;">
        <div class="rectangle main-bg"></div>
        <div class="mini-side-paralleogram" style="
        position: relative;
        height: 34px;
        width: 4px;
        transform: skew(0, -70deg);
        margin-top: -5px;
        background-color: #9a7a53;"></div>
      </div>
    </div>
    <div class="parallelogram"></div>
    <div style="display: flex;">
    <div class="square main-bg" style="color: ${dreidelColors[randomNumber]}">${dreidelValues[randomNumber]}</div>
      <div class="side-paralleogram"></div>
    </div>
    <div class="triangle-down"></div>
  </div>`;

    context.res = {
        headers: {
            "content-type": "text/html"
        },
        body: returnValue
    };
};

export default httpTrigger;
