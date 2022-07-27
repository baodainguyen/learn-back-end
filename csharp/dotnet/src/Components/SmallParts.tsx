import { Component } from "react";
import { IconD, LoadingItem } from "../Assets";
import { Data, Service } from "../Services";
import { DataProps } from "../Common/Types";

export class StreamingNow extends Component<{}, DataProps> {
  state: DataProps = {
    data: undefined
  };
  constructor(props: any) {
    super(props);
    this.getStreams = this.getStreams.bind(this);
  }
  componentDidMount() {
    this.getStreams();
  }
  async getStreams() {
    const url = "https://localhost:5001/ecma/stream";
    fetch(url, {
      method: 'GET',
      headers: { },
    })
    .then(res => res.json())
    .then(
      (result) => {
        const streams = Service.getStreams(result);
        this.setState({ data: streams });
      },
      (error) => {
        console.log(error);
      }
    )

    // setTimeout(() => {
    //   const streams = Service.getStreams(Data.Streams);
    //   this.setState({ data: streams });
    // }, 2500);
  }
  render() {
    const { data } = this.state;
    let _elm;
    if (data === undefined) {
      _elm = <LoadingItem width={52} height={52} className={"m-2"} />;
    } else {
      _elm = data.map((elm) => {
        return elm;
      });
    }

    return (
      <div>
        <div className="d-flex justify-content-between">
          <h4>Streaming Now</h4>
          <IconD name="ellipsis-h" />
        </div>
        <div className="d-flex mb-3 ml-n2">
          {_elm}
        </div>
      </div>
    );
  }
}

export class Navigator extends Component {
  render() {
    return (
      <nav className="navbar bg-light navbar-light rounded-lg pt-4 pb-4 mt-4 mb-4 minw200">
        <ul className="navbar-nav text-left">
          <li className="nav-item active">
            <a className="nav-link" href="javascriptvoid(0)">
              <IconD name="home" className="text-primary" />
              <strong className="ml-3 text-primary">Home</strong>
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link" href="javascriptvoid(0)">
              <IconD name="search" />
              <strong className="ml-3">Discover</strong>
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link" href="javascriptvoid(0)">
              <IconD name="comment-dots" />
              <strong className="ml-3">Message</strong>
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link" href="javascriptvoid(0)">
              <IconD name="cog" />
              <strong className="ml-3">Settings</strong>
            </a>
          </li>
        </ul>
      </nav>
    );
  }
}
