import "bootstrap/dist/css/bootstrap.min.css";
import "./styles.css";
import DnbBody from "./Components/DnbBody";
import { AdvanceSearch } from "./Components/DnbRSide";

export default function App() {
  const cursorStyle = {"cursor" : "pointer"};

  return (
    <div className="App">
      <div className="container-fluid">
        <div className="row dnb-mobile-sticky-top" id="dnb-header">
          <div className="col-xl-2 col-lg-3 col-md-4 col-12 col-wrap pt-3">
            <div className="text-primary text-left">
              <h3 style={cursorStyle}>Ecma</h3>
            </div>
          </div>
          <AdvanceSearch />
        </div>
        <DnbBody />
      </div>
    </div>
  );
}
