import {
  faEllipsisH,
  faHome,
  faSearch,
  faCommentDots,
  faCog
} from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import React, { Component } from "react";
import { LoadingProps } from "./Common/Types";
import "./Common/loading.css";

type IconType = { name: string; className?: string };
export class IconD extends Component<IconType> {
  render() {
    const { name, className } = this.props;
    const cls = className || className !== "fas" ? `fas ${className}` : "fas";
    switch (name) {
      case "comment-dots":
        return <FontAwesomeIcon icon={faCommentDots} className={cls} />;
      case "search":
        return <FontAwesomeIcon icon={faSearch} className={cls} />;
      case "ellipsis-h":
        return <FontAwesomeIcon icon={faEllipsisH} className={cls} />;
      case "cog":
        return <FontAwesomeIcon icon={faCog} className={cls} />;
      case "home":
        return <FontAwesomeIcon icon={faHome} className={cls} />;
      default:
        return <div className="dainb" />;
    }
  }
}

export class LoadingItem extends Component<LoadingProps> {
  render() {
    const { width, height, className } = this.props;
    let _cls = "dnb-loading-animated rounded-lg";
    if (className !== undefined) {
      _cls += ` ${className}`;
    }
    const _css = {
      width: `${width}px`,
      minWidth: `${width}px`,
      maxWidth: `${width}px`,
      height: `${height}px`,
      minHeight: `${height}px`,
      maxHeight: `${height}px`
    };
    const _key = width + Date.now().toString();
    return <div className={_cls} style={_css} key={_key}></div>;
  }
}