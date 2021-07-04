export interface ScrollState {
  ItemsCount?: Number;
}
export interface DataProps extends ScrollState {
  data?: Array<JSX.Element>;
}

export interface PopularProps {
  Title: string;
  TimeM: Number;
  Lessions: Number;
  Description?: string;
  Avatar?: string;
  Bg?: string;
}
export interface StreamProps {
  Name: string;
  Avatar: string;
}
export interface SearchState {
  TextSearch: string;
}
export interface SearchProps {}

export interface LoadingProps {
  width: number;
  height: number;
  className?: string;
}
