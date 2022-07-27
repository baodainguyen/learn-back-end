import { Component } from "react";
import DnbRightSide from "../Components/DnbRSide";
import { Navigator, StreamingNow } from "../Components/SmallParts";
import PopularThisWeek from "../Components/Popular";
import TopTopics from "../Components/Topics";

class Body extends Component {
  render() {
    return (
      <div className="dnb-per-3-4 col-xl-10 col-lg-9 col-md-8 col-12 col-wrap mt-n5">
        <div className="row">
          <div className="dnb-per-1-2 col-xl-8 col-lg-8 col-md-12 col-wrap pt-4">
            <div className="mb-4 mt-5">
              <StreamingNow />
              <PopularThisWeek />
            </div>
            <TopTopics />
          </div>
          <DnbRightSide />
        </div>
      </div>
    );
  }
}

export default class DnbBody extends Component {
  render() {
    return (
      <div className="row mt-1 mt-n9" id="dnb-body">
        <div className="dnb-per-1-4 col-xl-2 col-lg-3 col-md-4 col-12 col-wrap mt-5">
          <div className="dnb-mobile-sticky">
            <Navigator />
            <div>
              <div className="card flex-row align-items-center bg-light rounded-lg pt-3 pb-3 pl-3 mb-5 minw200">
                <img
                  className="rounded dnb-44px"
                  src="https://www.w3schools.com/bootstrap4/img_avatar1.png"
                  alt="avatar"
                />
                <div className="card-body pt-0 pb-0">
                  <strong className="card-title m-0">Updated course</strong>
                  <p className="card-text">by @carius</p>
                </div>
              </div>
            </div>
            <div>
              <div className="d-grid d-grid-lst mb-4">
                <div className="card bg-warning rounded-lg box-h111">
                  <div className="card-body text-center d-flex flex-column pl-1 pr-1">
                    <div className="card-title flex-grow-1">
                      <i className="fas fa-cog"></i>
                    </div>
                    <div className="card-text">
                      <strong>1800</strong>
                      <p>points</p>
                    </div>
                  </div>
                </div>
                <div className="card bg-warning rounded-lg box-h111">
                  <div className="card-body text-center d-flex flex-column pl-1 pr-1">
                    <div className="card-title flex-grow-1">
                      <i className="far fa-comment-dots"></i>
                    </div>
                    <div className="card-text">
                      <strong>55%</strong>
                      <p>complete</p>
                    </div>
                  </div>
                </div>
                <div className="card rounded-lg minw200 box-h99 bg-img-ui text-white">
                  <div className="card-body d-flex">
                    <div className="card-title flex-grow-1">
                      <strong>Author</strong>
                    </div>
                    <div className="card-text d-flex justify-content-between">
                      <p className="text-right mb-0">+178 Posts</p>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        <Body />
      </div>
    );
  }
}
