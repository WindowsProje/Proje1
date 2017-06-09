using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Repository.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
        IBankaBilgiRepository BankaBilgileri { get; }
        ISirketKayitRepository SirketKayitlari { get; }
        IHataKayitRepository HataKayitlari { get; }
        IUlkeRepository UlkeKayitlari { get; }
        ICariHareketRepository CariHareketleri { get; }
        ICariKayitRepository CariKayitlari { get; }
        IDepoKayitRepository DepoKayitlari { get; }
        IDilRepository DilKayitlari { get; }
        IDosyaRepository DosyaKayitlari { get; }
        IDovizBirimRepository DovizBirimleri { get; }
        IGrupRepository GrupKayitlari { get; }
        IIlceRepository IlceKayitlari { get; }
        IKullaniciRepository KullaniciKayitlari { get; }
        IRolRepository Roller { get; }
        ISehirRepository SehirKayitlari { get; }
        IYetkiRepository Yetkiler { get; }
        IYetkiAlanRepository YetkiAlanlari { get; }
        IYetkiDetayRepository YetkiDetaylari { get; }
        IStackTraceFrameRepository StackTraceFrames { get; }
        IAdetBirimRepository AdetBirimleri { get; }
        IAlacakBakiyeRepository AlacakBakiyeleri { get; }
        IAlisFiyatRepository AlisFiyatlari { get; }
        IBankaHareketRepository BankaHareketleri { get; }
        IBankaKayitRepository BankaKayitlari { get; }
        IBorcBakiyeRepository BorcBakiyeleri { get; }
        ICekRepository Cekler { get; }
        IFaturaBilgiRepository FaturaBilgileri { get; }
        IHareketSecimRepository HareketSecimleri { get; }
        IKasaHareketRepository KasaHareketleri { get; }
        IKasaKayitRepository KasaKayitlari { get; }
        IKdvOranRepository KdvOranlari { get; }
        IKrediKartRepository KrediKartlari { get; }
        IPosRepository Poslar { get; }
        ISatisFiyatRepository SatisFiyatlari { get; }
        ISenetRepository Senetler { get; }
        ISirketTurRepository SirketTurleri { get; }
        IStokBakiyeUyariRepository StokBakiyeUyarilari { get; }
        IStokHareketRepository StokHareketleri { get; }
        IStokKayitRepository StokKayitlari { get; }
        ITedarikciBilgiRepository TedarikciBilgileri { get; }
        int Complete();
        Task<int> CompleteAsync();
    }
}
