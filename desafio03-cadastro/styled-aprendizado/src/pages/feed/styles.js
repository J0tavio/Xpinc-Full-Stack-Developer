import styled from "styled-components";

export const Container = styled.main`
  width: 100%;
  max-width: 80%;
  margin: 0 auto;
  margin-top: 120px;

  display: flex;
  flex-direction: row;
`;

export const Title = styled.h3`
  font-family: "Open Sans";
  font-style: normal;
  font-weight: 700;
  font-size: 18px;
  line-height: 44px;
  margin-bottom: 24px;
  color: #ffffff;
`;

export const TitleHightLight = styled.h3`
  font-family: "Open Sans";
  font-style: normal;
  font-weight: 700;
  font-size: 18px;
  line-height: 25px;
  color: #ffffff70;
  margin-bottom: 24px;
`;

export const Column = styled.div`
  flex: ${({ flex }) => flex};
  padding-right: 24px;
`;
