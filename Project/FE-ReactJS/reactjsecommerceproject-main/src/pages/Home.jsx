import { Navbar, Main, Product, Footer } from "../components";
import { useSelector } from "react-redux/es/hooks/useSelector";

function Home() {

  return (
    <>
      <Navbar />
      <Main />
      <Product />
      <Footer />
    </>
  )
}

export default Home