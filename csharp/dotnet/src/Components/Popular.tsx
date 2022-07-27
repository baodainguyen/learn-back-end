import React, { Component } from "react";
import { PopularProps, DataProps } from "../Common/Types";
import { Data, Service } from "../Services";
import { ScrollHorizontal } from "../Common/Libraries";
import { LoadingItem } from "../Assets";

export class PopularItem extends Component<PopularProps, PopularProps> {
  constructor(props: PopularProps) {
    super(props);
    const _p = Object.assign({}, props);
    this.state = _p;
  }

  render() {
    const { Title, TimeM, Lessions, Description, Avatar, Bg } = this.state;
    let bgStyle = {};
    if (Bg !== undefined) {
      bgStyle = { backgroundImage: `url(${Bg})` };
    }
    let imgAva = "https://www.w3schools.com/bootstrap4/img_avatar1.png";
    if (Avatar !== undefined) {
      imgAva = Avatar;
    }

    return (
      <div
        className="card bg-warning rounded-lg box-264-396 mr-4 border-0 bg-img-ui"
        style={bgStyle}
      >
        <div className="card-body d-flex flex-column">
          <div className="card-title flex-grow-1">
            <div className="d-flex text-white">
              <img alt={Title} className="rounded mr-2 dnb-64px" src={imgAva} />
              <div className="d-flex flex-column flex-grow-1">
                <div className="d-flex justify-content-between">
                  <h4 className="card-text mb-0">{Title}</h4>
                  <h6 className="align-self-end pt-2">{TimeM} mins</h6>
                </div>
                <p>{Lessions} lessions</p>
              </div>
            </div>
          </div>
          {(() => {
            if (Description !== undefined) {
              return (
                <div className="card-text bg-light rounded p-3">
                  <p className="mb-0 dnb-whitespace-i">{Description}</p>
                </div>
              );
            }
          })()}
        </div>
      </div>
    );
  }
}

export default class PopularThisWeek extends React.Component<{}, DataProps> {
  state: DataProps = {
    data: undefined
  };
  constructor(props: any) {
    super(props);
    this.getPopulars = this.getPopulars.bind(this);
  }

  componentDidMount() {
    this.getPopulars();
  }

  async getPopulars() {
    setTimeout(() => {
      const populars = Service.getPopulars(Data.Popular);
      this.setState({ data: populars });
    }, 3000);
  }

  render() {
    const { data } = this.state;
    let _elm;
    if (data === undefined) {
      _elm = <LoadingItem width={480} height={396} />;
    } else {
      _elm = <ScrollHorizontal data={data} />;
    }

    return (
      <div>
        <h2 className="text-left">Popular this week</h2>
        <div className="dnb-wrap">
          <div className="dnb-slide-bound dnb-overy-hide">
            <div className="dnb-slide-wrap dnb-overx-auto">{_elm}</div>
          </div>
        </div>
      </div>
    );
  }
}

// https://gist.github.com/flushentitypacket/7717cb30d1b172e633cea864eeb4d2e7
