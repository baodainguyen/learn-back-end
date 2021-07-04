import React, { Component } from "react";
import { SearchState, SearchProps } from "../Common/Types";
import { Form, Button } from "react-bootstrap";

export class AdvanceSearch extends Component {
  state: SearchState = {
    TextSearch: ""
  };
  constructor(props: SearchProps) {
    super(props);
    this.handleChange = this.handleChange.bind(this);
    this.onFind = this.onFind.bind(this);
    this.handleKey = this.handleKey.bind(this);
  }
  handleChange(e: React.ChangeEvent<HTMLInputElement>) {
    const newValue = e.currentTarget.value;
    this.setState({ TextSearch: newValue });
  }
  handleKey(e: React.KeyboardEvent) {
    if (e.key === "Enter") {
      console.log(this.state.TextSearch);
    }
  }
  onFind() {
    console.log(this.state.TextSearch);
  }

  render() {
    return (
      <div className="col-xl-10 col-lg-9 col-md-8 col-12 col-wrap">
        <div className="row">
          <div className="col-xl-8 col-lg-8 col-md-12 col-wrap">
            <div></div>
          </div>
          <div className="dnb-search col-xl-4 col-lg-4 col-md-12 col-wrap pt-3">
            <div>
              <div className="d-flex justify-content-between">
                <h4>Advanced Search</h4>
              </div>
              <div className="mb-3">
                <div className="input-group">
                  <Form.Control
                    className="form-control bg-light rounded border-0"
                    type="text"
                    onChange={this.handleChange}
                    onKeyUp={this.handleKey}
                    placeholder="find something..."
                  />
                  <div className="input-group-append">
                    <Button
                      className="btn rounded font-weight-bold pr-3 pl-3 ml-2"
                      variant="primary"
                      onClick={this.onFind}
                      type="submit"
                    >
                      Find
                    </Button>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

export default class DnbRightSide extends Component {
  render() {
    return (
      <div className="dnb-per-1-3 col-xl-4 col-lg-4 col-md-12 col-wrap mt-9">
        <div className="mt-5 text-left">
          <div className="mt-n1">
            <h2>Category</h2>
            <div className="d-grid d-grid-1st mb-4">
              <div className="card rounded-lg box-h198 bg-img-ui text-white">
                <div className="card-body d-flex flex-column">
                  <div className="card-title flex-grow-1">
                    <div className="d-flex flex-column">
                      <div className="d-flex justify-content-between">
                        <h4 className="card-text mb-0">Design pattern in js</h4>
                        <h6 className="align-self-end pt-2">280 mins</h6>
                      </div>
                      <p>38 lessions</p>
                    </div>
                  </div>
                  <div className="card-text d-flex justify-content-between">
                    <button className="btn bg-light rounded pl-3 pr-3 pt-2 pb-2">
                      <span className="fas fa-play ml-1 mt-2 mb-2"></span>
                    </button>
                    <div className="align-self-center ml-2">
                      <strong className="text-right mb-0">
                        +178 Student enrolled
                      </strong>
                    </div>
                  </div>
                </div>
              </div>
              <div className="card bg-warning rounded-lg box-h198">
                <div className="card-body text-center">
                  <p className="card-text">Some text here</p>
                </div>
              </div>
              <div className="card bg-warning rounded-lg box-h198">
                <div className="card-body text-center">
                  <p className="card-text">Some text here</p>
                </div>
              </div>
            </div>
          </div>
          <div className="mb-3">
            <h2>Special Offers</h2>
            <div>
              <div className="card bg-warning rounded-lg box-h198">
                <div className="card-body text-center">
                  <p className="card-text">Something in here</p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    );
  }
}
