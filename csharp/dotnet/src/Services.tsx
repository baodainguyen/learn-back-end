import { PopularProps, StreamProps } from "./Common/Types";
import { PopularItem } from "./Components/Popular";

const Popular: Array<PopularProps> = [
  {
    Title: "Ui/Ux Design",
    TimeM: 187,
    Lessions: 28,
    Description: `Some text here class creates a grid of cards that are of equal
      height and width. The layout will automatically adjust as you
      insert more cards.`,
    Avatar: "https://www.w3schools.com/bootstrap4/img_avatar6.png",
    Bg:
      "https://www.geeklawblog.com/wp-content/uploads/sites/528/2018/12/liprofile-656x369.png"
  },
  {
    Title: "React Native",
    TimeM: 201,
    Lessions: 35,
    Avatar: "https://www.w3schools.com/bootstrap4/img_avatar3.png",
    Bg:
      "https://lumiere-a.akamaihd.net/v1/images/sa_pixar_virtualbg_coco_16x9_9ccd7110.jpeg"
  },
  {
    Title: "React JSX",
    TimeM: 99,
    Lessions: 15
  }
];

const Streams: Array<StreamProps> = [
  {
    Name: "Dai NB",
    Avatar: "https://www.w3schools.com/bootstrap4/img_avatar1.png"
  },
  {
    Name: "Than Dieu",
    Avatar: "https://www.w3schools.com/bootstrap4/img_avatar2.png"
  },
  {
    Name: "Dan Pho",
    Avatar: "https://www.w3schools.com/bootstrap4/img_avatar3.png"
  },
  {
    Name: "Dan To",
    Avatar: "https://www.w3schools.com/bootstrap4/img_avatar6.png"
  }
];

export const Data = {
  Streams: Streams,
  Popular: Popular
};

export const Service = {
  getPopulars: function (data: Array<PopularProps>) {
    return data.map((popular, i) => {
      return (
        <PopularItem
          key={i + "_" + popular.Title}
          Title={popular.Title}
          TimeM={popular.TimeM}
          Lessions={popular.Lessions}
          Description={popular.Description}
          Avatar={popular.Avatar}
          Bg={popular.Bg}
        />
      );
    });
  },
  getStreams: function (data: Array<StreamProps>) {
    return data.map((stream, i) => {
      return (
        <img
          key={i + "_" + stream.Name}
          alt={stream.Name}
          className="rounded-lg m-2 dnb-64px"
          src={stream.Avatar}
        />
      );
    });
  }
};
