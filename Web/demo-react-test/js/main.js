import { LikeButton } from "./exportButton.js";

const e = React.createElement;

const domContainer = document.querySelector('#like_button_container');
const root = ReactDOM.createRoot(domContainer);
root.render(e(LikeButton));