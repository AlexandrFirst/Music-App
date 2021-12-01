import React from 'react';
import './attractionPage.css'
import AttractionBox from '../../components/attractionBox/attractionBox'
import Header from "../../components/header/header";
import Footer from "../../components/footer/footer";
import {useActions} from "../../hooks/useActions";
import {useParams} from "react-router-dom";
import {useTypedSelector} from "../../hooks/useTypedSelector";
import Spinner from "../../components/spinner/spinner";

export interface AttractionPageProps {

}

const AttractionPage:React.FC<AttractionPageProps> = () => {

    const {data, error, isLoading} = useTypedSelector(state => state.place);
    const {getPlace} = useActions();
    const params = useParams<{ id: string }>();
    //
    React.useEffect(() => {
        const id = Number(params.id);
        getPlace(id);
    }, [])

    React.useEffect(() => {
    }, [data])

    if(isLoading) {
        return <Spinner classes="spinner"/>
    }
    if (error) {
       return <h1>{error}</h1>
    }

    return (
        <div className="boxContainer">
            <Header/>
            <AttractionBox data={data}/>
            <Footer/>
        </div>
    );
};

export default AttractionPage;