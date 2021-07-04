import { Component } from "react";
import { DataProps } from "../Common/Types";
import $ from "jquery";

// <ScrollHorizontal data={} />
export class ScrollHorizontal extends Component<DataProps> {
  componentDidMount() {
    let isEnd = false,
      startX = 0,
      scrollLeft = 0,
      timeSpeed = 0,
      isLong = false;
    var $slider = $(".dnb-slider"),
      ignore = "dnb-link";

    $slider.on("mousemove", function (this: typeof $slider, e: any) {
      if (!isEnd) return;
      if (!isLong) {
        timeSpeed = new Date().getMilliseconds() - timeSpeed;
        if (timeSpeed > 200) isLong = true;
      }

      if (isLong) $(this).scrollLeft(scrollLeft + startX - e.pageX);
    });
    $slider.on("mouseup mouseleave", function (this: typeof $slider, e: any) {
      timeSpeed = new Date().getMilliseconds() - timeSpeed;
      scrollLeft = (startX - e.pageX) * 2;
      if (timeSpeed > 0 && timeSpeed < 200 && scrollLeft !== 0) {
        let $_this = $(this);
        if($_this !== undefined) {
          let num = $_this.scrollLeft() || 0;
          $_this
            .stop()
            .animate(
              { scrollLeft: num + scrollLeft },
              2 * timeSpeed,
              "linear",
              function () {
                // Done animate swing/linear
              }
            );
        }
        
      }
      isEnd = false;
    });
    $slider.on("mousedown", function (this: typeof $slider, e: any) {
      if ($(e.target).hasClass(ignore)) return;
      isEnd = true;
      startX = e.pageX;
      scrollLeft = $(this).scrollLeft() || 0;
      timeSpeed = new Date().getMilliseconds();
    });
  }

  componentWillUnmount() {
    // TODO
  }

  render() {
    const _propsData = this.props.data || [];

    return (
      <div className="dnb-slider rounded-lg scrollbar-h0 dnb-overx-scroll">
        <div className="d-flex flex-row">
          {_propsData.map((elm) => {
            return elm;
          })}
        </div>
      </div>
    );
  }
}
